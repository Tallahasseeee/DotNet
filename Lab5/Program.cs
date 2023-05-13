using System;

namespace Lab5DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentHandler paymentHandler = new PaymentHandler();
            paymentHandler.Handle(new Payment("regular", 10000));
            paymentHandler.Handle(new Payment("regular",150000));
            paymentHandler.Handle(new Payment("government", 150000));
            paymentHandler.Handle(new Payment("intrabank", 70000));
            paymentHandler.Handle(new Payment("preferential", 80000));
        }
    }
}
