using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static async Task<string> GetHelloAsync()
        {
            return await Task.Run(() => { return "HELLO JANKINS. HELLO GIT. HELLO C#."; });
        }
        static async Task Main(string[] args)
        {
            string a=await GetHelloAsync();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
