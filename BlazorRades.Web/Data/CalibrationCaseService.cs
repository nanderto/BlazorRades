using BlazorRadesWeb.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRadesWeb.Data
{
    public interface ICalibrationCaseService
    {
        Task<CalibrationCase[]> GetCalibrationsAsync(DateTime startDate);
    }

    public class CalibrationCaseService : ICalibrationCaseService
    {
        public Task<CalibrationCase[]> GetCalibrationsAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new CalibrationCase
            {
                CreateDate = startDate.AddDays(-index),
                Material = 2,
                ToothNumbeer = 12,
                Id = rng.Next(100, 999),
                State = "Active",
                UploadedBy = 23,
                Surface = 14,
            }).ToArray());
        }
    }
}
