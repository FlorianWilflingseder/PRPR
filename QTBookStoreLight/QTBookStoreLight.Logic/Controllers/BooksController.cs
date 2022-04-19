using QTBookStoreLight.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTBookStoreLight.Logic.Controllers
{
    public class BooksController : GenericController<Entities.Book>
    {
        public BooksController()
        {
        }

        public BooksController(ControllerObject other) : base(other)
        {

        }

        public override Task<Book> InsertAsync(Book entity)
        {
            CheckEntity(entity);
            return base.InsertAsync(entity);
        }
        public override Task<Book> UpdateAsync(Book entity)
        {
            CheckEntity(entity);
            return base.UpdateAsync(entity);
        }

        public override Task<IEnumerable<Book>> InsertAsync(IEnumerable<Book> entities)
        {
            entities.ToList().ForEach(entity => CheckEntity(entity));
            return base.InsertAsync(entities);
        }

        public override Task<IEnumerable<Book>> UpdateAsync(IEnumerable<Book> entities)
        {
            entities.ToList().ForEach(entity => CheckEntity(entity));
            return base.UpdateAsync(entities);
        }
        public void CheckEntity(Entities.Book book)
        {
            if (!CheckISBN(book.ISBNNumber))
            {
                throw new Exception("ISBNumber ungültig");
            }
            if(book.Author == null)
            {
                throw new ArgumentNullException(nameof(book.Author));
            }
        }

        public bool CheckISBN(string isbn)
        {
            bool isValid = false;       
            
            var result = 0;
            var rest = 0;
            for(int i = 0; i < isbn.Length -1; i++)
            {
                result += (isbn[i] - '0') * (i + 1);

            }
            rest = result % 11;

            if(rest == 10 && isbn[9] == 'X')
            {
               isValid = true;
            }
         
            if(rest == isbn[9] - '0')
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
