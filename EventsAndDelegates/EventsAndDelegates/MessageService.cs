﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void OnVideoEncoded(object source,EventArgs e)
        {
            Console.WriteLine("Sending message");
        }
    }
}
