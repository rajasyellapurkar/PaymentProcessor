using PaymentProcessor.Interfaces;
using PaymentProcessor.Model;

namespace PaymentProcessor.Factory
{
    public abstract class BasePaymentFactory
    {
        protected Product product;

        public BasePaymentFactory(Product product)
        {
            this.product = product;
        }

        public abstract IPaymentManager Create();

        public void ProcessPayment()
        {
            IPaymentManager manager = this.Create();
            manager.ProcessPayement();
        }
    }
}
