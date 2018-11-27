using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookStore.Models;


namespace BookStore.DAL
{
    //he definition of the data context class that has a constructor to pass a connection string that is defined in web.config file. 
    //By default the connection string name is the same name as the data context class but we can use a different name for the connection string so that all the data contexts can use a single connection string.
    public class BookContext : DbContext
    {
        public BookContext() : base("name = BookStoreConnectionString")
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}