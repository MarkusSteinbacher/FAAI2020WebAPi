namespace FAAI2020WebAPI_Services
{
    using System.Collections.Generic;
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Contract.ServiceContract;

    public class PersonService : IPersonService
    {
        private readonly IPersistentContract _PersistentContract;

        public PersonService(IPersistentContract persistentContract)
        {
            this._PersistentContract = persistentContract;
        }

        public IEnumerable<IPerson> GetPersons()
        {
            return (IEnumerable<IPerson>)this._PersistentContract.Read();
        }
    }
}
