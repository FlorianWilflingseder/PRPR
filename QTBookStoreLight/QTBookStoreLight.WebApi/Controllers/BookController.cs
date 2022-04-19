using QTBookStoreLight.Logic.Controllers;
using QTBookStoreLight.Logic.Entities;

namespace QTBookStoreLight.WebApi.Controllers
{
    public class BookController : GenericController<Logic.Entities.Book, Models.EditBook, Models.Book>
    {
        public BookController(Logic.Controllers.BooksController controller) : base(controller)
        {

        }
    }
}
