using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) // Iresult türündeki her şeyi diziye atar..
        {
            List<IResult> results = new List<IResult>();
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    results.Add(logic);
                }
            }
            return new SuccessResult();
        }
    }
}
