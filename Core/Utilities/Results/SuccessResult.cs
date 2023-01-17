using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) //  işlem başarılı ise bu class çağrılır true demeye gerek kalmaz sadece mesaj gönderilir - ana Result ın ana constructor ını çağırır. 
        {


        }

        public SuccessResult() : base(true) // işlem başarılı ise bu class çağrılır true demeye gerek kalmaz sadece mesaj gönderilir. 
        {


        }
    }
}
