using System;
using System.Threading;

namespace Events
{
    internal class Program
    {
        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }
        }

        public class Video
        {
            public string Title { get; set; }
        }

        public class VideoEncoder
        {
            // define a delegate
            // define an event based on that delegate
            // raise the event

            // public delegate void VideoEncodedEventHandler(object obj, VideoEventArgs args);

            //public event VideoEncodedEventHandler VideoEncoded;

            public event EventHandler<VideoEventArgs> VideoEncoded;

            public void Encode(Video video)
            {
                Console.WriteLine("Encoding...");
                Thread.Sleep(3000);

                OnVideoEncoded(video);
            }

            protected virtual void OnVideoEncoded(Video video)
            {
                if (VideoEncoded != null)
                    VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }

        private static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }

        public class MailService
        {
            public void OnVideoEncoded(object obj, VideoEventArgs args)
            {
                Console.WriteLine("Mail Service...", args.Video.Title);
            }
        }
    }
}