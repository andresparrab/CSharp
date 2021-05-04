namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Batman Returns, Again 2021" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService();  // subscriber
            var smsService = new SMSService(); // another publisher
            var pageService = new PagerService(); // another publisher based on Interface

            // before we call the encode method we need to do the subscribtion, to add a pointer to the Videoencoded "list"
            videoEncoder.VideoEncoded += mailService.OnVideoEncodedMail;  //mailService.OnVideoEncodedMail; is a reference(pointer) to that method NOT A METHOD CALL
            videoEncoder.VideoEncoded += smsService.OnVideoEncodedSMS;   // register another subscriber
            videoEncoder.VideoEncoded += pageService.OnVideoEncodedPager;
            videoEncoder.Encode(video);
        }
    }
}
