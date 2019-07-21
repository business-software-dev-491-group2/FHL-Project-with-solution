using FHLProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace FHLProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //db migration
            var connection = @"Server=(localdb)\mssqllocaldb;Database=FHLProject;Trusted_connection=True;";
            services.AddDbContext<CDsDBContext>(options => options.UseSqlServer(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(
                 routes =>
                 {
                     routes.MapRoute(name: "default", template: "{controller=Search}/{action=Index}/{id?}"); //Might need to change 'Search' to 'Home' - Michael
                 }
                 );
        }
    }
}
