using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Unjaded.Core.MVC;
using Unjaded.MVC.Core;
using Veracakes.Data;


namespace Veracakes.MVC.Web.Controllers
{
    public class OrderController : Controller
    {
        
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Email if you have questions.";

            return View();
        }

        /// <summary>
        /// ASYNCRHONUS TASK BRO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: put these into configuration file
                string strToEmail = "veracakesEmail@gmail.com";
                string strUserName = "";
                string strPassword = "";

                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.EmailAddress));  // replace with valid value 
                message.From = new MailAddress(strToEmail);  // replace with valid value
                message.Subject = "New Cake Contact";
                message.Body = string.Format(body, strToEmail, model.EmailAddress, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "veracakesEmail@gmail.com",  // replace with valid value
                        Password = "veracakes"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View();
        }

        private void SendContactEmail(ContactViewModel model)
        {

        }
    }
}