# IndianQuotes.cs
Web-API for [indian-quotes-api.vercel.app](https://indian-quotes-api.vercel.app/) a curated API for Indian Entrepreneur Quotes

## Example
```cs
using IndianQuotesApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new IndianQuotes();
            string quote = await api.GetRandomQuote();
            Console.WriteLine(quote);
        }
    }
}
```
