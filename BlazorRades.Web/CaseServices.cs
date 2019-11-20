using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRadesWeb
{
    public interface ICaseServices
    {
        bool IAmWorking { get; set; }

        Task SaveAsync(IProcedureAndScoringViewModel procedureAndScoringViewModel);
    }

    public class CaseServices : ICaseServices
    {
        private readonly ICaseRepository repository;

        public CaseServices(ICaseRepository repository)
        {
            this.repository = repository;
        }

        public bool IAmWorking { get; set; } = false;

        public async Task SaveAsync(IProcedureAndScoringViewModel procedureAndScoringViewModel)
        {
            /// setup the repository with data from view model and save
            await this.repository.SaveAsync();
            IAmWorking = true;
        }
    }

    public interface ICaseRepository
    {
        Task SaveAsync();
    }

    public class CaseRepository : ICaseRepository
    {
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task SaveAsync()
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
            //throw new NotImplementedException();
        }
    }
}
