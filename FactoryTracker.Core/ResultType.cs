using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Core
{
    public class Result<T>
    {
        public T Value { get; }
        public bool IsSuccess { get; }
        public string Error { get; }

        // Конструктор для успешного результата
        public Result(T value)
        {
            Value = value;
            IsSuccess = true;
        }

        // Конструктор для ошибочного результата
        public Result(string error)
        {
            Error = error;
            IsSuccess = false;
        }
    }
}
