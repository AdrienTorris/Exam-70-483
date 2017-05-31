namespace Exam70483CodeSamples.Threading._03
{
    using System;
    using System.Threading;

    /// <summary>
    /// Using the ParameterizedThreadStart
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(7);
            t.Join();
        }

        static void ThreadMethod(object o)
        {
            for(int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProx: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}