using FAAI2020WebAPI_Contract.PersitentContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_PersistentFile
{
    public class PersonFileHandler : BaseFileHandler<IPerson>, IPresitentContract
    {
        protected override string FileName => "Ordes.txt";

        public PersonFileHandler() : base(typeof(IPerson))
        {
        }

        public IEnumerable<IPerson> ReadPersons()
        {
            return this.Read();
        }

        public IPerson ReadPerson(Func<IPerson, bool> func)
        {
            return this.Read().FirstOrDefault(func);
        }

        public void WritePerson(IPerson person)
        {
            this.Write(person);
        }
    }



}
