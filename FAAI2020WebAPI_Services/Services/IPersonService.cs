﻿using FAAI2020WebAPI_Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services.Services
{
    public interface IPersonService
    {
        IQueryable<PersonDto> GetPersons();
        void WriteLineItems(PersonDto person);
    }
}
