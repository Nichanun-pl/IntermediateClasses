namespace Polymorphism
{
    public interface INotficationChannel
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
