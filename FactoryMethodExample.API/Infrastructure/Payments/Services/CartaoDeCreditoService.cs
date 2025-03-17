using FactoryMethodExample.API.Infrastructure.Payments.Interfaces;
using FactoryMethodExample.API.Models;

namespace FactoryMethodExample.API.Infrastructure.Payments.Services
{
    public class CartaoDeCreditoService : IPaymentService
    {
        public object Process(PaymentInputModel model)
        {
            return "O pagamento foi processado corretamente com o cartão de final: 1234";
        }
    }
}
