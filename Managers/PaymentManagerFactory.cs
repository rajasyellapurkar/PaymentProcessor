using PaymentProcessor.Factory;
using PaymentProcessor.Model;
using PaymentProcessor.Utilities;

namespace PaymentProcessor.Managers
{
    public class PaymentManagerFactory
    {
        public BasePaymentFactory CreateFactory(Product product, IEmailUtility emailUtility)
        {
            BasePaymentFactory paymentFactory = null;

            switch(product.ProductType)
            {
                case "PhysicalProduct": paymentFactory = new PhysicalProductFactory(product);
                    break;
                case "Membership": paymentFactory = new MembershipFactory(product, emailUtility);
                    break;
                case "Video": paymentFactory = new VideoFactory(product);
                    break;
            }
            return paymentFactory;
        }
    }
}
