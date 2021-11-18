namespace FAAI2020WebAPI_PersistentFile.PresistentContracts
{
    using FAAI2020WebAPI_PresisentFile;
    using System;
    using System.Collections.Generic;

    public interface IPersistentContactContract
    {
        public void WritePerson(Person person);
        public IEnumerable<Person> ReadPersons();
        public Person ReadPerson(Func<Person, bool> func);
    }
}
