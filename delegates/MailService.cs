using System;

namespace delegates
{
    public class MailService
    {
        // This is the EventHandler method implementation
        public void OnVideoEncodedMail(object source, VideoEventargs e)
        {
            
            Console.WriteLine($"MAilServices: Sending an email.....{e.Video.Title} has been encoded") ;
        }
    }
}
