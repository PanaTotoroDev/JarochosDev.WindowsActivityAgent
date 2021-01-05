using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JarochosDev.WindowsActivityAgent
{
    class Program
    {
        //This is a example of how to get my username with a c# code 
        static void Main(string[] args)
        {
            Console.WriteLine();
            //  <-- Keep this information secure! -->
            Console.WriteLine("UserName: {0}", Environment.UserName);
            Console.ReadLine();
        }
    }
}
