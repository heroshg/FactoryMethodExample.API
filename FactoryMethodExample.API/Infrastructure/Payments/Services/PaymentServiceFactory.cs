using FactoryMethodExample.API.Infrastructure.Payments.Interfaces;
using FactoryMethodExample.API.Models;

namespace FactoryMethodExample.API.Infrastructure.Payments.Services
{
    /// <summary>
    /// Classe de implementação do factory method
    /// </summary>
    public class PaymentServiceFactory : IPaymentServiceFactory
    {
        private readonly CartaoDeCreditoService _cartaoService;
        private readonly BoletoService _boletoService;
        private readonly PixService _pixService;
        public PaymentServiceFactory(
            CartaoDeCreditoService cartaoService,
            BoletoService boletoService,
            PixService pixService
            )
        {
            _cartaoService = cartaoService;
            _boletoService = boletoService;
            _pixService = pixService;
        }
        public IPaymentService GetService(PaymentMethod paymentMethod)
        {
            IPaymentService paymentService;
            switch(paymentMethod)
            {
                case PaymentMethod.CartaoDeCredito:
                    paymentService = _cartaoService;
                    break;
                case PaymentMethod.Pix:
                    paymentService = _pixService;
                    break;
                case PaymentMethod.Boleto:
                    paymentService = _boletoService;
                    break;
                default:
                    throw new InvalidOperationException("Operação inválida.");
            }
            return paymentService;
        }
    }
}
