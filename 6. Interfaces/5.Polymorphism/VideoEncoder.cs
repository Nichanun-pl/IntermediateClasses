using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotficationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotficationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic
            //...

            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotficationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
