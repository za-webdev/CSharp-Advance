using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };

            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService();// subscriber
            var messageService = new MessageService();// subscriber



            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // registering a handler to the event(which is OnVideoEncoded (event handler) in mail service)
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // registering a handler to the event(which is OnVideoEncoded (event handler) in message service)
           
            videoEncoder.Encode(video);
        }
    }
}
