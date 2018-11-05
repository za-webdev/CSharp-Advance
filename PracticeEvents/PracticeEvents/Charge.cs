using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEvents
{
   public class Charge
    {
        public void OnButtonClick(object source, CreditCardEventArgs e)
        {
            Console.WriteLine("Charging Card for payment for acc number {0}", e.Card.AccNumber);
        }
    }
}
