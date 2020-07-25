using System;
using Castle.DynamicProxy;
namespace my.core.mvc.Untility
{
    public class CustomAutofacAop:IInterceptor
    {
        public CustomAutofacAop()
        {
        }

        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"执行前{invocation.Method.Name}");
            invocation.Proceed();
            Console.WriteLine("执行后");
        }
    }
}
