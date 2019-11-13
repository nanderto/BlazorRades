using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRades
{
    public interface ICaseServices
    {
        int IAmWorking { get; set; }
    }

    public class CaseServices : ICaseServices
    {
        public int IAmWorking { get; set; } = 3;
    }
}
