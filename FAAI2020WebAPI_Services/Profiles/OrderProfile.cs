using AutoMapper;
using FAAI2020WebAPI_PresistentFile;
using FAAI2020WebAPI_Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services.Profiles
{
    class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
        }
    }
    
}
