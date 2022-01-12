namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string mensage) : base(mensage) 
        { 
        }
    }
}
