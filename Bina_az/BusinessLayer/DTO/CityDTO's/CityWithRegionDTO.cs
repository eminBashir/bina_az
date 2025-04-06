using BusinessLayer.DTO.RegionDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO.CityDTO_s
{
    public class CityWithRegionDTO
    {
        public string Name { get; set; }

        public List<RegionDTO> Regions { get; set; }
    }
}
