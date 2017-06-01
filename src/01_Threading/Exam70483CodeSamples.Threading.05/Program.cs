namespace Exam70483CodeSamples.Threading._05
{
    using System;
    using System.Threading;

    /// <summary>
    /// Using the ThreadStaticAttribute
    /// </summary>
    class Program
    {
        [ThreadStatic]
        static int _staticField;

        static int _nonStaticField;

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < 5; x++)
                {
                    _staticField++;
                    Console.WriteLine("Thread A: {0}", _staticField);

                    _nonStaticField++;
                    Console.WriteLine("Thread A: {0}", _nonStaticField);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 5; x++)
                {
                    _staticField++;
                    Console.WriteLine("Thread B: {0}", _staticField);

                    _nonStaticField++;
                    Console.WriteLine("Thread B: {0}", _nonStaticField);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}