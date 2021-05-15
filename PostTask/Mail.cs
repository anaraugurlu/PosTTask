using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNamespace
{
    class Mail
    {
       public static void Email(string text)
        {
            var client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("naranana123gt@gmail.com", "123134234")

            };
            client.Send("naranana123gt@gmail.com", "naranana123gt@gmail.com", "anara", text);
        }
    }
}
