namespace FAAI2020WebAPI_PresisentFile
{
    using FAAI2020WebAPI_PersistentFile.Models;
    using FileHelpers;
    using System;
    using System.Collections.Generic;

    [DelimitedRecord(";")]
    public class Person : BaseModel
    {
		public string FirstName { get; set; }
        public string LastName { get; set; }
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")]
        public DateTime DayOfBirth { get; set; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
