using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        public SuccessDataResult(T data):base(data,true) //mesaj istemiyorum
        {

        }

        public SuccessDataResult(string message):base(default,true,message) //sadece mesaj veriyorum
        {

        }
        public SuccessDataResult():base(default,true) //hiçbir şey vermiyorum,base e dafult ve true gidiyor
        {

        }
    }
}
