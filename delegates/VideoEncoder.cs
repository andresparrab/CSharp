using System;
using System.Threading;

namespace delegates
{
    public class VideoEncoder
    {
        //1. first define the delegate
        //2. Define the event based on the delegate
        //3. Raise or publis the event

        //1. The delegate - is just a reference to the method that will be implemented in the subscriber
        // it defines the "shape" or "signature" of the method on the subsscriber
        public delegate void VideoEncoderEventhandler(object source, EventArgs args);

        // 2. Defining the event base on the delegate
        public event VideoEncoderEventhandler VideoEncoded; // this behind the scenes is a list wit pointer to methods that have the shape of the delegate

        public void Encode(Video video)
        {

            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);
            //3. Raising of the method fom the publisher OnVideoEncoded();
            // Calling the method that will notify all the subscribers
            OnVideoEncoded();
           

        }
        
        // the convention is that the event PUBLISHER should be protected, virtual and void and start with the word "On"
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded !=null)  // if there are any subscribers it should not be empty(null) Remember VideoEncoded is a list with pointers
            {
                // whats is the source of the event? or who is publishing the event?
                // the current class, so we write "this" as the source
                VideoEncoded(this, EventArgs.Empty);
            }
           
        }

    }
}
