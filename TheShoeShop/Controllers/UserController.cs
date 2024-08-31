using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using theshoeshop.userservice.domain.Entites;
using theshoeshop.userservice.domain.Entities;
using theshoeshop.userservice.repository;

namespace TheShoeShop.userservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICustomerRepository repository;

        public UserController(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IActionResult> GetCustomerById([FromRoute] int id)
        {
            ServiceResponse<User> response = new ServiceResponse<User> ();
            try
            {
                var result = await repository.GetCustomerById(id);

                response.Status.StatusCode = "200";
                response.Status.StatusMessage = "Customer data retrieved successfully";
                response.ResponseData = result;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Status.StatusCode = "400";
                response.Status.StatusMessage = ex.Message;
                return BadRequest(response);  
            } 
        }
    }
}
