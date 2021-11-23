namespace FAAI2020WebAPI_Services.Services
{
    using FAAI2020WebAPI_Services.Dto;
    using System.Collections.Generic;

    public interface IPersonService
    {
        public IEnumerable<PersonDto> GetPersons();
        public void WritePerson(PersonDto personDto);
        public PersonDto GetAllOrdersPerson(string personId);
        public PersonDto GetPerson(string personId);
        public void WriteWholeOrder(PersonDto person);
        public void DeletePerson(PersonDto person);
    }
}
