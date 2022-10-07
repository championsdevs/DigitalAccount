using Domain.Entities;

namespace Domain.Contracts.Repositories.AddCustomer
{
    public interface IAddCustomerRepository
    {
        void AddCustomer(Customer customer);
    }
}
