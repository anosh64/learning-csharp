using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassesAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();

            //var shape = new Shape(); // uncomment this and it won't work. why?
            //                        // because shape is abstract
        }
    }
}
