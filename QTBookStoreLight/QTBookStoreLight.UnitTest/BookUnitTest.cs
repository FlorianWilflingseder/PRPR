using Microsoft.VisualStudio.TestTools.UnitTesting;
using QTBookStoreLight.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QTBookStoreLight.UnitTest
{
    [TestClass]
    public class BookUnitTest
    {

        [TestInitialize]
        public async Task TestInitialize()
        {
            using var ctrl = new Logic.Controllers.BooksController();
            var entities = await ctrl.GetAllAsync();
            List<Book> list = new List<Book>(entities);
            list.ForEach(x => ctrl.DeleteAsync(x.Id));
            await ctrl.SaveChangesAsync();
        }

        [TestMethod]
        public async Task CreateBook_WithValidISBN_ShouldCreate()
        {
            using var ctrl = new Logic.Controllers.BooksController();
            Book book = new Book { Author = "asdasd", Description = "asdasd", ISBNNumber = "3446193138", Note = "asdasd", Price = 22 };
            
            var createdBook = await ctrl.InsertAsync(book);

            Assert.AreEqual(book.ISBNNumber, createdBook.ISBNNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public async Task CreateBook_WithInValidISBN_ShouldThrowException()
        {
            using var ctrl = new Logic.Controllers.BooksController();
            Book book = new Book { Author = "asdasd", Description = "asdasd", ISBNNumber = "3446193137", Note = "asdasd", Price = 22 };

            var createdBook = await ctrl.InsertAsync(book);

            Assert.AreEqual(book.ISBNNumber, createdBook.ISBNNumber);

        }

    }
}