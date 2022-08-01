using Domain.Entity;
using Domain.Interfaces.Repository;
using Infra.Context;
using Infra.Repository.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        public MemberRepository(DiretoriaContext context): base(context){}

        public Member GetByName(string name)
        {
            try
            {
                return _dbSet.AsNoTracking().Include(d => d.Foto).FirstOrDefault(d => d.Name.Contains(name));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
