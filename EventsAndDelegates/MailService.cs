using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source,EventArgs e)
        {
            Console.WriteLine("Mail service: sending an email...");
        }
    }
}