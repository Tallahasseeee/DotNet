using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5DotNet
{
    public abstract class Operation
    {
        protected Operation _nextOperation;

        public void SetNext(Operation operation)
        {
            _nextOperation = operation;
        }

        public abstract void ProcessPayment(Payment payment);
    }

    public class FixationOperation : Operation
    {
        public override void ProcessPayment(Payment payment)
        {
            Console.WriteLine($"\nFixing {payment.Type} payment");

            _nextOperation.ProcessPayment(payment);

        }
    }

    public class ControllingOperation : Operation
    {
        public override void ProcessPayment(Payment payment)
        {
            if(payment.Type == "government" || payment.Type == "intrabank")
            {
                Console.WriteLine("Government and IntraBank transactions are not subject to control");
                _nextOperation.ProcessPayment(payment);
            }
            else
            {
                if(payment.Amount  > 100000)
                {
                    Console.WriteLine("The transaction limit has been exceeded!");
                }
                else
                {
                    Console.WriteLine("The transaction has passed control");
                    _nextOperation.ProcessPayment(payment);
                }
            }
            
        }
    }

    public class ChargeOperation : Operation
    {
        public override void ProcessPayment(Payment payment)
        {
            if (payment.Type == "government" || payment.Type == "intrabank")
            {
                Console.WriteLine("No fees are charged for government and IntraBank transactions");
                _nextOperation.ProcessPayment(payment);
            }
            else if(payment.Type == "preferential")
            {               
                payment.Amount *= 0.99f;
                Console.WriteLine("1% fee is charged from Preferential transaction");
                _nextOperation.ProcessPayment(payment);
            }
            else
            {
                payment.Amount *= 0.95f;
                Console.WriteLine("5% fee is charged from Regular transaction");
                _nextOperation.ProcessPayment(payment);
            }
        }
    }

    public class TransferOperation : Operation
    {
        public override void ProcessPayment(Payment payment)
        {
            Console.WriteLine("Transferring funds");
        }
    }
}
