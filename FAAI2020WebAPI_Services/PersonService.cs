using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_Contract.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services
{
    public class PersonService : IPersonService
    {
        private readonly IPresitentContract _PresitentWriteContract;

        public PersonService(IPresitentContract presitentWriteContract)
        {
            this._PresitentWriteContract = presitentWriteContract;
        }

        public IEnumerable<IPerson> GetPersons()
        {
            return this._PresitentWriteContract.Read();
        }
    }
}
