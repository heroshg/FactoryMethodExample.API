using FactoryMethodExample.API.Infrastructure.Payments.Interfaces;
using FactoryMethodExample.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethodExample.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;
        public PaymentController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post(PaymentInputModel model)
        {
            var paymentService = _paymentServiceFactory.GetService(model.PaymentMethod);

            var retorno = paymentService.Process(model);
            return Ok(retorno);
        }

    }
}
