namespace Exam70483CodeSamples.Threading._18
{
    using System;
    using System.Threading.Tasks;
    using System.Net.Http;

    /// <summary>
    /// Using 'async' and 'await'
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.Read();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("https://adrientorris.github.io/index.html");
                return result;
            }
        }
    }
}