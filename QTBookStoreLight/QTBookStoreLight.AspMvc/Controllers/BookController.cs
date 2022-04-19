using QTBookStoreLight.Logic.Controllers;
using QTBookStoreLight.Logic.Entities;

namespace QTBookStoreLight.AspMvc.Controllers
{
    public class BookController : GenericController<Logic.Entities.Book, Models.Book>
    {
        public BookController(Logic.Controllers.BooksController controller) : base(controller)
        {
        }
    }
}
