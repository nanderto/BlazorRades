using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRadesWeb.Controllers
{
    public class CalibrationCaseRepository : ICalibrationCaseRepository
    {
        public async Task<Model.CalibrationCase> GetCalibrationCaseAsync(string id)
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

        public async Task<Model.CalibrationCase[]> GetCalibrationCaseAsync(DateTime startDate)
        {
            var rng = new Random();
            return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new Model.CalibrationCase
            {
                CreateDate = startDate.AddDays(-index),
                Material = 2,
                ToothNumber = 13,
                Id = rng.Next(100, 999),
                State = "Active",
                UploadedBy = "You2",
                Surface = 15,
            }).ToArray());
        }

        public async Task<Model.CalibrationCase[]> GetCalibrationCaseAsync()
        {
            var rng = new Random();
            return await Task.FromResult(Enumerable.Range(1, 7).Select(index => new Model.CalibrationCase
            {
                CreateDate = DateTime.Now.AddDays(-index),
                Material = 2,
                ToothNumber = 13,
                Id = rng.Next(100, 999),
                State = "Active",
                UploadedBy = "You2",
                Surface = 15,
            }).ToArray());
        }
    }
}
