using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task2.Var2
{
    public class Author
    {
        private string Name { get; set; }
        private string Familia { get; set; }
        private DateTime BirthDate { get; set; }
        public Author(string name, string familia, DateTime date)
        {
            this.BirthDate = date;
            this.Familia = familia;
            this.Name = name;
        }
    }
}
