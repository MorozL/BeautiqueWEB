namespace Beautique.Models.ViewModels
{
    public class ReviewVM
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public List<ProductReview> Reviews { get; set; } = new();
        public string NewReviewContent { get; set; }
        public int NewReviewRating { get; set; }
    }
}
