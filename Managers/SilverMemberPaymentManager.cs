using PaymentProcessor.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Managers
{
    public class SilverMemberPaymentManager:BasicMemberPaymentManager
    {
        public SilverMemberPaymentManager(IEmailUtility emailUtility):base(emailUtility)
        {
        }

        public override void ProcessPayement()
        {
            // If not an exisitng member and opted directly for Silver
            // First activate the basic membership
            ActivateMembership();

            // Upgrade to Silver Member
            UpgradeToSilver();

            // Send Email
            SendEmail("Silver Membership activated");
        }

        public virtual void UpgradeToSilver()
        {
            Console.WriteLine("Upgrade the membership to Silver");
        }
    }
}
