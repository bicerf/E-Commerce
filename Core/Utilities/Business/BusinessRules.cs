using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //params veridiğin an Run içerisine istediğimiz kadar IResult verebiliriz parametre olarak
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) //başarısız olan iş kuralını gönderip bildiriyor
                {
                    return logic;   //burada da zaten başarısız old.için ilgili kuralın error ını verir:)
                }
            }
            return null;
        }
    }
}
