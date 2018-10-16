using Autofac;
using EMarket.BLL.Category;
using EMarket.BLL.Interfaces;
using EMarket.BLL.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.BLL.Module
{
    public class BllModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryService>().AsImplementedInterfaces();
            builder.RegisterType<ProductService>().AsImplementedInterfaces();
            base.Load(builder);
        }
    }
}
