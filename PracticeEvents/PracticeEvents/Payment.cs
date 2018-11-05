using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeEvents
{
    class Payment
    {
        public event EventHandler<CreditCardEventArgs> ButtonIsCliked;

        public void ButtonClick(CreditCard card)
        {
            Console.WriteLine("payment button is Cliked");
            Thread.Sleep(3000);
            OnButtonClick(card);
        }

        protected virtual void OnButtonClick(CreditCard card)
        {
            ButtonIsCliked?.Invoke(this, new CreditCardEventArgs() {Card = card});

        }
    }
}
