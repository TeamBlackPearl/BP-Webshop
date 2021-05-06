using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;

namespace BP_Webshop
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
            services.AddRazorPages();

            services.AddDbContext<BlackPDbContext>();

            //Add Userservice
            services.AddSingleton<UserService, UserService>();
            services.AddSingleton<OrderService, OrderService>();
            services.AddSingleton<AdminService, AdminService>();
            services.AddSingleton<BraceletService, BraceletService>();
            services.AddSingleton<NecklaceService, NecklaceService>();
            services.AddSingleton<EarringService, EarringService>();
            services.AddSingleton<JewelryService, JewelryService>();



            //services.AddTransient<GenericCRUDMethods<Jewelry>, GenericCRUDMethods<Jewelry>>();
            services.AddTransient<GenericCRUDMethods<Earring>, GenericCRUDMethods<Earring>>();
            services.AddTransient<GenericCRUDMethods<Necklace>, GenericCRUDMethods<Necklace>>();
            services.AddTransient<GenericCRUDMethods<Bracelet>, GenericCRUDMethods<Bracelet>>();
            services.AddTransient<GenericCRUDMethods<HeadJewelry>, GenericCRUDMethods<HeadJewelry>>();
            services.AddTransient<GenericCRUDMethods<Ring>, GenericCRUDMethods<Ring>>();
            services.AddTransient<GenericCRUDMethods<Order>, GenericCRUDMethods<Order>>();
            services.AddTransient<GenericCRUDMethods<OrderLine>, GenericCRUDMethods<OrderLine>>();
            services.AddTransient<GenericCRUDMethods<User>, GenericCRUDMethods<User>>();
            services.AddTransient<GenericCRUDMethods<AdminUser>, GenericCRUDMethods<AdminUser>>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
