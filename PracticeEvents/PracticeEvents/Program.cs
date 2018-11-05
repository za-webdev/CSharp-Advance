using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCard = new CreditCard() { AccNumber = 123456, CardHolder = "John" };
            var payment = new Payment();
            var charge = new Charge();
            var save = new SaveInformation();
            payment.ButtonIsCliked += charge.OnButtonClick;
            payment.ButtonIsCliked += save.OnButtonClick;

            payment.ButtonClick(creditCard);
        }
    }
}
