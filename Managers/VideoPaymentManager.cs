using PaymentProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Managers
{
    public class VideoPaymentManager : IPaymentManager
    {
        public virtual void ProcessPayement()
        {
            GenerateVideoPackageSlip();
        }

        protected virtual void GenerateVideoPackageSlip()
        {
            Console.WriteLine("Video Package Slip generated");
        }
    }
}
