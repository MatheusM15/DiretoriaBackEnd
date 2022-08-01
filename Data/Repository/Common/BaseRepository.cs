using Domain.Entity.Common;
using Domain.Interfaces.Repository.Common;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private DiretoriaContext _db { get; set; }
        public  DbSet<T> _dbSet { get; set; }
        public BaseRepository(DiretoriaContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet.AsNoTracking();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
