namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 2" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // pointer to mail service
            videoEncoder.VideoEncoded += messageService.OnMessageService;

            videoEncoder.Encode(video);
        }
    }
}
