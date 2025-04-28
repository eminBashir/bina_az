using BusinessLayer.DTO.StatusDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IStatusService
    {
        Task Create (StatusDTO statusDTO);
        Task<StatusDTO> GetById (int id);
        Task <List<StatusDTO>> GetAll ();
        Task Update(StatusDTO statusDTO, int id);
        Task Delete (int id);
    }
}
