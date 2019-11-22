using BlazorRadesWeb.Data;
using BlazorRadesWeb.Pages;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorRadesWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
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
