using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO.RegionDTO_s
{
    public class RegionCreateDTO
    {
        public string Name { get; set; } = string.Empty;
        public int CityId { get; set; }
    }
}
