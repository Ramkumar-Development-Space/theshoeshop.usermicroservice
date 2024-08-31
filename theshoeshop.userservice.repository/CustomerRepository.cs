using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theshoeshop.userservice.dataaccess.Context;
using theshoeshop.userservice.domain.Entites;
using theshoeshop.userservice.domain.Entities;

namespace theshoeshop.userservice.repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDBContext context;

        public CustomerRepository(ApplicationDBContext _context)
        {
            context = _context;
        }

        public async Task<ServiceResponseData<User>> GetCustomerById(int id)
        {
            ServiceResponseData<User> response = new();
            if (!await context.Users.AnyAsync(x => x.Id == id))
            {
                return response;
            }
            response.Data = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

            return response;
        }
    }
}
