using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProfessionalLesson13Task2
{
    internal class Program
    {
        static Func<string, string> func;
        static void Main(string[] args)
        {
            func = StringHandler;
            while (true)
            {
                Console.WriteLine("\nInput smth.");
                string str = Console.ReadLine();
                func.BeginInvoke(str, Callback, func);
                Waiting();
            }
        }

        static string StringHandler(string str)
        {
            Thread.Sleep(3000);
            return $"\nWas inputed '{str}' string.";
        }

        static void Callback(IAsyncResult asyncResult)
        {
            string s = (asyncResult.AsyncState as Func<string, string>).EndInvoke(asyncResult);
            Console.WriteLine(s);
        }

        static void Waiting()
        {
            for (int i = 0; i < 28; i++)
            {
                Thread.Sleep(200);
                Console.Write(". ");
            }
        }

    }
}
