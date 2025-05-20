using Beautique.DataAccess.Repository.IRepository;
using Beautique.DataAcess.Data;
using Beautique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Beautique.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.BarCode = obj.BarCode;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Maker = obj.Maker;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
