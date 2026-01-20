using Microsoft.AspNetCore.Mvc;
using Renew_IDLine.Models;
using System.Net;
using System.Net.Mail;

namespace Renew_IDLine.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult SendMail(ContactModel model)
        {
            try
            {
                var smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("guihangquocteidexpress@gmail.com", "rxix szzg pbaw ywty"),
                    EnableSsl = true,
                };

                var mail = new MailMessage();
                mail.From = new MailAddress("guihangquocteidexpress@gmail.com");
                mail.To.Add("guihangquocteidexpress@gmail.com");
                mail.Subject = model.Subject;
                mail.Body = $@"
                    Họ & tên: {model.LastName} {model.FirstName}
                    Email: {model.Email}
                    Số điện thoại: {model.Phone}
                    Nội dung:
                    {model.Message}";

                smtp.Send(mail);

                return Json(new { success = true, message = "Gửi lời nhắn thành công!" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
