namespace Exam70483CodeSamples.Threading._04
{
    using System;
    using System.Threading;

    /// <summary>
    /// Stopping a thread
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading.threadstart(v=vs.110).aspx"/>
    /// <seealso cref="https://msdn.microsoft.com/en-us/library/6x4c42hc(v=vs.110).aspx"/>
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}