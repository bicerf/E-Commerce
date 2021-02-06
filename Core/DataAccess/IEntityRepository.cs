using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class:referans tipi temsil eder
    //IEntity:IEntity olabilir ya da IEntity imlement eden nesne olabilir
    //new():new'lenebilir olmalı(IEntity(interface) newlenemeyeceği için istediğimizi elde ettik

    public interface IEntityRepository<T> where T:class,IEntity,new() //generic tip <T> //buradaki class class olabilir anlamında değil referans tip olabilir demek onu temsil ediyor " , IEntity dedik çünkü gelişi güzel T tanımlanmasını istemiyoruz.Entity>Concretedeki entitylerimz olsun sadece
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
