using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            Data = data;
        }

        public SuccessDataResult(T data):base(data, true)
        {
                Data = data;
        }

        public SuccessDataResult(string message):base(default, true,message) // default: bir şey göndermek istemiyorsak o veri tipinde default değer gönderir.
        {

        }

       public SuccessDataResult():base(default, true)
       {

       }

        public T Data { get;  }

    }
}
