using System;
using System.Collections.Generic;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
    public interface IPresitentContract
    {
        void WritePerson(IPerson person);
        IEnumerable<IPerson> ReadPersons();
        IPerson ReadPerson(Func<IPerson, bool> func);
    }
}
