using System;
using System.Net.Http;

namespace May4
{
    class Program
    {
         public static void Main(string[] args)
        {
            String str = "azor";
            var httpClient = new HttpClient();
            httpClient.GetAsync("https://www.pja.edu.pl");
            Console.WriteLine(str);
            Console.WriteLine("Hello World!");
        }
    }
}
