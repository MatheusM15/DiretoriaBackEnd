using Domain.Entity.Identity;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SisterServices : ISisterServices
    {
        private readonly ISisterRepository _sisterRepository;
        public SisterServices(ISisterRepository sisterRepository)
        {
            _sisterRepository = sisterRepository;
        }
        public IEnumerable<Sister> GetAll()
        {
            try
            {
                return _sisterRepository.GetAll();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Sister GetByName(string name)
        {
            try
            {
                return _sisterRepository.GetByName(name);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
