namespace Exam70483CodeSamples.Threading._10
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Adding a continuation
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading.tasks.task.continuewith(v=vs.110).aspx"/>
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 5;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);
        }
    }
}