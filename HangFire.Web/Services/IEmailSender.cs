namespace HangFire.Web.Services
{
    public interface IEmailSender
    {
        string Sender(string userId, string message);
    }
}
