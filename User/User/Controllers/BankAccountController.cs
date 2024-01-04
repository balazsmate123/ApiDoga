using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Models.Dtos;
using User.Models;
using User.Repositories;

namespace User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountInterface BankAccountService;

        public BankAccountController(IBankAccountInterface BankAccountService)
        {
            this.BankAccountService = BankAccountService;
        }

        [HttpPost]
        public async Task<ActionResult> PostBankAccount(CreateBankAccountDto createBankAccountDto)
        {
            await BankAccountService.PostBankAccount(createBankAccountDto);
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
        public async Task<ActionResult<IEnumerable<BankAccounts>>> GetBankAccount()
        {
            try
            {
                return StatusCode(200, await BankAccountService.GetBank());
            }
            catch (Exception e)
            {

                return StatusCode(400, e.Message);
            }

        }
    }
}
