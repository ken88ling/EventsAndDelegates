using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        // using standard .net library
        // EventHandler
        // EventHandler<TEventArgs>

        //public event EventHandler VideoEncoded; //normal form if you didn't have pass object
        public event EventHandler<VideoEventArgs> VideoEncoded;
        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); //3. RTE => will inform all subscriber
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //if (VideoEncoded != null) same as this
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }

    }
}
