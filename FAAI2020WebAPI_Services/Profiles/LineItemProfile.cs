using AutoMapper;
using FAAI2020WebAPI_Model;
using FAAI2020WebAPI_PresistentFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services
{
    public class LineItemProfile : Profile
    {
        public LineItemProfile()
        {
            CreateMap<LineItemDto, LineItem>().ReverseMap();
        }
    }
}
