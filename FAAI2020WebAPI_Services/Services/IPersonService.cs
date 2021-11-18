namespace FAAI2020WebAPI_Services.Services
{
    using FAAI2020WebAPI_Services.Dto;
    using System.Collections.Generic;

    public interface IPersonService
    {
        public IEnumerable<PersonDto> GetPersons();
        public void WritePerson(PersonDto personDto);
        public IEnumerable<OrderDto> GetAllOrdersPerson(string personId);
    }
}
