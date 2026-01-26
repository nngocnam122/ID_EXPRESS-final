using Microsoft.AspNetCore.Mvc;
using Renew_IDLine.Models;
using System.Net;
using System.Net.Mail;

namespace Renew_IDLine.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> SendMail(ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new
                    {
                        field = x.Key,
                        error = x.Value.Errors.First().ErrorMessage
                    });

                return Json(new { success = false, message = "Dữ liệu không hợp lệ", errors });
            }

            try
            {
                var smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    Timeout = 10000,
                    Credentials = new NetworkCredential(
                        Environment.GetEnvironmentVariable("SMTP_USER") ?? "guihangquocteidexpress@gmail.com",
                        Environment.GetEnvironmentVariable("SMTP_PASS") ?? "rxix szzg pbaw ywty"
                    )
                };

                var from = Environment.GetEnvironmentVariable("SMTP_USER")
                           ?? "guihangquocteidexpress@gmail.com";

                var mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(from);
                mail.Subject = model.Subject;
                mail.Body = $@"
                    Họ & tên: {model.LastName} {model.FirstName}
                    Email: {model.Email}
                    Số điện thoại: {model.Phone}
                    Nội dung:
                    {model.Message}";

                await smtp.SendMailAsync(mail); // ✅ async

                return Json(new { success = true, message = "Gửi lời nhắn thành công!" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }

}
