using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task1.Var2
{
    public class StringFormatter
    {
        public FormatterResult<double> GetDouble(string input)
        {
            FormatterResult<double> res = new FormatterResult<double>();
            FormatterError formatterError = new FormatterError();
            if (input == null)
            {
                res.Errors.Add(formatterError.Create("String is null"));
                return res;
            }

            if (input.Length == 0)
            {
                res.Errors.Add(formatterError.Create("String is empty"));
                return res;
            }

            double val = 0;
            if (!double.TryParse(input, out val))
            {
                res.Errors.Add(formatterError.Create("Cant transform the string"));
            }

            res.Value = val;

            return res;
        }
    }
}
