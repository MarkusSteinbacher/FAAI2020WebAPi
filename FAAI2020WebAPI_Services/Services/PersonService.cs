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
        private readonly IPersistentContactContract _PresitentContactContract;
        private readonly IMapper _mapper;

        public PersonService(IPersistentContactContract presitentContactContract, IMapper mapper)
        {
            this._PresitentContactContract = presitentContactContract;
            this._mapper = mapper;
        }

        public void WritePerson(PersonDto personDto)
        { 
            var result = this._mapper.Map<Person>(personDto);
            this._PresitentContactContract.WritePerson(result);
        }

        public IEnumerable<PersonDto> GetPersons()
        {
            var persons = this._PresitentContactContract.ReadPersons();
            return this._mapper.Map<IEnumerable<PersonDto>>(persons);
        }
    }
}
