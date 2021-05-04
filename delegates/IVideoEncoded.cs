using System;

namespace delegates
{
    public interface IVideoEncoded
    {
        event EventHandler<VideoEventargs> VideoEncoded;
    }
}
