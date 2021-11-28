using System.Threading;
using System.Threading.Tasks;

namespace QueueSample
{
    public interface IBookPublisher
    {
        Task Publish(Book book, CancellationToken stoppingToken);
    }
}