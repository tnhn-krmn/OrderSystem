using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Repositories.Carrier;
using OrderSystemChallange.Application.Repositories.CarrierConfiguration;
using OrderSystemChallange.Application.Repositories.Order;
using OrderSystemChallange.Persistence.Context;
using OrderSystemChallange.Persistence.Repositories.Carrier;
using OrderSystemChallange.Persistence.Repositories.CarrierConfiguration;
using OrderSystemChallange.Persistence.Repositories.Order;
using OrderSystemChallange.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            var data = Configuration.ConnectionString;
            services.AddDbContext<OrderSystemContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Scoped);
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICarrierService, CarrierService>();
            services.AddScoped<ICarrierConfigurationService, CarrierConfigurationService>();

            services.AddScoped<ICarrierReadRepository, CarrierReadRepository>();
            services.AddScoped<ICarrierWriteRepository, CarrierWriteRepository>();

            services.AddScoped<ICarrierConfigurationReadRepository, CarrierConfigurationReadRepository>();
            services.AddScoped<ICarrierConfigurationWriteRepository, CarrierConfigurationWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
    }
}
