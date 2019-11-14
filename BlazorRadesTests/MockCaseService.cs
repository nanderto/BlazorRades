using BlazorRades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRadesTests
{
    public class MockCaseService : ICaseServices
    {
        public bool IAmWorking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(IProcedureAndScoringViewModel procedureAndScoringViewModel)
        {
            throw new NotImplementedException();
        }
    }

    public class MockCaseRepositry : ICaseRepository
    {

        public async Task SaveAsync()
        {
            ///do nothing
        }
    }
}
