using PaymentProcessor.Factory;
using PaymentProcessor.Model;

namespace PaymentProcessor.Managers
{
    public class PaymentManagerFactory
    {
        public BasePaymentFactory CreateFactory(Product product)
        {
            BasePaymentFactory paymentFactory = null;

            switch(product.ProductType)
            {
                case "PhysicalProduct": paymentFactory = new PhysicalProductFactory(product);
                    break;
                case "Membership": paymentFactory = new MembershipFactory(product);
                    break;
                case "Video": paymentFactory = new VideoFactory(product);
                    break;
            }
            return paymentFactory;
        }
    }
}
