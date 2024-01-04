using User.Models;
using User.Models.Dtos;
using User.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace User.Controllers
{
    [Route("user")]
    [Controller]
    public class UserController : ControllerBase
    {
        private readonly IUserInterface UserService;

        public UserController(IUserInterface UserService)
        {
            this.UserService = UserService;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateUserDto createUserDto)
        {
            await UserService.PostUser(createUserDto);
            try
            {
                return StatusCode(201, "Sikeres hozzáadás.");
            }
            catch (Exception e)
            {

                return StatusCode(400, e.Message);
            }

        }

        [HttpGet("{all}")]
        public async Task<ActionResult<IEnumerable<Users>>> Get()
        {
            try
            {
                return StatusCode(200, await UserService.Get());
            }
            catch (Exception e)
            {

                return StatusCode(400, e.Message);
            }

        }


        [HttpGet("{userbyid}/id")]
        public async Task<Users> GetById(Guid id)
        {
            return await UserService.GetById(id);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Users>> DeleteById(Guid Id)
        {
            var result = await UserService.DeleteById(Id);
            if (result != null)
            {
                return StatusCode(200, result);
            }
            return StatusCode(400, "Nincs ilyen felhasználó");
        }
    }
}
