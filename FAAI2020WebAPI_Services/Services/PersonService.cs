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
    using System.Linq;

    public class PersonService : IPersonService
    {
        private readonly IPersistentContactContract _PersistentContactContract;
        private readonly IMapper _Mapper;
        private readonly IPersistentOrderContract _OrderContract;
        private readonly IPresistentLineItemContract _LineItemContract;

        public PersonService(IPersistentContactContract presitentContactContract, IPersistentOrderContract persistentOrderContract, IPresistentLineItemContract presistentLineItemContract ,IMapper mapper)
        {
            this._PersistentContactContract = presitentContactContract;
            this._Mapper = mapper;
            this._OrderContract = persistentOrderContract;
            this._LineItemContract = presistentLineItemContract;
        }

        public void WritePerson(PersonDto personDto)
        { 
            var result = this._Mapper.Map<Person>(personDto);
            this._PersistentContactContract.WritePerson(result);
        }

        public IEnumerable<PersonDto> GetPersons()
        {
            var persons = this._PersistentContactContract.ReadPersons();
            return this._Mapper.Map<IEnumerable<PersonDto>>(persons);
        }

        public IEnumerable<OrderDto> GetAllOrdersPerson(string personId)
        {
            var tempList = new List<OrderDto>();
            var orders = this._OrderContract.ReadOrders().Where(w => w.PersonId == personId);
            foreach (var order in orders)
            {
                var orderDto = this._Mapper.Map<OrderDto>(order);
                var lineItems = this._LineItemContract.ReadLineItems(order.DocumentId).ToList();
                orderDto.LineItems = this._Mapper.Map<List<LineItemDto>>(lineItems);
                tempList.Add(orderDto);
            }
            return tempList;
        }
    }
}
