using Castle.DynamicProxy;
using Core.CrossCuttingConcers.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive coding (tip kontrolü)
            if (!typeof(IValidator).IsAssignableFrom(validatorType)) // IsAssignable parametre IValidator a atanabilir mi kontrolü 
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil!");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation) // MethodInterception abstract class oldğ. OnBefore u eziyor. 
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // çalışma anında instance oluşturur . Gelen vakidatortype tipinde oluşturur IValidator türünde kullanabilir .
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // AbstractValidatorun generic argümanlarının ilkini alıyor. 
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);  // methodun parametrelerini gez ve validator tipine eşit olan parametreyi bul. 
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
