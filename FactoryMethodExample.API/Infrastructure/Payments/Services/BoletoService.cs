using FactoryMethodExample.API.Infrastructure.Payments.Interfaces;
using FactoryMethodExample.API.Models;

namespace FactoryMethodExample.API.Infrastructure.Payments.Services
{
    public class BoletoService : IPaymentService
    {
        public object Process(PaymentInputModel model)
        {
            return "Boleto gerado";
        }
    }
}
