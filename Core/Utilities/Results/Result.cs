using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   
    public class Result : IResult
    {

        public Result(bool success, string message):this(success) // bir constructor ın başka bir constructor ı çalıştırabilmesi - this classı hitap eder yani Result ı
        {
            Message = message;
        }

        public Result(bool success) // message yazmak istemezsek overload ile tek parametreli de yapabiliriz. 
        {
            Success = success;  
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
