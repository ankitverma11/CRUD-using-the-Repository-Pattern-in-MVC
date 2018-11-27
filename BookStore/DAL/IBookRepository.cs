using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;

namespace BookStore.DAL
{
   // create an IBookRepository interface that has the filename IBookRepository.cs.
   // This interface code declares a typical set of CRUD methods, including two read methods; one that returns all Book entity sets, and one that finds a single Book entity by ID.

    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book getBookByID(int bookID);
        void InsertBook(Book book);
        void DeleteBook(int bookID);
        void UpdateBook(Book book);
        void save();
    }
}