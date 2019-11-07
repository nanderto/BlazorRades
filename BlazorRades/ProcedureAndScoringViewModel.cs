using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlazorRades
{
    //class Command : ICommand
    //{
    //    public event EventHandler CanExecuteChanged;

    //    private Action action;

    //    public Command(Action action)
    //    {
    //        this.action = action;
    //    }

    //    public bool CanExecute(object parameter)
    //    {
    //        return true;
    //    }

    //    public void Execute(object parameter)
    //    {
    //        action.Invoke();
    //    }
    //}

    public interface IProcedureAndScoringViewModel
    {
        void SaveBlade();

        int Procedure { get; set; }
    }

    public class ProcedureAndScoringViewModel : IProcedureAndScoringViewModel, INotifyPropertyChanged
    {
        [BindProperty]
        public int Procedure { get; set; }
        
        public ICaseServices CaseServices { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        //public ICommand SaveCommand { get; set; }

        public void SaveBlade()
        {
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
