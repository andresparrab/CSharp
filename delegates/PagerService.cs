using System;

namespace delegates
{
    public class PagerService
    {
        //public event EventHandler VideoEncoded2;

        // This is the EventHandler method implementation
        // the signature should be as declared on the delegate as follow:
        // public void "some name" (object "somename, Eventargs "somename"
        public void OnVideoEncodedPager(object objSource, VideoEventargs ev) // the method name and vars are not good on purpose, just to show can be anything as long it follow the the delegate definition
        {
            Console.WriteLine($"PAGER: Sending an PAGE!!!.....{ev.Video.Title} has been encoded");
        }
    }
}
