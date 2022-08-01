using Domain.Entity.Identity;
using Domain.Interfaces.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ISisterRepository :IBaseRepository<Sister>
    {
        Sister GetByName(string name);
    }
}
