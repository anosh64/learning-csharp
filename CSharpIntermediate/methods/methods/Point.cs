using System;

namespace methods
{
    public class Point
    {
        public int X; 
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newlocation)
        {
            if (newlocation == null)
            {
                throw new ArgumentNullException("newLocation", "x and y cannot be null");
            }
            Move(newlocation.X, newlocation.Y);
        }
    }
}
