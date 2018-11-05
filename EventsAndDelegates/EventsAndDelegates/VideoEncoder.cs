using System;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        //1- Define a delegate
        //2- Define an Event based on that delegate
        //3- raise/invoke the event

        /*public delegate void VideoEncoderEventHandler(object source, EventArgs args);*/// susbcriber classes will have methods that confirms with this signature

        /*public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);*/ // Instead of EventArgs, we use custom class

        //with .net we have EventHandler to act like delegate instead of creating our own delegate everytime 


        //public event VideoEncoderEventHandler VideoEncoded; // when creating own delegate

        /*public event EventHandler VideoEncoded;*/ // if publishing without additional information = (object source, EventArgs args)

        public event EventHandler<VideoEventArgs> VideoEncoded; // if we want to information from a custom class = (object source, VideoEventArgs args)

        public void Encode(Video video)
        {
            Console.WriteLine("encoding video");
            Thread.Sleep(3000);
            OnVideoEncoded(video); //Once the video encoding is finished, this method will notify all the subscribers
        }                          // raising the event here

        protected virtual void OnVideoEncoded(Video video)// this method invoke the event
        {
            //if (VideoEncoded != null)  // check to see if there are any subscribers to this event(VideoEncoded)
            //    VideoEncoded(this,EventArgs.Empty); // if not null than call event

            //VideoEncoded?.Invoke(this, EventArgs.Empty); 
            // videoEncoded behind the scnene is a list of pointers to diff methods

            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video }); // reference to the video
        }
    }
}
