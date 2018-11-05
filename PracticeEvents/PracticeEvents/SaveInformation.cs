using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEvents
{
    class SaveInformation
    {
        public void OnButtonClick(object source,CreditCardEventArgs e)
        {
            Console.WriteLine("Saving card info of {0}" ,e.Card.CardHolder);
        }
    }
}
