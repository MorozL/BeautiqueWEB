using Beautique.DataAcess.Data;
using Beautique.DataAccess.Repository.IRepository;
using Beautique.Models;

namespace Beautique.DataAccess.Repository
{
    public class ReviewRepository : Repository<ProductReview>, IReviewRepository
    {
        private readonly ApplicationDbContext _db;

        public ReviewRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductReview obj)
        {
            _db.ProductReviews.Update(obj);
        }
    }
}
