using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace QueueSample
{
    public class BookPublisher : IBookPublisher
    {
        private readonly ILogger<BookPublisher> logger;

        public BookPublisher(ILogger<BookPublisher> _logger)
        {
            logger = _logger;
        }
        public async Task Publish(Book book, CancellationToken stoppingToken)
        {
            System.Threading.Thread.Sleep(3000);
            logger.LogInformation("published---" + JsonConvert.SerializeObject(book));
            await Task.CompletedTask;
        }
    }
}