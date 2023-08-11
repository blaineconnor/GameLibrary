using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Domain.Common
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedDate { get; private set; }
        public DateTime? LastModifiedDate { get; private set; }
        public DateTime? DeletedDate { get; private set; }
        public AuditableEntity()
        {
            CreatedDate = DateTime.UtcNow;
        }
        public void Update()
        {
            LastModifiedDate = DateTime.UtcNow;
        }
        public void Delete()
        {
            DeletedDate = DateTime.UtcNow;
        }
    }
}
