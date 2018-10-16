using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Web
{
    public class AutofacServiceProvider : IServiceProvider
    {
        public AutofacServiceProvider(Autofac.IContainer container)
        {

        }

        public object GetService(Type serviceType)
        {
            return serviceType; 
        }
    }
}
