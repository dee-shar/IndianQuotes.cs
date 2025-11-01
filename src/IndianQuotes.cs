using System.Net.Http;

namespace IndianQuotesApi
{
    public class IndianQuotes
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://indian-quotes-api.vercel.app/api";
        public IndianQuotes()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36");
        }

        public async Task<string> GetRandomQuote()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/quotes/random");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetQuote(int quoteId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/quotes/{quoteId}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
