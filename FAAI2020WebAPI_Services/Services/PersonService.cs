namespace FAAI2020WebAPI_Services
{
    using AutoMapper;
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_PresisentFile;
    using FAAI2020WebAPI_PresistentFile;
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

        public PersonDto GetAllOrdersPerson(string personId)
        {
            var person = this.GetPerson(personId);
            var tempList = new List<OrderDto>();
            var orders = this._OrderContract.ReadOrders().Where(w => w.PersonId == personId);
            foreach (var order in orders)
            {
                var orderDto = this._Mapper.Map<OrderDto>(order);
                var lineItems = this._LineItemContract.ReadLineItems(order.Id).ToList();
                orderDto.LineItems = this._Mapper.Map<List<LineItemDto>>(lineItems);
                tempList.Add(orderDto);
            }
            person.Orders = tempList;
            return person;
        }

        public PersonDto GetPerson(string personId)
        {
            var person = this._PersistentContactContract.ReadPersons().FirstOrDefault(w => w.Id == personId);
            return this._Mapper.Map<PersonDto>(person);
        }

        public void WriteWholeOrder(PersonDto person)
        {
            var result = this._Mapper.Map<Person>(person);
            this.WritePerson(person);
            foreach (var order in person.Orders)
            {
                this._OrderContract.WriteOrder(this._Mapper.Map<Order>(order));
                foreach (var lineItem in order.LineItems)
                {
                    this._LineItemContract.WriteLineItem(this._Mapper.Map<LineItem>(lineItem));
                }
            }
        }

        public void DeletePerson(PersonDto person)
        {
            var result = this._Mapper.Map<Person>(person);
            this._PersistentContactContract.DeletePerson(result);
        }

        
    }
}
