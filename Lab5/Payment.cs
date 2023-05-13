using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5DotNet
{
    public class Payment
    {
        public string Type;
        public float Amount;

        public Payment(string type, float amount)
        {
            Type = type;
            Amount = amount;
        }
    }

    public class PaymentHandler
    {
        private Operation _fixationOperation = new FixationOperation();
        private Operation _controllingOperation = new ControllingOperation();
        private Operation _chargeOperation = new ChargeOperation();
        private Operation _transferOperation = new TransferOperation();
        public PaymentHandler()
        {
            _fixationOperation.SetNext(_controllingOperation);
            _controllingOperation.SetNext(_chargeOperation);
            _chargeOperation.SetNext(_transferOperation);
        }

        public void Handle(Payment payment)
        {
            _fixationOperation.ProcessPayment(payment);
        }
    }
}
