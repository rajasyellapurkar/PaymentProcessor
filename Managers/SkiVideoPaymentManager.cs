using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Managers
{
    public class SkiVideoPaymentManager: VideoPaymentManager
    {
        protected override void GenerateVideoPackageSlip()
        {
            base.GenerateVideoPackageSlip();
            Console.WriteLine("Add Free First Aid video");
        }
    }
}
