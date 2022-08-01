using Domain.Entity;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class MemberServices : IMemberServices
    {
        private readonly IMemberRepository _memberRepository;
        public MemberServices(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public Member GetByName(string name)
        {
            try
            {
                return _memberRepository.GetByName(name);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
