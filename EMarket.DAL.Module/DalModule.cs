using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using EMarket.DAL.Category;
using EMarket.DAL.Interfaces;
using EMarket.DAL.Product;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.Extensions.Configuration;


namespace EMarket.DAL.Module
{
    public class DalModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepository>().AsImplementedInterfaces();
            builder.RegisterType<ProductRepository>().AsImplementedInterfaces();
            base.Load(builder);
        }
    }
}
