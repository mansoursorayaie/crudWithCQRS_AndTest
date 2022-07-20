using Crud.Data.DataBase;
using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using Crud.EntityCore.Repositories.CustomerProducts;
using Crud.EntityCore.Repositories.Customers;
using Crud.EntityCore.Repositories.Products;
using Crud.Service.BusinessServices.CustomerProducts;
using Crud.Service.BusinessServices.Customers;
using Crud.Service.BusinessServices.Products;
using Crud.Service.Dtos.Customers;
using Crud.Service.Validatiors;
using Crud.Service.Validatiors.Customers;
using FluentValidation;
using FluentValidation.AspNetCore;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TestCrud.Infrastructure.Validations.Filters;

namespace Crud.Service.ServiceConfig
{
    public static class ServiceStartup
    {
        public static IServiceCollection AddCrudServices(
            this IServiceCollection services, string connectionString)
        {
            services.AddDbContextServises(connectionString);
            services.AddRepositorisServices();
            services.AddCustomerServices();
            services.AddMapsterServices();
            services.AdddMediatRServices();
            services.AdddValidatorServices();
            return services;
        }

        public static IServiceCollection AdddValidatorServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CustomerValidator>();
            services.AddFluentValidation(x=>
            {
                x.RegisterValidatorsFromAssemblyContaining<CustomerValidator>();
            });
            return services;
        }

        public static IServiceCollection AddDbContextServises(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<IDbCrud, DbCrud>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

            return services;
        }

        public static IServiceCollection AdddMediatRServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

        public static IServiceCollection AddMapsterServices(this IServiceCollection services)
        {
            services.AddSingleton(TypeAdapterConfig.GlobalSettings);
            services.AddScoped<IMapper, ServiceMapper>();

            return services;
        }

        public static IServiceCollection AddRepositorisServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<ICustomerProductReadRepository, CustomerProductReadRepository>();
            services.AddScoped<ICustomerProductWriteRepository, CustomerProductWriteRepository>();

            return services;
        }

        public static IServiceCollection AddCustomerServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerWriteService, CustomerWriteService>();
            services.AddScoped<ICustomerReadService, CustomerReadService>();

            services.AddScoped<IProductWriteService, ProductWriteService>();
            services.AddScoped<IProductReadService, ProductReadService>();

            services.AddScoped<ICustomerProductWriteService, CustomerProductWriteService>();
            services.AddScoped<ICustomerProductReadService, CustomerProductReadService>();

            return services;
        }
    }
}
