using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingAsyncExceptions
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(
                $"{DateTime.Now:T} [{Thread.CurrentThread.ManagedThreadId:00}] {message}"
            );
        }
    }
}
