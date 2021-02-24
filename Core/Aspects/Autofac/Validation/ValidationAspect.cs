using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validations;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception  //Aspect nerede çalışmasını istiyorsan orada çalışan alan;öncesi sonrası,başarıdan sonra,hatadan sonra etc.
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))//IsAssignable aanabiliyor mu ? sorusu
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation) //sen sadece onbefore'u ez demişiz burada o yüzden methodinterceptiondaki diğerleri çalışmaz
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); //çalışma anında newlemek için reflection code(ProductValidator newlendi)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //productValidatorun base ine git,generic argumanının 0. tipini yakala
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//(add,delete vs) mettodununun parametrelerini gez eğer oradaki tip yualrıdaki type a eşitse onları eşitle
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
