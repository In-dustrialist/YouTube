using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    // Команда для получения информации о видео
    class GetVideoInfoCommand : ICommand
    {
        private readonly string _videoUrl;

        public GetVideoInfoCommand(string videoUrl)
        {
            _videoUrl = videoUrl;
        }

        public async Task ExecuteAsync()
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(_videoUrl);
            Console.WriteLine($"Video Title: {video.Title}");
            Console.WriteLine($"Video Description: {video.Description}");
        }
    }
}
