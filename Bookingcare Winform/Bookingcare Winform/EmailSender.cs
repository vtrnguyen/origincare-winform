using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bookingcare_Winform
{
    internal class EmailSender
    {
        private string emailSender = "votrungnguyenlop1a@gmail.com";
        private string appPassword = "gfbvafsobzwmahtm";

        public bool sendEmail(string patientEmail, string patientName, DateTime bookingDate, string bookingTime, string clinicName)
        {
            try
            {
                string subject = "Thông Báo Đặt Lịch Khám Bệnh Thành Công";
                string body = $"Chào {patientName},\n\n" +
                              $"Email này nhằm thông báo rằng bạn đã đặt lịch khám thành công vào ngày {bookingDate:dd/MM/yyyy} lúc {bookingTime}.\n\n" +
                              "Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.\n" +
                              "Trân trọng,\n" +
                              $"{clinicName}";

                // SMTP configuration
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // or 465 if use SSL
                    Credentials = new NetworkCredential(this.emailSender, this.appPassword),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(this.emailSender),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false, // change to true if sending email HTML
                };
                mailMessage.To.Add(patientEmail);

                smtpClient.Send(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);

                return false;
            }
        }
    }
}
