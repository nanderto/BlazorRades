using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorRades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorRades.Tests
{
    [TestClass()]
    public class ProcedureAndScoringViewModelTests
    {
        [TestMethod()]
        public void SaveBladeTest()
        {
            var sut = new ProcedureAndScoringViewModel(new CaseServices());
            sut.SaveBlade();
            Assert.AreEqual(3, sut.CaseServices.IAmWorking);
        }
    }
}