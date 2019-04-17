using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnMessageService(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Message service: Sending message....{e.Video.Title}");
        }
    }
}