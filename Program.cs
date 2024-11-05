using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpFun
{
  class Program
  {
    static async Task Main(string[] args)
    {
      string url = "https://official-joke-api.appspot.com/random_joke";

      using HttpClient client = new HttpClient();

      try 
      {

        // Send Get Request
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        //Read The response as string
        string responseBody = await response.Content.ReadAsStringAsync();
      }
    }
  }
}