using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
   public class VideoEventArgs :EventArgs // class that contains the data about the video thats was encoded
    {
        public Video Video { get; set; } // property that determines video that was encoded
    }
}
