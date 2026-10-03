using System;

namespace abstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("copied to clipboard");
        }

        public void Select()
        {
            Console.WriteLine("selected");
        }
    }
}