using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Model;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public Seller FindById(int id)
        {            
            return _context.Seller.Include(seller => seller.Department).FirstOrDefault(seller => seller.Id == id);
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
        
        public void Update(Seller seller)
        {
            if (!_context.Seller.Any(s => s.Id == seller.Id)) {
                throw new NotFoundException("Id not found.");
            }
            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public void Remove(int id)
        {
            Seller seller = FindById(id);
            _context.Remove(seller);
            _context.SaveChanges();
        }
    }
}
