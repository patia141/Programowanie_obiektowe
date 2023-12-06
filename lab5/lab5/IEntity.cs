using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
