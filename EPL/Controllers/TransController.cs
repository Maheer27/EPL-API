using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Transactions;
using Services.Users;
using ViewModel;

namespace EPL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransController : ControllerBase
    {

        private readonly ITransServiceInterface1 TransServ;
        public TransController(ITransServiceInterface1 transserv)
        {
            TransServ = transserv;
        }

        [HttpPost]
        public IActionResult Register(AddTransactionVM transvm)
        {

            if (TransServ.Addtrans(transvm))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost]
        public IEnumerable<GetTransactionVM> gettransaction(string userID )
        {

            return TransServ.GetTrans(userID);
        }
    }
}
