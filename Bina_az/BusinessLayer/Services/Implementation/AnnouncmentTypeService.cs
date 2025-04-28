using AutoMapper;
using BusinessLayer.DTO.AnnouncTypeDTO_s;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
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

        public async Task Create(AnnouncmentTypeDTO ancmntTypDto)
        {
            var ancmType = mapper.Map<AnnouncmentType>(ancmntTypDto);
            await announcmentTyperepository.Create(ancmType);
            _ = await announcmentTyperepository.Save();
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

            if (entity == null)
            {
                throw new Exception("Announc type not found");
            }

            var typeDto = mapper.Map<AnnouncmentTypeDTO>(entity);
            return typeDto;
        }

        public async Task Update(AnnouncmentTypeDTO announcmentTypeDTO, int id)
        {
            var ancmType = await announcmentTyperepository.GetById(id);

            if (ancmType == null)
            {
                throw new Exception("Type not found");
            }

            mapper.Map(announcmentTypeDTO, ancmType);
            await announcmentTyperepository.Update(ancmType, id);
            await announcmentTyperepository.Save();
        }

        public async Task Delete(int id)
        {
            var ancmnType = await announcmentTyperepository.GetById(id);

            if(ancmnType == null)
            {
                throw new Exception("Type not found");
            }
            await announcmentTyperepository.Delete(ancmnType);
            await announcmentTyperepository.Save();
        }

    }
}
