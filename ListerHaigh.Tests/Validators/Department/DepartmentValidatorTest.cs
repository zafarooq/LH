using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListerHaigh.Models;
using ListerHaigh.Validators;
using FluentValidation.TestHelper;
namespace ListerHaigh.Tests.Validators.Department
{
    [TestClass]
    public class DepartmentValidatorTest
    {
        [TestMethod]
        public void test() 
        {
            DepartmentValidator validator = new DepartmentValidator();
            DepartmentModel model = new DepartmentModel(){Code=string.Empty};
            validator.TestValidate(model);
 
        } 
    }
}
