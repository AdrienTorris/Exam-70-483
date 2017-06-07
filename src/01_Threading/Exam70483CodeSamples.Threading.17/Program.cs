namespace Exam70483CodeSamples.Threading._17
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Using 'Parallel.Break' and 'Parallel.Stop'
    /// </summary>
    /// <remarks>
    /// Break != Stop
    /// Break ensures that all iterations that are currently running will be finished. Stop just terminates everthing.
    /// </remarks>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading.tasks.parallelloopstate.break(v=vs.110).aspx"/>
    /// <seealso cref="https://msdn.microsoft.com/en-us/library/dd460721(v=vs.110).aspx"/>
    class Program
    {
        static void Main(string[] args)
        {
            // Breaking loop

            ParallelLoopResult breakResult = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
              {
                  if (i == 500)
                  {
                      Console.WriteLine("Breaking loop");
                      loopState.Break();
                  }

                  return;
              });

            Console.WriteLine("Breaking loop result:");
            Console.WriteLine("IsCompleted: {0}", breakResult.IsCompleted);
            Console.WriteLine("Is LowestBreakIteration null ? {0}", breakResult.LowestBreakIteration == null);
            Console.WriteLine("LowestBreakIteration: {0}", breakResult.LowestBreakIteration);

            // Stopping loop

            Console.WriteLine("------");
            Console.WriteLine("------");

            ParallelLoopResult stopResult = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Stopping loop");
                    loopState.Stop();
                }

                return;
            });

            Console.WriteLine("Stopping loop result:");
            Console.WriteLine("IsCompleted: {0}", stopResult.IsCompleted);
            Console.WriteLine("Is LowestBreakIteration null ? {0}", stopResult.LowestBreakIteration == null);
            Console.WriteLine("LowestBreakIteration: {0}", stopResult.LowestBreakIteration);

            //

            Console.Read();
        }
    }
}