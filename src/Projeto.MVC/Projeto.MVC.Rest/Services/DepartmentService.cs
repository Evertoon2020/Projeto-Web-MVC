using Projeto.MVC.Rest.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.MVC.Rest.Services
{
    public class DepartmentService
    {
        private readonly Context _context;

        public DepartmentService(Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
