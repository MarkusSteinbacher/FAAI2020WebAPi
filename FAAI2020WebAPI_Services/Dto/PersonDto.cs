using FAAI2020WebAPI_PresisentFile;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services.Dto
{
    public class PersonDto
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime DayOfBirth { get; set; }

        internal Person ToPerson()
        {
            return new Person()
            {
                PersonId = this.PersonId,
                FirstName = this.FirstName,
                LastName = this.LastName,
                DayOfBirth = this.DayOfBirth
            };
        }
    }
}
