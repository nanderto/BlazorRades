using FluentValidation;
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
        public ProcedureAndScoringViewModel()
        {
        }

        public async Task SaveBladeAsync()
        {
            await this.CaseServices.SaveAsync(this);
        }

        public ProcedureAndScoringViewModel(ICaseServices caseServices)
        {
            CaseServices = caseServices;
            //this.SaveCommand = new Command(Save);
        }
    }

    public class ProcedureAndScoringViewModelValidator : AbstractValidator<ProcedureAndScoringViewModel>
    {
        public ProcedureAndScoringViewModelValidator()
        {
            RuleFor(p => p.Procedure).InclusiveBetween(1, 3).WithMessage("You must choose a Procedure Category");
            
            RuleFor(p => p.OutlineandExtension).InclusiveBetween(1, 5).When(p => p.Procedure == 2).WithMessage("You must provide a rating for Outline and Extension");
            RuleFor(p => p.InternalForm).InclusiveBetween(1, 5).When(p => p.Procedure == 2).WithMessage("You must provide a rating fo Internal Form");
            RuleFor(p => p.OperativeEnvironment).InclusiveBetween(1, 5).When(p => p.Procedure == 2).WithMessage("You must provide a rating for Operative Environment");
            RuleFor(p => p.AnatomicalForm).InclusiveBetween(1, 5).When(p => p.Procedure == 3).WithMessage("You must provide a rating for Anatomical Form");
            RuleFor(p => p.Margins).InclusiveBetween(1, 5).When(p => p.Procedure == 3).WithMessage("You must provide a rating for Margins");
            RuleFor(p => p.Finish).InclusiveBetween(1, 5).When(p => p.Procedure == 3).WithMessage("You must provide a rating for Finish");
        }
    }



}
