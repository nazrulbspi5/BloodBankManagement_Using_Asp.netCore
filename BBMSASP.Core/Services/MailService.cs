using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Services
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;
        public MailService(IConfiguration configuration)
        {
            this._configuration = configuration;   
        }
        public async Task SendEmailAsync(string toEmail, string subject, string content)
        {
            var apiKey = _configuration["SendGridAPIKey"];
            var client = new SendGridClient(apiKey);
            var fromEmail = new EmailAddress("nazrul.bspi@hotmail.com", "CTG BLOOD BANK");
            var to_Email = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(fromEmail, to_Email, subject, content,content);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
