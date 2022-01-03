using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient_ConsoleTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://localhost:44306/api/categories";

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var categories = JsonConvert.DeserializeObject<List<Category>>(response);

                foreach (var category in categories)
                {
                    Console.WriteLine($"IdCategory = {category.IdCategory}, Name = {category.Name} ");
                    Console.WriteLine("--------------------------");
                }

                Console.ReadLine();
            }
        }
    }
}
