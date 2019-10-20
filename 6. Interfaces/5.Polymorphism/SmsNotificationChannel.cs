using System;

namespace Polymorphism
{
    public class SmsNotificationChannel : INotficationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}
