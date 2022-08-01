using Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Identity
{
    public class Sister : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Foto")]
        public Guid FotoId { get; set; }
        public virtual Arquivo Foto { get; set; }


    }
}
