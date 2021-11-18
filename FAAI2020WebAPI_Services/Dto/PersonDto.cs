namespace FAAI2020WebAPI_Services.Dto
{
    using FAAI2020WebAPI_PresisentFile;
    using FileHelpers;
    using System;

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
