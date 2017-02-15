using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ListerHaigh.Data;
using ListerHaigh.Models;
using AutoMapper;
namespace ListerHaigh.Repositories
{
    public class EventManager: IEventManager
    {

        public string GetNameSuggessions(string name)
        {
            throw new NotImplementedException();
        }

        public string GetCodeSuggessions(string code)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.EventModel> Find(Expression<Func<EventModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Models.EventModel GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Models.EventModel GetByName(string name)
        {
            throw new NotImplementedException();
        }
        
        public EventModel GetById(int id)
        {
            using (var db = new ListerHaighEntites())
            {
                var objEvent = db.Events.Where(x=>x.EventId == id);
                return Mapper.Map(objEvent, new EventModel());
            }
        }

        public bool Add(Models.EventModel entity)
        { 
            throw new NotImplementedException();
        }

        public bool Delete(Models.EventModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.EventModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
