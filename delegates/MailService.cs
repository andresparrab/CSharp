using System;

namespace delegates
{
    public class MailService
    {
        // This is the EventHandler method implementation
        public void OnVideoEncodedMail(object source, EventArgs e)
        {
            Console.WriteLine("MAilServices: Sending an email.....");
        }
    }
}
