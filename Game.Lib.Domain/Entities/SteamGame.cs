using Game.Lib.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Domain.Entities
{
    public class SteamGame : BaseEntity
    {
        public double Price { get;  set; }
        public double Discount { get;  set; }
        public string Publisher { get; set; }
        public string ImageLink { get; set; }

       
    }
}
