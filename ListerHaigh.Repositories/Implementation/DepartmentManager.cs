using System;
using System.Collections.Generic;
using System.Linq;
using ListerHaigh.Models;
using ListerHaigh.Data;
using AutoMapper;
using System.Linq.Expressions;
using System.Data.Entity;
namespace ListerHaigh.Repositories
{
    public class DepartmentManager : IDepartmentManager
    {


        public string GetNameSuggessions(string name)
        {
            throw new NotImplementedException();
        }

        public string GetCodeSuggessions(string code)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentModel> GetAll()
        {
            using (var db = new ListerHaighEntites())
            {
                var departments = db.Departments.ToList();
                return departments.Select(Mapper.Map<DepartmentModel>).ToList();
            }
        }

        public IEnumerable<DepartmentModel> Find(Expression<Func<DepartmentModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public DepartmentModel GetByCode(string code)
        {
            using (var db = new ListerHaighEntites())
            {
                var department = db.Departments.FirstOrDefault(x => x.Code.Trim() == code.Trim());
                return Mapper.Map(department, new DepartmentModel());
            }
        }

        public DepartmentModel GetByName(string name)
        {
            using (var db = new ListerHaighEntites())
            {
                var department = db.Departments.FirstOrDefault(x => x.Name.Trim() == name.Trim());
                return Mapper.Map(department, new DepartmentModel());
            }
        }

        public DepartmentModel GetById(int id)
        {
            using (var db = new ListerHaighEntites())
            {
                var department = db.Departments.FirstOrDefault(x => x.DepartmentId == id);
                return Mapper.Map(department, new DepartmentModel());
            }
        }

        public bool Add(DepartmentModel entity)
        {
            try
            {
                using (var db = new ListerHaighEntites())
                {
                    var department = Mapper.Map<Department>(entity);
                    db.Departments.Add(department);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("There is error saving department", ex);
            }
        }

        public bool Delete(DepartmentModel entity)
        {
            bool result = false;
            using (var db = new ListerHaighEntites())
            {
                var department = db.Departments.FirstOrDefault(x => x.DepartmentId == entity.DepartmentId);
                db.Entry<Department>(department).State = EntityState.Deleted;
                result = (db.SaveChanges() > 0 ? false : true);
            }

            return result;
        }

        public bool Update(DepartmentModel entity)
        {
            using (var db = new ListerHaighEntites())
            {
                var department = db.Departments.SingleOrDefault(x => x.DepartmentId == entity.DepartmentId);
                department = Mapper.Map(entity, department);
                db.Entry<Department>(department).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }
    }
}
