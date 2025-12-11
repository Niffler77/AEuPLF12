using System.Net.Http.Headers;

namespace APITest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Uri uri = new Uri("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");

            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
    }
}
