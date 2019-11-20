using BlazorRadesWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRadesWeb.Model;

namespace BlazorRadesWeb.Pages
{
    public interface ICalibrationCasesListViewModel
    {
        Task GetCalibrationsAsync();

        Task OpenCalibrationCase(string id);

        BlazorRadesWeb.Model.CalibrationCase[] CalibrationCases { get; set; }
    }

    public class CalibrationCasesListViewModel : ICalibrationCasesListViewModel
    {
        private readonly ICalibrationCaseService calibrationCaseService;
#pragma warning disable CS0169 // The field 'CalibrationCasesListViewModel.messageText' is never used
        private string messageText;
#pragma warning restore CS0169 // The field 'CalibrationCasesListViewModel.messageText' is never used

        public BlazorRadesWeb.Model.CalibrationCase[] CalibrationCases { get; set; }
       
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task OpenCalibrationCase(string id)
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {

        }

        public CalibrationCasesListViewModel(ICalibrationCaseService calibrationCaseService)
        {
            this.calibrationCaseService = calibrationCaseService;
        }

        public async Task GetCalibrationsAsync()
        {
            CalibrationCases = await this.calibrationCaseService.GetCalibrationsAsync(DateTime.Now);
        }
    }
}
