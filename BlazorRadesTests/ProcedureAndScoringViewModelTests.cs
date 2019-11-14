using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorRades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlazorRadesTests;

namespace BlazorRades.Tests
{
    [TestClass()]
    public class ProcedureAndScoringViewModelTests
    {
        enum Procedure
        {
            NotSelected,
            Acceptance,
            Prep,
            Finish
        }

        [TestMethod()]
        public async Task SaveBladeTest()
        {
            /// from here we could create functional tests that go all the way to DB
            /// Or inject Mocked services or repositories to unit test
            var sut = new ProcedureAndScoringViewModel(new CaseServices(new MockCaseRepositry()));
            sut.Procedure = (int)Procedure.Acceptance;

            await sut.SaveBladeAsync();
            Assert.AreEqual(true, sut.CaseServices.IAmWorking);
        }
    }
}