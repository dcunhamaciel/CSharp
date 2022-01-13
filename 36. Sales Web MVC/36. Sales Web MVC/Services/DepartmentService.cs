using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Model;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(department => department.Name).ToListAsync();
        }

    }
}
