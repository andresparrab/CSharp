using System;
using System.Threading;

namespace delegates
{
    public class IVideoEventargs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEventargs: EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder: IVideoEncoded 
    {
        public event EventHandler<VideoEventargs> VideoEncoded;

        public void Encode(Video video)
        {

            Console.WriteLine($"Encoding Video with title: {video.Title}.....");
            Thread.Sleep(3000);
            //3. Raising of the method fom the publisher OnVideoEncoded();
            // Calling the method that will notify all the subscribers
            OnVideoEncoded(video);
           

        }
        
        // the convention is that the event PUBLISHER should be protected, virtual and void and start with the word "On"
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded !=null)  // if there are any subscribers it should not be empty(null) Remember VideoEncoded is a list with pointers
            {
                // whats is the source of the event? or who is publishing the event?
                // the current class, so we write "this" as the source
                VideoEncoded(this, new VideoEventargs() { Video = video});
            }
           
        }

    }
}
