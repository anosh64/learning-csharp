using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var calculator = new Calculator();
            // var somethingThatWillCauseAnException = calculator.Divide(5, 0);
            // so that's going to throw an exception, System.DivideByZeroException
            // let's put it in a try catch then

            try
            {
                var calculator = new Calculator();
                var somethingThatWillCauseAnException = calculator.Divide(5, 0);
            } // we ca actually have multiple catches, we must order from most specific to most generic
            catch (DivideByZeroException e)
            {
                Console.WriteLine("you can't divide by zero! here's the error if you're a nerd: \n" + e);
            }
            catch (ArithmeticException e) // parent of dividebyzeroexception
            {
                Console.WriteLine("sorry! something seems to have gone wrong. error: \n" + e);
            }
            catch (Exception e) // parent of all exceptions
            {
                Console.WriteLine("sorry! something seems to have gone wrong! error: \n" + e);
            }

            // and there's also a finally thing after catch for classes that use unmanaged resources such
            // as streamReader, clr garbage disposal doesn't work on them and we need to manually dispose

            var streamreader = new StreamReader(@"c:\folder\otherfolder\okyoucanstopnow\no\brocomeon\haha.txt");
            try
            {
                var content = streamreader.ReadToEnd();
                throw new WaitHandleCannotBeOpenedException("idk what this exception does but its name is long");
            }
            catch (Exception e)
            {
                Console.WriteLine("wow something went wrong, as always... here's the error: " + e);
            }
            finally
            {
                streamreader.Dispose(); // we don't want the stream to stay open because it'll keep on //
            }                          // using resources which is a big, fat, insanely massive no-no //
        }
    }
}
