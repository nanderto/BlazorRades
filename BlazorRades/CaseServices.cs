using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRades
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
        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
