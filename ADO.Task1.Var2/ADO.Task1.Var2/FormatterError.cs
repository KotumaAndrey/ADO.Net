using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task1.Var2
{
    public class FormatterError
    {
        public string ErrorMessage { get; set; }

        public FormatterError Create(string message) => new FormatterError
        {
            ErrorMessage = message
        };
    }
}
