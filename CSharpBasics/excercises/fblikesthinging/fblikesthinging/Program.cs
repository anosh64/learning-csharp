using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fblikesthinging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;

            var friends = new List<string>();

            while (!finished) {
                Console.WriteLine("enter friend's name. if you have no more, press enter without typing anything");
                string friendName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(friendName))
                {
                    finished = true;
                }
                else
                {
                    friends.Add(friendName);
                }
            }

            int howManyFriends = friends.Count;

            if (howManyFriends < 1)
            {
                Console.WriteLine();
            }
            else if (howManyFriends == 1)
            {
                Console.WriteLine(friends[0] + " liked your post");
            }
            else if (howManyFriends == 2)
            {
                Console.WriteLine(string.Format("{0} and {1} liked your post", friends[0], friends[1]));
            }
            else if (howManyFriends > 2) { 
                var otherFriends = howManyFriends - 2;
                var peopleorperson = "person";
                if (otherFriends == 1)
                {
                    peopleorperson = "person";
                }
                else
                {
                    peopleorperson = "people";
                }


                Console.WriteLine(string.Format("{0}, {1}, and {2} other {3} liked your post", friends[0], friends[1], otherFriends, peopleorperson));

            }

        }
    }
}
