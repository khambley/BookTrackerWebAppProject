using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackerWebApp.Models
{
    public class DataRepository : IRepository
    {
        //private List<Book> data = new List<Book>();
        private DataContext context;

        public DataRepository(DataContext ctx) => context = ctx;

        public IEnumerable<Book> Books => context.Books;

        public void AddBook(Book book)
        {
            this.context.Books.Add(book);
            this.context.SaveChanges();
        }
     }
}
