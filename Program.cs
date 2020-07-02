using PaymentProcessor.Factory;
using PaymentProcessor.Managers;
using PaymentProcessor.Model;
using PaymentProcessor.Utilities;
using System;

namespace PaymentProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payment Proccessor Engine");

            Product product = new Product
            {
                ProductId = 1,
                ProductType = "Membership",
                ProductSubType = "SilverMember"
            };

            /*
            Product product = new Product
            {
                ProductId = 1,
                ProductType = "PhysicalProduct"
            };

            Product product = new Product
            {
                ProductId = 1,
                ProductType = "Video",
                ProductSubType = "Learning to Ski"
            };
            */

            IEmailUtility emailUtility = new EmailUtility();

            PaymentManagerFactory paymentManagerFactory = new PaymentManagerFactory();
            BasePaymentFactory paymentFactory = paymentManagerFactory.CreateFactory(product, emailUtility);

            paymentFactory.ProcessPayment();

            Console.ReadLine();
        }
    }
}
