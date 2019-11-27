using BlazorRadesWeb.Client.Data;
using BlazorRadesWeb.Client.Pages;
using BlazorRadesWeb.Pages;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorRadesWeb.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
           // services.AddRazorPages();
            //services.AddServerSideBlazor();
            //services.AddSingleton<WeatherForecastService>();
            services.AddScoped<IProcedureAndScoringViewModel, ProcedureAndScoringViewModel>();
            services.AddTransient<ICaseServices, CaseServices>();
            services.AddTransient<ICaseRepository, CaseRepository>();
            services.AddTransient<ICalibrationCasesListViewModel, CalibrationCasesListViewModel>();
            services.AddTransient<ICalibrationCaseService, CalibrationCaseService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
