using System;
using System.Collections.Generic;
using System.Text;

namespace TestCrud.Infrastructure.BaseResults
{
    public class BaseServiceResult<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
        public bool IsSuccess { get; set; } = true;
    }
}
