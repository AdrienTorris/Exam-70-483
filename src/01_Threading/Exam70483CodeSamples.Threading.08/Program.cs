namespace Exam70483CodeSamples.Threading._08
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Starting a new Task
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading.tasks(v=vs.110).aspx"/>
    /// <remarks>
    /// - Call Wait() is equals than calling Join() on a thread, it wait till the Task is finished before exiting the application.
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine("i: {0}", i);
                }
            });

            t.Wait();
        }
    }
}