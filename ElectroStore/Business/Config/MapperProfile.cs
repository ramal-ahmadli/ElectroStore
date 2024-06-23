using AutoMapper;
using ElectroStore.DTO;
using ElectroStore.Models;

namespace ElectroStore.Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Technology, TechnolgyDTO>();
            CreateMap<TechnolgyDTO, Technology>();
        }
    }
}
