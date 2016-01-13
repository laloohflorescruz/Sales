using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Sale.EF;
using Sale.Models.Model;

namespace Sale.Controllers
{
    public class BookController : ApiController
    {

        private readonly Context _context = new Context();

        // GET: api/Book
        public IEnumerable<Book> Get()
        {
            return _context.Books;
        }

        // GET: api/Book/5
        public Book Get(int id)
        {
            return _context.Books.Find(id);
        }

        // POST: api/Book
        public void Post([FromBody]Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]Book book)
        {
            if (id != book.Id) return;
            _context.Entry(book).State = EntityState.Modified;

            _context.SaveChanges();
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return;
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
