﻿namespace FAAI2020WebAPI_Services.Dto
{
    using FAAI2020WebAPI_PresisentFile;
    using FileHelpers;
    using System;
    using System.Collections.Generic;

    public class PersonDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime DayOfBirth { get; set; }
        public List<OrderDto> Orders { get; set; }

        internal Person ToPerson()
        {
            return new Person()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                DayOfBirth = this.DayOfBirth
            };
        }
    }
}
