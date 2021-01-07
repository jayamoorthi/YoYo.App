using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using YoYo.Application.Interfaces.Repositories;
using YoYo.Infrastructure.Repositories;
using YoYo.Infrastructure.YoyoTestDbContext;

namespace YoYo.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPersistenceContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddScoped<YoYoDbContext, YoYoDbContext>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            #region Repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IFitnessTestRepository, FitnessTestRepository>();
            services.AddTransient<IShuttleRepository, ShuttleRepository>();          
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<ILogRepository, LogRepository>();

            #endregion Repositories
        }
    }
}
