using System;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static async Task<string> GetHelloAsync()
        {
            return await Task.Run(() => { return "HELLO JANKINS. HELLO GIT. HELLO C#."; });
        }
        static void Main(string[] args)
        {
            //massage
            Console.WriteLine(GetHelloAsync().Result);
            Console.ReadLine();
        }
    }
}
