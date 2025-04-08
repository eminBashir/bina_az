using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO.SettlementDTO_s
{
    public class SettlementCreateDTO
    {
        public string Name { get; set; } = string.Empty;
        public int RegionId { get; set; }
    }
}
