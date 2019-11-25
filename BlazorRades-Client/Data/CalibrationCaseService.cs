using BlazorRadesWeb.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRadesWeb.Model;

namespace BlazorRadesWeb.Data
{
    public interface ICalibrationCaseService
    {
        Task<BlazorRadesWeb.Model.CalibrationCase[]> GetCalibrationsAsync(DateTime startDate);
        Model.CalibrationCase GetCalibrationCaseAsync(string id);
    }

    public class CalibrationCaseService : ICalibrationCaseService
    {
        public Model.CalibrationCase GetCalibrationCaseAsync(string id)
        {
            var rng = new Random();
            return new BlazorRadesWeb.Model.CalibrationCase()
            {
                CreateDate = DateTime.Now.AddDays(rng.Next(0, 10)),
                Id = int.Parse(id),
                Material = rng.Next(0, 4),
                SectionCategory = "Prosth",
                State = "Draft",
                Surface = rng.Next(0, 8),
                ToothNumber = rng.Next(0, 34),
                UploadedBy = "Me",
            };
        }

        public Task<Model.CalibrationCase[]> GetCalibrationsAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Model.CalibrationCase
            {
                CreateDate = startDate.AddDays(-index),
                Material = 2,
                ToothNumber = 12,
                Id = rng.Next(100, 999),
                State = "Active",
                UploadedBy = "You2",
                Surface = 14,
            }).ToArray());
        }
    }
}
