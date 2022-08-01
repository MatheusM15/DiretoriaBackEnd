using Domain.Entity;
using Domain.Entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class DiretoriaContext : IdentityDbContext<User, Roles, Guid, IdentityUserClaim<Guid>, UserRoles, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DiretoriaContext(DbContextOptions<DiretoriaContext> options) : base(options){}
        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<Sister> Sisters { get; set; }
        public DbSet<Member> Members{ get; set; }
    }

}
