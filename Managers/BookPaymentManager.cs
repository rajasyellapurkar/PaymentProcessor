using PaymentProcessor.Interfaces;
using System;

namespace PaymentProcessor.Managers
{
    public class BookPaymentManager : PhysicalProductPaymentMgr
    {
        public override void ProcessPayement()
        {
            GeneratePackageSlip();
            GenerateDuplicatePackageSlip();
            GenerateCommision();
        }

        protected void GenerateDuplicatePackageSlip()
        {
            Console.WriteLine("Generated Duplicate Package Slip for Book");
        }
    }
}