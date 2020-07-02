using PaymentProcessor.Interfaces;
using PaymentProcessor.Managers;
using PaymentProcessor.Model;

namespace PaymentProcessor.Factory
{
    public class MembershipFactory : BasePaymentFactory
    {
        public MembershipFactory(Product product) : base(product)
        {
        }

        public override IPaymentManager Create()
        {
            IPaymentManager paymentManager = null;
            switch (product.ProductSubType)
            {
                case "SilverMember":
                    paymentManager = new SilverMemberPaymentManager();
                    break;
                default:
                    paymentManager = new BasicMemberPaymentManager();
                    break;
            }
            return paymentManager;
        }
    }
}
