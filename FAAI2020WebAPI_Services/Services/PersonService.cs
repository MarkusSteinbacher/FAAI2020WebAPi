namespace FAAI2020WebAPI_Services
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_Services.Dto;
    using FAAI2020WebAPI_Services.Services;
    using System;
    using System.Collections.Generic;

    public class PersonService : IPersonService
    {
        private readonly IPersistentContactContract _PresitentWriteContract;

        public PersonService(IPersistentContactContract presitentWriteContract)
        {
            this._PresitentWriteContract = presitentWriteContract;
        }

        public void WriteLineItems(PersonDto person)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PersonDto> GetPersons()
        {
            //this._PresitentWriteContract.ReadPersons();
            return null;
        }

        IEnumerable<PersonDto> IPersonService.GetPersons()
        {
            //this._PresitentWriteContract.ReadPersons();
            return null;
        }
    }
}
