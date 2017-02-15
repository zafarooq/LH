using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ListerHaigh.Models;
using ListerHaigh.Data;
namespace ListerHaigh.Common
{
    internal class EntityToModelProfile: Profile
    {
        public EntityToModelProfile()
        {
            CreateMap<DepartmentModel, Department>().
                AfterMap((source, dest) => {
                    source.Status = (dest.Enabled ? "Enabled" : "Disable");
                });
            CreateMap<Department, DepartmentModel>();
        }
    }

}
