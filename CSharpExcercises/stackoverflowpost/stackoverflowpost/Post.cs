using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace stackoverflowpost
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        public DateTime DateCreated { get; private set; }

        //public int UpVotes { get; private set; }

        //public int DownVotes { get; private set; }

        private bool _alreadyVoted = false;

        private int _voteCount { get; set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            DateCreated = DateTime.Now;
            _voteCount = 0;
        }

        public void Upvote()
        {
            _voteCount++;
        }

        public void Downvote()
        {
            _voteCount--;
        }

        public void GetVoteCount()
        {
            Console.Write("\rvotes: " + _voteCount);
        }

        public void Display()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine("Date Created: " + DateCreated);
            Console.WriteLine();
            Console.WriteLine("press u to upvote, d to downvote.");
            while (!_alreadyVoted)
            {
                GetVoteCount();
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.U)
                {
                    Upvote();
                    _alreadyVoted = true;
                }
                else if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D)
                {
                    Downvote();
                    _alreadyVoted = true;
                }

                Thread.Sleep(100);
            }
            

        }



    }

}