namespace Exam70483CodeSamples.Threading._02
{
    using System;
    using System.Threading;

    /// <summary>
    /// Using a background thread
    /// </summary>
    /// <remarks>
    /// - With t.IsBackground = true => exits immediatly
    /// - With t.IsBackground = false => the ouput is kept alive while ThreadMethod method is executing
    /// </remarks>
    /// <see cref="https://msdn.microsoft.com/en-us/library/h339syd0(v=vs.110).aspx"/>
    /// <seealso cref="https://msdn.microsoft.com/en-us/library/system.threading.thread.isbackground(v=vs.110).aspx"/>
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