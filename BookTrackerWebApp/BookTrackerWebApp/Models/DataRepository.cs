using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackerWebApp.Models
{
    public class DataRepository : IRepository
    {
        private List<Book> data = new List<Book>();
        public IEnumerable<Book> Books => data;
        public void AddBook(Book book)
        {
            this.data.Add(book);
        }
     }
}
