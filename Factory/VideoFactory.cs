using PaymentProcessor.Interfaces;
using PaymentProcessor.Managers;
using PaymentProcessor.Model;

namespace PaymentProcessor.Factory
{
    class VideoFactory : BasePaymentFactory
    {
        public VideoFactory(Product product) : base(product)
        {
        }

        public override IPaymentManager Create()
        {
            IPaymentManager paymentManager;
            switch (product.ProductSubType)
            {
                case "Learning to Ski":
                    paymentManager = new SkiVideoPaymentManager();
                    break;
                default:
                    paymentManager = new VideoPaymentManager();
                    break;
            }
            return paymentManager;
        }
    }
}
