using BlazorRadesWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRadesWeb.Pages
{
    public interface ICalibrationCasesListViewModel
    {
        Task GetCalibrationsAsync();

        Task OpenCalibrationCase(string id);

        CalibrationCase[] CalibrationCases { get; set; }
    }

    public class CalibrationCasesListViewModel : ICalibrationCasesListViewModel
    {
        private readonly ICalibrationCaseService calibrationCaseService;
        private string messageText;

        public CalibrationCase[] CalibrationCases { get; set; }
       
        public async Task OpenCalibrationCase(string id)
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
