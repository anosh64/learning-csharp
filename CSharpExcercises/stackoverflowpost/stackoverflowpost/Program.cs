using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflowpost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("guys help my c# became x\u266d", "@\"so basically my c# got flat and x. i don't even know why this occured.\r\n\r\nif somebody here know why, please, please provide an answer. i'll even buy you a bored ape nft. please");
            post.Display();
        }
    }
}
