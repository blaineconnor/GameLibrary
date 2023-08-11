using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Application.Models.DTOs
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string Publisher { get; set; }
        public string ImageLink { get; set; }
    }
}
