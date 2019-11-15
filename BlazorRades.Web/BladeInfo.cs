using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRades.Web
{
    public enum HeaderButtons
    {
        Close,
        SaveAndClose,
        SaveCloseAndAdd,
    }
    public class BladeInfo
    {
        public int Order { get; set; }
        public string Id { get; set; }

        public Type Type { get; set; }

        public string Icon { get; set; }

        public string IconPath { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public HeaderButtons HeaderButtons { get; set; }

        public string SaveButtonPath { get; set; }

        public RenderFragment CommandBars { get; set; }

        public RenderFragment Content { get; set; }
    }
}
