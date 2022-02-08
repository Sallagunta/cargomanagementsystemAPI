using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cargomanagementsystem.DAL.DATA;
using Microsoft.EntityFrameworkCore;
using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.BAL.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace cargomanagementsystemAPI
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
        { string connectionStr = Configuration.GetConnectionString("sqlconnection");
            services.AddDbContext<cargomanagementDbcontext>(options => options.UseSqlServer(connectionStr));
            services.AddControllers();

            
         
           
            services.AddTransient<IcustRepository, custrepository>();
            services.AddTransient<CargomanagementService, CargomanagementService>();
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<TransactionServices, TransactionServices>();
            services.AddTransient<IcustRepository, custrepository>();
            services.AddTransient<IRegisterrepository, Registerrepository > ();
            services.AddTransient<RegisterService, RegisterService> ();
            services.AddTransient<IAdminRepository, AdminRepository>();

            services.AddTransient<AdminService, AdminService>();
           


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
