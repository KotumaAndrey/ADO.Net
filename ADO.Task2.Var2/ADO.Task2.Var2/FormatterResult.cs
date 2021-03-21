﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Task2.Var2
{
    public class FormatterResult<T>
        {
            public T Value { get; set; }
            public List<FormatterError> Errors { get; set; } = new List<FormatterError>();
            public bool IsValid => Errors.Count == 0;
        }
}
