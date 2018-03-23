using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MVC_Cursos.Models;
using MVC_Cursos.Services;
using MVC_Cursos.Services.AutorServices;
using MVC_Cursos.Services.AvaliationServices;
using MVC_Cursos.Services.CourseServices;

namespace MVC_Cursos
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            AddServices(services);
        }        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
                              IHostingEnvironment env,
                              ILogger<Startup> logger,
                              IGreeter greeter,
                              IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes);


            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessageOfDay();
                await context.Response.WriteAsync(greeting);
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default","{controller=Home}/{action=Index}/{id?}");
        }
        private static void AddServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddSingleton<IAvaliationData, Services.AvaliationServices.InMemoryAvaliationData>();
            services.AddSingleton<IAutorData, InMemoryAutorData>();
            services.AddSingleton<ITraineeData, InMemoryTraineeData>();
            services.AddSingleton<ICourseData, InMemoryCourseData>();
            services.AddMvc();
        }
    }
}
