using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorRades.Pages
{
    public class DemoBladesModel : PageModel
    {
        public List<BladeInfo> Bladeinfos { get; set; }

        public void OnGet()
        {
            Bladeinfos = GetBlades();
        }

        public List<BladeInfo> GetBlades()
        {
            List<BladeInfo> blades = new List<BladeInfo>();
            blades.Add(new BladeInfo
            {
                Id = "blade1",
                Title = "this Is My Title",
                SubTitle = "this is the sub-title",
                HeaderButtons = HeaderButtons.Close,
                Icon = "🧪",
                IconPath = string.Empty,
                SaveButtonPath = string.Empty

            });

            return blades;
        }

        public string MessageText { get; set; }

        public void AddBlade()
        {
            MessageText = "AddBlade was clicked";
            Bladeinfos = GetBlades();
            
        }
    }
}