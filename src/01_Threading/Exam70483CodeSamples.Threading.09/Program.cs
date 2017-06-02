namespace Exam70483CodeSamples.Threading._09
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Using a Task that return a value
    /// </summary>
    /// <remarks>
    /// - Attempting to read the Result property on a Task will force the thread that's trying to read the result to wait until the Task is finished before continuing.
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return new Random().Next(100);
            });

            Console.WriteLine(t.Result);
        }
    }
}