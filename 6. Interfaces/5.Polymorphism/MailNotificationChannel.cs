using System;

namespace Polymorphism
{
    public class MailNotificationChannel : INotficationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}
