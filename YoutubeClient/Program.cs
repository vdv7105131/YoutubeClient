using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            class1.Method1();
            class1.Method2();
        }
    }
    
    public class Class1
    {
        /// <summary>
        /// Получает описание видео
        /// </summary>
        public void Method1()
        {
            var youtube = new YoutubeClient();
            var video = youtube.Videos.GetAsync("https://youtube.com/watch?v=u_yIGGhubZs");
        }

        /// <summary>
        /// Запускает скачивание видео
        /// </summary>
        public async void Method2()
        {
            var youtube = new YoutubeClient();
            await youtube.Videos.DownloadAsync("https://youtube.com/watch?v=u_yIGGhubZs", "video.mp4");
        }
    }
}
