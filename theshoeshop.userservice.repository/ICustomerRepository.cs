using theshoeshop.userservice.domain.Entites;
using theshoeshop.userservice.domain.Entities;

namespace theshoeshop.userservice.repository
{
    public interface ICustomerRepository
    {
        Task<ServiceResponseData<User>> GetCustomerById(int id);
    }
}