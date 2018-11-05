using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEvents
{
    public class CreditCardEventArgs : EventArgs
    {
        public CreditCard Card { get; set; }
    }
}
