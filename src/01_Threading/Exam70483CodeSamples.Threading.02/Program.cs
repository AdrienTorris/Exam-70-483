namespace Exam70483CodeSamples.Threading._02
{
    using System;
    using System.Threading;

    /// <summary>
    /// Use a background thread
    /// </summary>
    /// <remarks>
    /// - With t.IsBackground = true => exists immediatly
    /// - With t.IsBackground = false => the ouput is kept alive while ThreadMethod method is executing
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
        }

        static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}