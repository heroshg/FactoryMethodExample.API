namespace FactoryMethodExample.API.Models
{
    public class PaymentInputModel
    {
        public PaymentMethod PaymentMethod { get; set; }
        public double Value { get; set; }
    }
}
