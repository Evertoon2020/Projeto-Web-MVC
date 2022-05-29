using Projeto.MVC.Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
