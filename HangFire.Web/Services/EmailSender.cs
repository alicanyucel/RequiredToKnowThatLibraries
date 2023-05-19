namespace HangFire.Web.Services
{
    public class EmailSender : IEmailSender
    {
        public string Sender(string userId, string message)
        {
           return "Hoşgeldiniz";
        }
    }
}
