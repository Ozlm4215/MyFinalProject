using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message) //  işlem başarısızsa ise bu class çağrılır true demeye gerek kalmaz sadece mesaj gönderilir - base Result ın ana constructor ını çağırır. 
        {


        }

        public ErrorResult() : base(false) // işlem başarısızsa ise bu class çağrılır true demeye gerek kalmaz sadece mesaj gönderilir. 
        {


        }
    }
}
