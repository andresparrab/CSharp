using System;

namespace delegates
{
    public class SMSService
    {
        // This is the EventHandler method implementation
        // the signature should be as declared on the delegate as follow:
        // public void "some name" (object "somename, Eventargs "somename"
        public void OnVideoEncodedSMS(object objSource, EventArgs ev) // the method name and vars are not good on purpose, just to show can be anything as long it follow the the delegate definition
        {
            Console.WriteLine("SMS: Sending an sms.....");
        }
    }
}
