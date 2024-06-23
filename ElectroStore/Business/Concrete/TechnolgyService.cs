using AutoMapper;
using ElectroStore.Business.Abstarct;
using ElectroStore.DTO;
using ElectroStore.Models;
using ElectroStore.Models.Context;

namespace ElectroStore.Business.Concrete
{
    public class TechnolgyService : BaseService<TechnolgyDTO, Technology, TechnolgyDTO>, ITechnolgyService
    {
        public TechnolgyService(IMapper mapper, AppDbContext dbContext) : base(mapper, dbContext)
        {
        }
    }
}
