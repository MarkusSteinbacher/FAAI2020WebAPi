namespace FAAI2020WebAPI_Services.Profiles
{
    using AutoMapper;
    using FAAI2020WebAPI_PresistentFile;
    using FAAI2020WebAPI_Services.Dto;

    class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
        }
    }
    
}
