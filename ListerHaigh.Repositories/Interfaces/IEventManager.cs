using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListerHaigh.Models;
namespace ListerHaigh.Repositories
{
    public interface IEventManager : IBaseManager<EventModel>
    {
        string GetNameSuggessions(string name);
        string GetCodeSuggessions(string code);
    }
}
