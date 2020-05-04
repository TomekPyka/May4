using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace May4
{
    class Program{
         public static async Task Main(string[] args){
            string str = "azor";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://www.pja.edu.pl");
            if (response.IsSuccessStatusCode) //2xx
            {
                string html = await response.Content.ReadAsStringAsync();
                Regex regex = new Regex("[a-z0-9]+@[a-z0-9.]+");
                MatchCollection matches = regex.Matches(html);
                foreach (object i in matches)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(str);
            Console.WriteLine("Bye world!");
        }
    }
}
