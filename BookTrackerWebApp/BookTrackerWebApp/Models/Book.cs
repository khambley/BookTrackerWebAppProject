using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackerWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string SeriesName { get; set; }
        public int SeriesBookNum  { get; set; } //Book number in a given series i.e. "Star Wars Legends: Book 1"
        public string SeriesTimeline { get; set; }
        public string ImageUrl { get; set; }
        public string Synopsis { get; set; }
        public DateTime Year { get; set; }
        public string Publisher { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }

        public string Notes { get; set; }
    }
}
