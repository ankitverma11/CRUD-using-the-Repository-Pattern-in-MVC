using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;
using System.Data.Entity;

namespace BookStore.DAL
{
    //The class file implements the "IBookRepository" interface and the "IBookRepository" inherits the IDisposable interface so the IDisposable interface is indirectly implemented by the BookRespository class.
    //The database context is defined in a class variable, and the constructor expects the calling object to pass in an instance of the context.
    public class BookRepository : IBookRepository
    {
        BookContext _context;
        public BookRepository (BookContext bookContext)
        {
            this._context = bookContext;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book getBookByID(int bookID)
        {
            return _context.Books.Find(bookID);
        }

        public void InsertBook(Book book)
        {
            _context.Books.Add(book);
        }

        public void DeleteBook(int bookID)
        {
            Book book = _context.Books.Find(bookID);
            _context.Books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
           _context.Entry(book).State = EntityState.Modified;
        }

        public void save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}