using Projeto.MVC.Rest.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.MVC.Rest.Services
{
    public class SellerService
    {
        private readonly Context _context;

        public SellerService (Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert (Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
