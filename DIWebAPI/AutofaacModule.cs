using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using DI;

namespace DIWebAPI
{
    public class AutofaacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AutofacInterceptor>();
            builder.RegisterType<Account>().As<IAcccount>().SingleInstance().EnableInterfaceInterceptors();
        }
        public class AutofacInterceptor : IInterceptor
        {
            void IInterceptor.Intercept(IInvocation invocation)
            {
                Console.WriteLine("拦截前");
                invocation.Proceed();
                Console.WriteLine("拦截后");
            }
        }

    }
}
