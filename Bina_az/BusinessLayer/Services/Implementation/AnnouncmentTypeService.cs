using AutoMapper;
using BusinessLayer.DTO.AnnouncTypeDTO_s;
using BusinessLayer.Services.Interfaces;
using RepositoryLayer.Interface;

namespace BusinessLayer.Services.Implementation
{
    public class AnnouncmentTypeService : IAnnouncmentTypeService
    {
        private readonly IAnnouncmentTypeRepository announcmentTyperepository;
        private readonly IMapper mapper;

        public AnnouncmentTypeService(IAnnouncmentTypeRepository announcmentTyperepository, IMapper mapper)
        {
            this.announcmentTyperepository = announcmentTyperepository;
            this.mapper = mapper;
        }
        public async Task<List<AnnouncmentTypeDTO>> GetAllAsync()
        {
            var types = await announcmentTyperepository.GetAll();
            var typeDto = mapper.Map<List<AnnouncmentTypeDTO>>(types);
            return typeDto;
        }

        public async Task<AnnouncmentTypeDTO> GetById(int id)
        {
            var entity = await announcmentTyperepository.GetById(id);

            if(entity == null)
            {
                throw new Exception("Announc type not found");
            }

            var typeDto = mapper.Map<AnnouncmentTypeDTO>(entity);
            return typeDto;
        }
    }
}
