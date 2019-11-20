using BlazorRadesWeb.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRadesWeb.Model;

namespace BlazorRadesWeb.Pages
{
    public class CalibrationCaseBase : ComponentBase
    {
        [Inject] ICalibrationCaseService CalibrationCaseService { get; set; }

        public Model.CalibrationCase CalibrationCase { get; set; }

        public int Procedure { get; set; }

        [Parameter] public List<BlazorRades.BladeInfo> BladeInfos { get; set; }

        [Parameter] public Type Type { get; set; }

        [Parameter] public int Order { get; set; }

        [Parameter] public string Id { get; set; }

        [Parameter] public string Icon { get; set; }

        [Parameter] public string IconPath { get; set; }

        [Parameter] public string Title { get; set; } = "Calibration Case";

        [Parameter] public string SubTitle { get; set; }

        [Parameter] public BlazorRades.HeaderButtons HeaderButtons { get; set; }

        [Parameter] public RenderFragment TopCommandBars { get; set; }

        [Parameter] public RenderFragment BottomCommandBars { get; set; }

        [Parameter] public string SaveButtonPath { get; set; }

        [Parameter] public string CloseButtonPath { get; set; }

        [Parameter] public EventCallback<string> AddBlade { get; set; }

        [Parameter] public EventCallback<Tuple<Type, string>> AddBladeWithId { get; set; }

        [Parameter] public EventCallback<string> SaveBlade { get; set; }

        [Parameter] public EventCallback<string> ReFreshRequested { get; set; }

        [Parameter] public EventCallback<string> DeleteThisBlade { get; set; }

        [Parameter] public string CaseId { get; set; }

        protected override async Task OnInitializedAsync()
        {

            Console.WriteLine($"OnInitializedAsync is being called for CalibrationCasesList Blade ID: {this.Id}");
            System.Diagnostics.Debug.Print($"OnInitializedAsync is being called for CalibrationCasesList Blade ID: {this.Id}");

            CalibrationCase = this.CalibrationCaseService.GetCalibrationCaseAsync(this.CaseId);
             
        }
    }
}
