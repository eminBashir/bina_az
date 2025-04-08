using BusinessLayer.DTO.SettlementDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO.RegionDTO_s
{
    public class RegionSettlementsDTO
    {
        public string Name { get; set; } = string.Empty;
        public List<SettlementDTO> Settlements { get; set; }
    }
}
