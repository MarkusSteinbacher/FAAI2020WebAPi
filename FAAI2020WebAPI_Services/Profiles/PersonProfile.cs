namespace FAAI2020WebAPI_Services.Profiles
{
    using AutoMapper;
    using FAAI2020WebAPI_PresisentFile;
    using FAAI2020WebAPI_Services.Dto;

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonDto, Person>().ReverseMap();
        }
    }
}
