using FAAI2020WebAPI_Contract.PersitentContract;
using FileHelpers;
using System;

namespace FAAI2020WebAPI_Model
{
    [DelimitedRecord(";")]
    public class Person : IPerson
    {
		public string PersonId { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime DayOfBirth { get; set; }
    }
}
