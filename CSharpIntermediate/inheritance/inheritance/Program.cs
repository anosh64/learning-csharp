using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
        {
            static void Main(string[] args)
            {
                var text = new Text();
                text.Width = 100;
                text.Copy(); // this method is not seen in text.cs but is inherited from PresentationObject.cs
            }
        }
    }
