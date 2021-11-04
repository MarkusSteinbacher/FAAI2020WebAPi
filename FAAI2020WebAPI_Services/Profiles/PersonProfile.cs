using AutoMapper;
using FAAI2020WebAPI_PresisentFile;
using FAAI2020WebAPI_Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonDto, Person>().ReverseMap();
        }
    }
}
