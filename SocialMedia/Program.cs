using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("OMEGALUL", true, "AlexBig");
            ImagePost imagepost1 = new ImagePost("ZULUL", true, "AlexBig", "urldotnew");
            VideoPost videopost1 = new VideoPost("VI VON", true, "AlexBig", "https://www.youtube.com/watch?v=5R91Fj25FxM", 10);
            
            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagepost1.ToString());
            Console.WriteLine("Inserte la palabra 'play' para comenzar el video.");
            if (Console.ReadLine().Equals("play"))
                videopost1.Play();
            Console.Read();
        }
    }
}
