using AutoMapper;
using ElectroStore.Business.Abstarct;
using ElectroStore.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace ElectroStore.Business.Concrete
{
    public class BaseService<ResponsiveDTO, T, RequestDTO> : IBaseService<ResponsiveDTO, T, RequestDTO> where T : class
    {
        public readonly IMapper _mapper;
        public readonly AppDbContext _dbContext;
        public readonly DbSet<T> _dbSet;

        public BaseService(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<ResponsiveDTO> GetAll()
        {
            var entity = _dbSet.ToList();
            var responsiveDto = _mapper.Map<List<ResponsiveDTO>>(entity);
            return responsiveDto;
        }

		public ResponsiveDTO GetById(int id)
		{
			var entity = _dbSet.Find(id);
			var responsiveDto = _mapper.Map<ResponsiveDTO>(entity);
			return responsiveDto;
		}

		public ResponsiveDTO Insert(RequestDTO dto)
        {
            var entity = _mapper.Map<T>(dto);
            _dbSet.Add(entity);
            _dbContext.SaveChanges();

            var responsiveDto = _mapper.Map<ResponsiveDTO>(entity);
            return responsiveDto;
        }

        public void Update(RequestDTO dto)
        {
            var entity = _mapper.Map<T>(dto);
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
