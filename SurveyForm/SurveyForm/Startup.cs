using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
namespace SurveyForm
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            // app.UseSession();
            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}