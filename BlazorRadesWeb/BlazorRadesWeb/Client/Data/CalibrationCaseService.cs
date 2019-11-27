using BlazorRadesWeb.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRadesWeb.Model;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorRadesWeb.Client.Data
{
    public interface ICalibrationCaseService
    {
        Task<BlazorRadesWeb.Model.CalibrationCase[]> GetCalibrationsAsync(DateTime startDate);
        Task<Model.CalibrationCase> GetCalibrationCaseAsync(string id);
    }

    public class CalibrationCaseService : ICalibrationCaseService
    {
        public CalibrationCaseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private CalibrationCase calibrationCase;

        private readonly HttpClient httpClient;

        public async Task<Model.CalibrationCase> GetCalibrationCaseAsync(string s)
        {
            return await this.httpClient.GetJsonAsync<CalibrationCase>($"api/CalibrationCase/{s}");
        }

        //public async  Task<Model.CalibrationCase> GetCalibrationCaseAsync(string id)
        //{
        //    var rng = new Random();
        //    return new BlazorRadesWeb.Model.CalibrationCase()
        //    {
        //        CreateDate = DateTime.Now.AddDays(rng.Next(0, 10)),
        //        Id = int.Parse(id),
        //        Material = rng.Next(0, 4),
        //        SectionCategory = "Prosth",
        //        State = "Draft",
        //        Surface = rng.Next(0, 8),
        //        ToothNumber = rng.Next(0, 34),
        //        UploadedBy = "Me",
        //    };
        //}

        public async Task<Model.CalibrationCase[]> GetCalibrationsAsync(DateTime startDate)
        {
            Console.WriteLine(httpClient.BaseAddress);
            return await this.httpClient.GetJsonAsync<CalibrationCase[]>($"CalibrationCase");
        }
    }
}
