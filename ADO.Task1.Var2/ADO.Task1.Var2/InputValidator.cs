using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task1.Var2
{
    class FormatterError
    {
        public string ErrorMessage { get; set; }

        public static FormatterError Create(string message) => new FormatterError
        {
            ErrorMessage = message
        };
    }

    class FormatterResult<T> where T : struct
    {
        public T? Value { get; set; } = null;
        public List<FormatterError> Errors { get; set; } = new List<FormatterError>();
        public bool IsValid => Errors.Count == 0;
    }


    static class StringFormatter
    {
        public static FormatterResult<double> GetDouble(string input)
        {
            FormatterResult<double> res = new FormatterResult<double>();

            if (input == null)
            {
                res.Errors.Add(FormatterError.Create("String is null"));
                return res;
            }

            if (input.Length == 0)
            {
                res.Errors.Add(FormatterError.Create("String is empty"));
                return res;
            }

            double val = 0;
            if (!double.TryParse(input, out val))
            {
                res.Errors.Add(FormatterError.Create("Cant transform the string"));
            }

            if (input.Contains("."))
            {
                res.Errors.Add(FormatterError.Create("Need not a dor, but comma"));
            }

            res.Value = val;

            return res;
        }
    }
}
