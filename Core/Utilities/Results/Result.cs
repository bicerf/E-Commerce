using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success) // bu this bulunduğu classı temsil eder yani şuan Resultı
        {
            Message = message;
            
        }
        //this(success)ın manası ise sen 2 verili ctor ı çalıştır bir de tek paarametreli i çalıştır gibi bir şey asdfasldf
        public Result(bool success)
        {
            Success = success;
        }
        //Ayrıyeten bir ctor yapısı daha yapmamın sebebi istersem mesaj göndermek istemeyebilirim onun da alternatifi olarak yapıldı
        public bool Success { get; } //aynı şekilde readonly olan getter ı set ettik ctorda yukarıda Success=success olarak.Ctor dışında set etmiyoruz! getterları

        public string Message { get; } //getter lar readonlydir.Readonlyler ctorda set edilebilir o yüzden Message ı message olarak set ettik yukarıdaki ctorda.
    }
}
