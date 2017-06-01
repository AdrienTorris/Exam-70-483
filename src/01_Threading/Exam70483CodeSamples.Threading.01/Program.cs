namespace Exam70483CodeSamples.Threading._01
{
    using System;
    using System.Threading;

    /// <summary>
    /// Using a simple thread
    /// </summary>
    /// <remarks>
    /// - Thread.Sleep(0) => 
    /// - t.Join() => To wait the thread finishes his job.
    /// </remarks>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading(v=vs.110).aspx"/>
    /// <seealso cref="https://msdn.microsoft.com/en-us/library/a9fyxz7d(v=vs.110).aspx"/>
    /// <seealso cref="https://msdn.microsoft.com/en-us/library/aa645740(v=vs.71).aspx"/>
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