using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ado.Task2.Var2
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
                return res;
            }
            if (val <= 0)
            {
                res.Errors.Add(formatterError.Create("Can be only positive number"));
                return res;
            }

            res.Value = val;

            return res;
        }

        public FormatterResult<int> GetInt(string input)
        {
            FormatterResult<int> res = new FormatterResult<int>();
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

            int val = 0;
            if (!int.TryParse(input, out val))
            {
                res.Errors.Add(formatterError.Create("Cant transform the string"));
                return res;
            }
            if (val <= 0)
            {
                res.Errors.Add(formatterError.Create("Can be only positive number"));
                return res;
            }
            res.Value = val;

            return res;
        }

        public FormatterResult<string> GetString(string input)
        {
            FormatterResult<string> res = new FormatterResult<string>();
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
            
            Regex regex = new Regex("[a-zA-Z]");
            if (!regex.IsMatch(input))
            {
                res.Errors.Add(formatterError.Create("String hasn't any word"));
                return res;
            }

            res.Value = input;

            return res;
        }
    }
}
