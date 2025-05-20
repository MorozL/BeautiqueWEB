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
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
