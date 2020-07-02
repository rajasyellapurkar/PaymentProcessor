using PaymentProcessor.Interfaces;
using System;

namespace PaymentProcessor.Managers
{
    public class PhysicalProductPaymentMgr : IPaymentManager
    {
        public virtual void ProcessPayement()
        {
            GeneratePackageSlip();
        }

        protected void GeneratePackageSlip()
        {
            Console.WriteLine("Package Slip generated");
        }

        protected void GenerateCommision()
        {
            Console.WriteLine("Commission payment generated");
        }
    }
}
