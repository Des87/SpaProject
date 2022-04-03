
namespace SpaProject.Repositories
{
    public interface IFirstAndLastCustomerRepository
    {
        Task<DateTime> FirstCustomer();
        Task<DateTime> LastCustomer();
    }
}