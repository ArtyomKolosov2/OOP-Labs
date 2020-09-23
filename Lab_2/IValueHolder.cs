using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    interface IValueHolder<T>
    {
        T Value { get; set; }
    }
}
