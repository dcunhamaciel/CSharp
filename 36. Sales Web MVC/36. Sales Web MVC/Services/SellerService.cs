using SalesWebMvc.Model;
using SalesWebMvc.Models;

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
            return _context.Seller.FirstOrDefault(seller => seller.Id == id);
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            Seller seller = FindById(id);
            _context.Remove(seller);
            _context.SaveChanges();
        }
    }
}
