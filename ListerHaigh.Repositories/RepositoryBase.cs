using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListerHaigh.Data;
namespace ListerHaigh.Repositories
{
    public class RepositoryBase
    {
        internal ListerHaighEntites DataContext { get; private set; }
        public RepositoryBase(ListerHaighEntites context) 
        {
            this.DataContext = context;
        }
    }
}
