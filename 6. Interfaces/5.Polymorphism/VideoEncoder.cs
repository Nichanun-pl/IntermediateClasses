using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly MailService mailService;

        public VideoEncoder()
        {
            _mailService = new MailService();
        }

        public void Encode(Video video)
        {
            //Video encoding logic
            //...

            _mailService.Send(new Mail());
        }
    }
}
