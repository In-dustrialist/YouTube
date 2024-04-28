using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    // Команда для скачивания видео
    class DownloadVideoCommand : ICommand
    {
        private readonly string _videoUrl;

        public DownloadVideoCommand(string videoUrl)
        {
            _videoUrl = videoUrl;
        }

        public async Task ExecuteAsync()
        {
            var youtube = new YoutubeClient();
            var streamInfoSet = await youtube.Videos.Streams.GetManifestAsync(_videoUrl);
            var streamInfo = streamInfoSet.GetMuxedStreams().GetWithHighestVideoQuality();
            if (streamInfo != null)
            {
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.mp4");
                Console.WriteLine("Video downloaded successfully!");
            }
            else
            {
                Console.WriteLine("Video stream not found!");
            }
        }
    }
}
