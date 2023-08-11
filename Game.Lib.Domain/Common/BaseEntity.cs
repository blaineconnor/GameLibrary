using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }



        #region Varlıkların Id'ye göre eşit olup olmadığının kontrolleri

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseEntity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            BaseEntity item = (BaseEntity)obj;

            return item.Id == this.Id;
        }
        #endregion



        #region Varlıklara ID'ye göre karmaşık kod üreten metot
        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
        #endregion
    }
}
