using PaymentProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Managers
{
    public class BasicMemberPaymentManager : IPaymentManager
    {
        public virtual void ProcessPayement()
        {
            ActivateMembership();
        }

        protected void ActivateMembership()
        {
            // if not a member activate basic membership
            Console.WriteLine("Basic memebership updated");
        }
    }
}
