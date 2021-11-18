namespace FAAI2020WebAPI_PresisentFile
{
    using FileHelpers;
    using System;

    [DelimitedRecord(";")]
    public class Person 
    {
		public string PersonId { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime DayOfBirth { get; set; }
    }
}
