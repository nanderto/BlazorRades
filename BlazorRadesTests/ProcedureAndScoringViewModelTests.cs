using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorRades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            var sut = new ProcedureAndScoringViewModel(new CaseServices());
            sut.Procedure = (int)Procedure.Acceptance;

            await sut.SaveBladeAsync();
            Assert.AreEqual(3, sut.CaseServices.IAmWorking);
        }
    }
}