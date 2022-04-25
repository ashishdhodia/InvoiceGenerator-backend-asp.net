using InvoiceGenerator.Model;

namespace InvoiceGenerator.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
