using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
   public class MailService // this is our subscriber class
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) // event handler method
        {
            Console.WriteLine("Sending email {0}",e.Video.Title);
        }
    }
}
