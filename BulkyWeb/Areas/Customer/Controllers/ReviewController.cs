using Beautique.DataAccess.Repository.IRepository;
using Beautique.Models;
using Beautique.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Beautique.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult ProductReviews(int productId)
        {
            var product = _unitOfWork.Product.Get(p => p.Id == productId);
            if (product == null) return NotFound();

            var reviews = _unitOfWork.Review.GetAll(r => r.ProductId == productId, includeProperties: "ApplicationUser")
                .OrderByDescending(r => r.CreatedAt).ToList();

            var vm = new ReviewVM
            {
                ProductId = productId,
                ProductTitle = product.Title,
                Reviews = reviews
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult AddReview(ReviewVM vm)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrWhiteSpace(vm.NewReviewContent) || vm.NewReviewRating < 1 || vm.NewReviewRating > 5)
            {
                TempData["error"] = "Please provide valid content and rating.";
                return RedirectToAction("ProductReviews", new { productId = vm.ProductId });
            }

            var review = new ProductReview
            {
                ApplicationUserId = userId,
                ProductId = vm.ProductId,
                Content = vm.NewReviewContent,
                Rating = vm.NewReviewRating,
                CreatedAt = DateTime.Now
            };

            _unitOfWork.Review.Add(review);
            _unitOfWork.Save();

            TempData["success"] = "Review added successfully!";
            return RedirectToAction("ProductReviews", new { productId = vm.ProductId });
        }
    }
}
