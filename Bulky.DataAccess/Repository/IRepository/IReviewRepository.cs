using Beautique.Models;

namespace Beautique.DataAccess.Repository.IRepository
{
    public interface IReviewRepository : IRepository<ProductReview>
    {
        void Update(ProductReview obj);
    }
}
