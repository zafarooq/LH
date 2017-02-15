using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListerHaigh.Repositories;
using ListerHaigh.Common;
namespace ListerHaigh.Tests.Repositories
{
    [TestClass]
    public class Department
    {
        private readonly IDepartmentManager _departmentManager;
        public Department() 
        {
            AutoMapperHelper.RegisterMappers();
            _departmentManager = new DepartmentManager();
        }
        [TestMethod]
        public void GetDepartmentById()
        {
            var department = _departmentManager.
            Assert.IsNotNull(department.Code);
        }
        [TestMethod]
        public void GetAllDepartments() 
        {
            var deprtments = _departmentManager.GetAll();
            foreach (var item in deprtments)
            {
                Console.WriteLine("CODE:" + item.Code);
            }
        }

    }
}
