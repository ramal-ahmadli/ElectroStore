namespace ElectroStore.Business.Abstarct
{
    public interface IBaseService<ResponsiveDTO, T, RequestDTO>
    {
        List<ResponsiveDTO> GetAll();
        ResponsiveDTO Insert(RequestDTO dto);
        void Update(RequestDTO dto);
        void Delete(int id);
        ResponsiveDTO GetById(int id);
    }
}
