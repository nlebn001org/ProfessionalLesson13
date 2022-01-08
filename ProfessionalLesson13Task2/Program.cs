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
            func.BeginInvoke("Line", Callback, func);
            Console.ReadKey();
        }

        static string StringHandler(string str)
        {
            return $"Was inputed '{str}' string.";
        }

        static void Callback(IAsyncResult asyncResult)
        {
            string s = (asyncResult.AsyncState as Func<string, string>).EndInvoke(asyncResult);
            Console.WriteLine(s);
        }

    }
}
