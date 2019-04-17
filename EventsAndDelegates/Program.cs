using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // pointer to mailservice
            videoEncoder.VideoEncoded += messageService.OnMessageService;

            videoEncoder.Encode(video);
        }
    }

    public class MessageService
    {
        public void OnMessageService(object source, EventArgs args)
        {
            Console.WriteLine("Message service: Sending message....");
        }
    }

}
