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
        private readonly ILogger<UserController> logger;

        public UserController(ICustomerRepository repository, ILogger<UserController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet("GetCustomerById")]
        public async Task<IActionResult> GetCustomerById([FromRoute] int id)
        {
            logger.LogInformation("log testing");
            //ServiceResponse<User> response = new ServiceResponse<User> ();
            try
            {
                var result = await repository.GetCustomerById(id);
                if(result.Data == null)
                {
                    throw new Exception("Data not available");
                }
                //response.Status.StatusCode = "200";
                //response.Status.StatusMessage = "Customer data retrieved successfully";
                //response.ResponseData = result;
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return BadRequest();  
            } 
        }
    }
}
