using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DIWebAPI.AutofaacModule;

namespace DI
{
    [Intercept(typeof(AutofacInterceptor))]
    public interface IAcccount
    {
        public void Prient();
    }
}
