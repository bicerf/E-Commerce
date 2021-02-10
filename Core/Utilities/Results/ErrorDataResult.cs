using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>: DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false) //mesaj istemiyorum
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) //sadece mesaj veriyorum
        {

        }
        public ErrorDataResult() : base(default, false) //hiçbir şey vermiyorum,base e dafult ve true gidiyor
        {

        }
    }
}
