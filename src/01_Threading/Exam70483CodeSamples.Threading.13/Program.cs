namespace Exam70483CodeSamples.Threading._13
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Using a TaskFactory
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading.tasks.taskfactory(v=vs.110).aspx"/>
    /// <seealso cref="https://msdn.microsoft.com/en-us/library/dd321439(v=vs.110).aspx"/>
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];

                TaskFactory tf = new TaskFactory(
                    TaskCreationOptions.AttachedToParent
                    , TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                        Console.WriteLine(i);
                });

            finalTask.Wait();
        }
    }
}