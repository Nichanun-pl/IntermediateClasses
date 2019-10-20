using System;

namespace Polymorphism
{
    public interface INotificationChannel
    {
        public class MailNotificationChannel : INotificationChannel
        {
            public void Send(Message message)
            {
                Console.WriteLine("Sending mail...");
            }
        }

        void Send(Message message);
    }
}
