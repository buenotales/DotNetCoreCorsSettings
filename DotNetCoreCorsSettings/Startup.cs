using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CorsWebProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "myCors",
                    builder =>
                    {
                        builder.WithOrigins("http://www.apirequest.io").AllowAnyMethod().AllowAnyHeader();
                    });
                //options.AddDefaultPolicy(
                //    builder =>
                //    {
                //        builder.WithOrigins("http://example.com",
                //                            "http://www.contoso.com");
                //    });
            });
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("myCors");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
