using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            //This line initializes the list of windows
            //Feel free to change the values passed to the WindowGenerator function
            List<Window> windows = WindowGenerator(15,10000);

            List<Window> lonelywindows = new List<Window>();
            //Your code here:


            windows.Sort((Window W1, Window W2) =>
            {
                if (W1.X / W2.X == 1.5 && W1.Y / W2.Y <= 1.5) { return 1; }
                else if (W1.X / W2.X == 1.5 && W1.Y / W2.Y > 1.5)
                {
                    lonelywindows.Add(W2);
                    return -1; 
                }
                else { return 0; }
            });


            //1.
            foreach (var window in lonelywindows)
            {
                Console.WriteLine(window.ToString());
            }
            //2. goes over all the list, prints similar windows one after the other 
            foreach (var window in windows)
            {
                Console.WriteLine(window.ToString());
            }

            //3 + 4 
            //logically, theres a possibility that A and B windows are similar, but the diffrence between A and D values for example
            //are bigger than 1.5


            //5. Bonus Question 
            // Revit API Docs, YouTube, Revit itself 

        }

        /// <summary>
        /// This method creates a list of windows by maximum size and number of windows
        /// </summary>
        /// <param name="maxWindowSize">The maximum X or Y size of the window</param>
        /// <param name="numberOfWindows">The number of windows to generate</param>
        /// <returns></returns>
        public static List<Window> WindowGenerator(int maxWindowSize, int numberOfWindows)
        {
            List<Window> Windows = new List<Window>();

            Random rand = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < numberOfWindows; i++)
            {
                var x = rand.NextDouble() * (maxWindowSize - 1) + 1;
                var y = rand.NextDouble() * (maxWindowSize- 1) + 1;
                Windows.Add(new Window(x, y));
            }

            return Windows;
        }

    }
}
