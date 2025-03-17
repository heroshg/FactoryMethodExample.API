using FactoryMethodExample.API.Models;

namespace FactoryMethodExample.API.Infrastructure.Payments.Interfaces
{
    public interface IPaymentService
    {
        object Process(PaymentInputModel model);
    }
}
