using Domain.Entity.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ISisterServices
    {
        IEnumerable<Sister> GetAll();
        Sister GetByName(string name);
    }
}
