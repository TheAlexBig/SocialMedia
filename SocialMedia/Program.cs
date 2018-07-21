using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("OMEGALUL", true, "AlexBig");
            ImagePost imagepost1 = new ImagePost("ZULUL", true, "AlexBig", "urldotnew");
            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagepost1.ToString());
            Console.Read();
        }
    }
}
