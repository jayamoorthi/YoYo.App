using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using YoYo.API.Middleware;
using YoYo.Application.Extensions;
using YoYo.Application.Features.Person.Commands.Create;
using YoYo.Infrastructure.Extensions;
using YoYo.Infrastructure.YoyoTestDbContext;

namespace YoYo.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<YoYoDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("YoYoDbConnection")));
            //services.AddTransient(typeof(LoggingBehavior<,>), typeof(IPipelineBehavior<,>));
            //services.AddTransient(typeof(ValidatorBehavior<,>), typeof(IPipelineBehavior<,>));
            //services.AddTransient(typeof(CreatePersonCommand), typeof(IRequestHandler<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
            //services.AddTransient<IValidator<CreatePersonCommand>, PersonValidator>();
            services.AddApllicationLayer();
           // services.AddMediatorHandlers(typeof(Startup).GetTypeInfo().Assembly);
            
            services.AddRepositories();
           
            // services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy",builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            services.AddControllers()
             .AddJsonOptions(options =>
             {
                 options.JsonSerializerOptions.PropertyNamingPolicy = null;
             });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("MyPolicy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
