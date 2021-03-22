using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task2.Var2
{
    public class Book
    {
        private string Name { get; set; }
        private int Length { get; set; }
        private string Publisher { get; set; }
        private DateTime PublishedDate { get; set; }
        private DateTime WrittenDate { get; set; }
        private Author BookAuthor { get; set; }
        public Book(string name, int length, string publisher,
            DateTime published_date, DateTime written_date, Author author)
        {
            this.BookAuthor = author;
            this.Length = length;
            this.Publisher = publisher;
            this.PublishedDate = published_date;
            this.WrittenDate = written_date;
        }
    }
}
