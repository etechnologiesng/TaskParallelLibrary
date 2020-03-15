using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list of states in Nigeria
            List<string> NigeriaStates = new List<string>();
            NigeriaStates.Add("Abia");
            NigeriaStates.Add("Adamawa");
            NigeriaStates.Add("Akwaibom");
            NigeriaStates.Add("Anambra");
            NigeriaStates.Add("Bauchi");
            NigeriaStates.Add("Bayelsa");
            NigeriaStates.Add("Benue");
            NigeriaStates.Add("Borno");
            NigeriaStates.Add("Crossriver");
            NigeriaStates.Add("Delta");
            NigeriaStates.Add("Eboyi");
            NigeriaStates.Add("Enugu");
            NigeriaStates.Add("Edo");
            NigeriaStates.Add("Ekiti");
            NigeriaStates.Add("Gobe ");
            NigeriaStates.Add("Imo");
            NigeriaStates.Add("Jigawa");
            NigeriaStates.Add("Kaduna");
            NigeriaStates.Add("Kano");
            NigeriaStates.Add("Kastina");
            //you can add the rest of the state

            Console.WriteLine("Printing list using foreach loop\n");

            var stopWatch = Stopwatch.StartNew();
            foreach (string state in NigeriaStates)
            {
                //This is for the Main thread for a sigle thread process...
                Console.WriteLine("State: {0}, Thread Id= {1}", state, Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("foreach loop execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);


            Console.WriteLine("Printing list using Parallel.ForEach");


            stopWatch = Stopwatch.StartNew();
            //using for each to print NigeriaStates.. This creates a muliple thread
            Parallel.ForEach(NigeriaStates, state =>
            {
                Console.WriteLine("State: {0}, Thread Id= {1}", state, Thread.CurrentThread.ManagedThreadId);

            }
            );
            //jjlllkk
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", stopWatch.Elapsed.TotalSeconds);
            Console.Read();
            //Note: You can see that if you are doing any bulk task inside the foreach loop
            //then parallel.foreach is very fast so you can go for parallel.foreach.
            //But if you just iterating and doing a very little task inside loop then go for traditional for loop. 


        }
    }
}