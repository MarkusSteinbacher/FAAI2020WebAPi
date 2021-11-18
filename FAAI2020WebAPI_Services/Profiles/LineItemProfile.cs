namespace FAAI2020WebAPI_Services
{
    using AutoMapper;
    using FAAI2020WebAPI_PresistentFile;

    public class LineItemProfile : Profile
    {
        public LineItemProfile()
        {
            CreateMap<LineItemDto, LineItem>().ReverseMap();
        }
    }
}
