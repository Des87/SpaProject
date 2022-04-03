using Autofac;
using SpaProject.Factories;
using SpaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Data
{
    public static class IocContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<CustomersTrackFactory>().As<ICustomersTrackFactory>();
            builder.RegisterType<SaunaFactory>().As<ISaunaFactory>();

            builder.RegisterType<DbFunc>().As<IDbFunc>();
            builder.RegisterType<DepartmentsStatisticRepository>().As<IDepartmentsStatisticRepository>();
            builder.RegisterType<FirstAndLastCustomerRepository>().As<IFirstAndLastCustomerRepository>();
            builder.RegisterType<LongestTimeInTheSpaRepository>().As<ILongestTimeInTheSpaRepository>();
            builder.RegisterType<OnlyUsedOneDepartmentRepository>().As<IOnlyUsedOneDepartmentRepository>();
            builder.RegisterType<ReadTxtRepository>().As<IReadTxtRepository>();
            builder.RegisterType<SaunaListRepository>().As<ISaunaListRepository>();
            builder.RegisterType<TimeStatisticRepository>().As<ITimeStatisticRepository>();

            builder.RegisterType<ReadFromFile>().As<IRead>();
            builder.RegisterType<ReadNoAgain>().As<IRead>();
            builder.RegisterType<SaveSauna>().As<ISaveSauna>();
            builder.RegisterType<NullCheckDatabase>().As<INullCheckDatabase>();

            builder.RegisterType<ContextDb>().SingleInstance();


            return builder.Build();
        }
    }
}
