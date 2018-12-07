using _3WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace _3WEB.Servicos
{
    public class ServicoEmail
    {
        public static async Task EnviarEmailDuplo(Model_Mail email)
        {
            var tst = WebConfigurationManager.AppSettings["userName"];

            var body1 = "<p>Sua mensagem foi recebida pela nossa equipe, em breve entraremos em contato.<br><br>Obrigado.</p>";

            var body2 = "<p>Recebemos um contato de: {0}</p>" +
                "<p>Empresa/Assunto: {1}" +
                "<p>Mensagem:</p><p>{2}</p>";

            var mensagem1 = new MailMessage();
            var mensagem2 = new MailMessage();

            //envia primeiro para o cliente
            mensagem1.To.Add(new MailAddress(email.Para));
            mensagem1.Subject = "3WEB Contato";
            mensagem1.Body = string.Format(body1);
            mensagem1.From = new MailAddress("contato@3web.com.br");
            mensagem1.IsBodyHtml = true;

            //agora envia copia pra mim
            mensagem2.To.Add(new MailAddress("contato@3web.com.br"));
            mensagem2.Subject = "Contato pelo site!";
            mensagem2.Body = string.Format(body2, email.Para, email.Assunto, email.Mensagem);
            mensagem2.From = new MailAddress("contato@3web.com.br");
            mensagem2.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = WebConfigurationManager.AppSettings["userName"],
                    Password = WebConfigurationManager.AppSettings["password"]
                };

                smtp.Credentials = credential;
                smtp.Host = WebConfigurationManager.AppSettings["host"];
                smtp.Port = int.Parse(WebConfigurationManager.AppSettings["port"]);
                smtp.EnableSsl = bool.Parse(WebConfigurationManager.AppSettings["enableSsl"]);

                await smtp.SendMailAsync(mensagem1);
                await smtp.SendMailAsync(mensagem2);
            }
        }
    }
}