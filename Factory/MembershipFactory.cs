using PaymentProcessor.Interfaces;
using PaymentProcessor.Managers;
using PaymentProcessor.Model;
using PaymentProcessor.Utilities;

namespace PaymentProcessor.Factory
{
    public class MembershipFactory : BasePaymentFactory
    {
        public IEmailUtility emailUtility;

        public MembershipFactory(Product product, IEmailUtility emailUtility) : base(product)
        {
            this.emailUtility = emailUtility;
        }

        public override IPaymentManager Create()
        {
            IPaymentManager paymentManager = null;
            switch (product.ProductSubType)
            {
                case "SilverMember":
                    paymentManager = new SilverMemberPaymentManager(emailUtility);
                    break;
                default:
                    paymentManager = new BasicMemberPaymentManager(emailUtility);
                    break;
            }
            return paymentManager;
        }
    }
}
