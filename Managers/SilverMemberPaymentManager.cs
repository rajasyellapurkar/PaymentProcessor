using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Managers
{
    public class SilverMemberPaymentManager:BasicMemberPaymentManager
    {
        public override void ProcessPayement()
        {
            // If not an exisitng member and opted directly for Silver
            // First activate the basic membership
            ActivateMembership();

            // Upgrade to Silver Member
            UpgradeToSilver();
        }

        public virtual void UpgradeToSilver()
        {
            Console.WriteLine("Upgrade the membership to Silver");
        }
    }
}
