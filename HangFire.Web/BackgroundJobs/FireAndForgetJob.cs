using HangFire.Web.Services;

namespace HangFire.Web.BackgroundJobs
{
    public class FireAndForgetJob
    {
        public static void EmailSendToUserJob(string userId,string message)
        {
            Hangfire.BackgroundJob.Enqueue<IEmailSender>(x=>x.Sender(userId,message));
        }
    }
}
