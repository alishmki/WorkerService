using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QueueSample;

namespace BackgroundQueue.Controllers
{

    public class BooksController : Controller
    {
        private readonly IBackgroundQueue<Book> _queue;

        public BooksController(IBackgroundQueue<Book> queue)
        {
            _queue = queue;
        }

        [HttpPost]
        [Route("test")]
        public IActionResult Publish([FromBody] Book book)
        {
            _queue.Enqueue(book);          
            return Ok();
        }
    }
}
