using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TLOSolution.MailService
{
    public interface IEmailSender
    {
        public void SendEmail(EmailMessage message);
        public Task SendEmailAsync(EmailMessage message);
    }
}
