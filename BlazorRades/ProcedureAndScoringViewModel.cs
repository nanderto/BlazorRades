using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlazorRades
{
    public interface IProcedureAndScoringViewModel
    {
        Task SaveBladeAsync();

        [Required]
        int Procedure { get; set; }

        int OutlineandExtension { get; set; }

        int OperativeEnvironment { get; set; }

        int InternalForm { get; set; }

        int AnatomicalForm { get; set; }

        int Margins { get; set; }

        int Finish { get; set; }
    }

    public class ProcedureAndScoringViewModel : IProcedureAndScoringViewModel, INotifyPropertyChanged
    {
        [BindProperty]
        public int Procedure { get; set; }

        [BindProperty]
        public int OutlineandExtension { get; set; }

        public int OperativeEnvironment { get; set; }

        public int InternalForm { get; set; }

        public int AnatomicalForm { get; set; }

        public int Margins { get; set; }

        public int Finish { get; set; }

        public ICaseServices CaseServices { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        //public ICommand SaveCommand { get; set; }

        public async Task SaveBladeAsync()
        {
            if (Procedure == 0)
            {
                var pr = Procedure;
            }
            var o = CaseServices.IAmWorking;
            var a = Procedure;
        }

        public ProcedureAndScoringViewModel(ICaseServices caseServices)
        {
            CaseServices = caseServices;
            //this.SaveCommand = new Command(Save);
        }
    }
}
