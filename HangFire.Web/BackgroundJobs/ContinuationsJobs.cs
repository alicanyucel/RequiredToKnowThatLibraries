using System.Diagnostics;

namespace HangFire.Web.BackgroundJobs
{
    public class ContinuationsJobs
    {

        public static void WriteWaterMarkStatusJob(string id, string fileName)
        {
            Hangfire.BackgroundJob.ContinueJobWith(id, () => Debug.WriteLine($"{fileName} : resim'e watermark eklenmiştir."));
        }
        

    }
}
