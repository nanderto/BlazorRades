using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorRades;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.TestHelper;

namespace BlazorRades.Tests
{
    [TestClass()]
    public class ProcedureAndScoringViewModelValidatorTests
    {
        private ProcedureAndScoringViewModelValidator validator;

        [TestInitialize()]
        public void Initialize()
        {
            validator = new ProcedureAndScoringViewModelValidator();
        }


        [TestMethod]
        public void Procedure_Should_have_error_when_value_not_between_1_and_3_inclusivend()
        {
            /// this is kind of trivial becasue there are only so many chouices a drop down can be
            /// but it is an example of validator testing
            validator.ShouldHaveValidationErrorFor(vm => vm.Procedure, 0);
            validator.ShouldHaveValidationErrorFor(vm => vm.Procedure, 4);
            validator.ShouldNotHaveValidationErrorFor(vm => vm.Procedure, 1);
            validator.ShouldNotHaveValidationErrorFor(vm => vm.Procedure, 2);
            validator.ShouldNotHaveValidationErrorFor(vm => vm.Procedure, 3);
        }


        [TestMethod]
        public void InternalForm()
        {
            var viewModel = new ProcedureAndScoringViewModel
            {
                Procedure = 2,
                InternalForm = 1,
            };

            var result = validator.TestValidate(viewModel);
            result.ShouldNotHaveValidationErrorFor(vm => vm.InternalForm);

            viewModel.InternalForm = 0;
            result = validator.TestValidate(viewModel);
            result.ShouldHaveValidationErrorFor(vm => vm.InternalForm);

            viewModel.InternalForm = 6;
            result = validator.TestValidate(viewModel);
            result.ShouldHaveValidationErrorFor(vm => vm.InternalForm);

            viewModel.InternalForm = 4;
            result = validator.TestValidate(viewModel);
            result.ShouldNotHaveValidationErrorFor(vm => vm.InternalForm);

            viewModel.Procedure = 1;
            viewModel.InternalForm = 0;
            result = validator.TestValidate(viewModel);
            result.ShouldNotHaveValidationErrorFor(vm => vm.InternalForm);
        }
    }
}