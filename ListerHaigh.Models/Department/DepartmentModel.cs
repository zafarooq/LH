using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using ListerHaigh.Validators;
namespace ListerHaigh.Models
{
    [Validator(typeof(DepartmentValidator))]
    public class DepartmentModel: BaseViewModel
    {
        public int DepartmentId { get; set; }

        public string  Code { get; set; }

        public string  Name { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }

        public string Status { get; set; }
    }
}
