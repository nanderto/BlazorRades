using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRades
{
    public interface IProcedureAndScoringViewModel
    {
        int Procedure { get; set; }
    }

    public class ProcedureAndScoringViewModel : IProcedureAndScoringViewModel
    {
        public int Procedure { get; set; }
    }
}
