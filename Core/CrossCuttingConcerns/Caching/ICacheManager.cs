using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        void Add(string key, object value, int duration);
        T Get<T>(string key);
        object Get(string key);
        bool IsAdd(string key); //cachede var mı sorusu
        void Remove(string key); //cacheden uçurma
        void RemoveByPattern(string pattern); //içinde pattern olanları uçur pattern belki get beli kategori değişebilir

    }
}
