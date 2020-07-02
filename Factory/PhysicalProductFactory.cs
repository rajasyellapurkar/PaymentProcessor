using PaymentProcessor.Interfaces;
using PaymentProcessor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Factory
{
    public class PhysicalProductFactory : BasePaymentFactory
    {
        public PhysicalProductFactory(Product product):base(product)
        {
        }

        public override IPaymentManager Create()
        {
            IPaymentManager paymentManager = null;
            switch(product.ProductSubType)
            {
                case "Book": paymentManager = new BookPaymentManager();
                    break;
                default: paymentManager = new PhysicalProductPaymentMgr();
                    break;
            }
            return paymentManager;
        }
    }
}
