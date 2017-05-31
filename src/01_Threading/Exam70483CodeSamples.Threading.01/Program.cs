namespace Exam70483CodeSamples.Threading._01
{
    using System;
    using System.Threading;

    /// <summary>
    /// Use a thread
    /// </summary>
    /// <remarks>
    /// - Thread.Sleep(0) =>
    /// - t.Join() =>
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();
        }

        static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}