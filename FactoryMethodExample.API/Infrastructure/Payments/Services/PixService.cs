using FactoryMethodExample.API.Infrastructure.Payments.Interfaces;
using FactoryMethodExample.API.Models;

namespace FactoryMethodExample.API.Infrastructure.Payments.Services
{
    public class PixService : IPaymentService
    {
        public object Process(PaymentInputModel model)
        {
            return "LEIA O QRCODE";
        }
    }
}
