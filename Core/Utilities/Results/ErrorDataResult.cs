using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>: DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
            Data = data;
        }

        public ErrorDataResult(T data) : base(data, false)
        {
            Data = data;
        }

        public ErrorDataResult(string message) : base(default, false, message) // default: bir şey göndermek istemiyorsak o veri tipinde default değer gönderir.
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }

        public T Data { get; }
    }
}
