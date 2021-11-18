namespace FAAI2020WebAPI_Services
{
    using AutoMapper;
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_PresisentFile;
    using FAAI2020WebAPI_Services.Dto;
    using FAAI2020WebAPI_Services.Services;
    using System;
    using System.Collections.Generic;

    public class PersonService : IPersonService
    {
        private readonly IPersistentContactContract _PersistentContactContract;
        private readonly IMapper _Mapper;

        public PersonService(IPersistentContactContract presitentContactContract, IMapper mapper)
        {
            this._PersistentContactContract = presitentWriteContract;
            this._Mapper = mapper;
        }

        public void WritePerson(PersonDto personDto)
        { 
            var result = this._mapper.Map<Person>(personDto);
            this._PresitentContactContract.WritePerson(result);
        }

        public IEnumerable<PersonDto> GetPersons()
        {
            var persons = this._PersistentContactContract.ReadPersons();
            return this._Mapper.Map<IEnumerable<PersonDto>>(persons);
        }
    }
}
