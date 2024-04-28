using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string videoUrl;

            Console.WriteLine("Enter the URL of the YouTube video:");
            videoUrl = Console.ReadLine();

            ICommand getVideoInfoCommand = new GetVideoInfoCommand(videoUrl);
            ICommand downloadVideoCommand = new DownloadVideoCommand(videoUrl);

            Console.WriteLine("Video Information:");
            await getVideoInfoCommand.ExecuteAsync();

            Console.WriteLine("\nDownloading Video...");
            await downloadVideoCommand.ExecuteAsync();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
