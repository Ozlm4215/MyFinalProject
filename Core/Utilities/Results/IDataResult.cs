using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç
    public interface IDataResult<T>: IResult // ne listesi döndüreceğini generic (T) ile belirtiriz, IResult ile işlem sonucu ve mesajı gönderiririz.
    {
       T Data { get; }
    }
}
