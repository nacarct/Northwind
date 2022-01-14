using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Northwind.Bll;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.EntityFramework.Context;
using Northwind.Dal.Concrete.EntityFramework.Repository;
using Northwind.Dal.Concrete.EntityFramework.UnitOfWork;

namespace Northwind.WebApi
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
            #region Jwt Token Service

            #endregion

            #region Application Context
            // Db Connection 1
            //services.AddDbContext<NorthwindContext>();
            //services.AddScoped<DbContext, NorthwindContext>();

            //Db Connection 2
            services.AddScoped<DbContext, NorthwindContext>();
            services.AddDbContext<NorthwindContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("SqlServer"), 
                    sqlOption =>
                {
                    sqlOption.MigrationsAssembly("Northwind.Dal");
                });
            });

            #endregion

            //-------------------------------------------------------------------

            #region Service Section

            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<ICustomerService, CustomerManager>();

            #endregion

            //-------------------------------------------------------------------

            #region Repository Section

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            #endregion

            //-------------------------------------------------------------------

            #region Unit Of Works

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion

            


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Northwind.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Northwind.WebApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
