using FactoryMethodExample.API.Models;

namespace FactoryMethodExample.API.Infrastructure.Payments.Interfaces
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}
