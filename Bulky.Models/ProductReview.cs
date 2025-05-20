namespace Beautique.Models
{
    public class ProductReview  // Уникаємо конфлікту з Stripe.Review
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Content { get; set; }
        public int Rating { get; set; }  // 1–5

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
