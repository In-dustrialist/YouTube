using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    // Интерфейс для команд
    interface ICommand
    {
        Task ExecuteAsync();
    }
}