namespace FAAI2020WebAPI_Services
{
    using AutoMapper;
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_Services.Dto;
    using FAAI2020WebAPI_Services.Services;
    using System;
    using System.Collections.Generic;

    public class PersonService : IPersonService
    {
        private readonly IPersistentContactContract _PersistentContactContract;
        private readonly IMapper _Mapper;

        public PersonService(IPersistentContactContract presitentWriteContract, IMapper mapper)
        {
            this._PersistentContactContract = presitentWriteContract;
            this._Mapper = mapper;
        }

        public void WriteLineItems(PersonDto person)
        {
            throw new NotImplementedException();
        }

       public IEnumerable<PersonDto> GetPersons()
        {
            var persons = this._PersistentContactContract.ReadPersons();
            return this._Mapper.Map<IEnumerable<PersonDto>>(persons);
        }
    }
}
