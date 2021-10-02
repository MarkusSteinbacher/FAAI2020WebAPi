namespace FAAI2020WebAPI_Contract.ServiceContract
{ 
    using FAAI2020WebAPI_Contract.PersitentContract;
    using System.Collections.Generic;

    public interface IPersonService
    {
        IEnumerable<IPerson> GetPersons();
    }
}
