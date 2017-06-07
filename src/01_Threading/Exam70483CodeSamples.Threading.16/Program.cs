namespace Exam70483CodeSamples.Threading._16
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Using 'Parallel.For' and 'Parallel.ForEach'
    /// </summary>
    /// <remarks>
    /// - 'Parallel' class is a static class
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("For loop. {0}", i);
                Thread.Sleep(1000);
              });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine("ForEach loop. {0}", i);
                Thread.Sleep(1000);
             });
        }
    }
}