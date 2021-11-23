namespace FAAI2020WebAPI_PersistentFile
{
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_PresisentFile;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class PersonFileHandler : BaseFileHandler<Person>, IPersistentContactContract
    {
        protected override string FileName => "Persons.txt";

        public PersonFileHandler() : base(typeof(Person))
        {
        }

        public IEnumerable<Person> ReadPersons()
        {
            return this.Read();
        }

        public Person ReadPerson(Func<Person, bool> func)
        {
            return this.Read().FirstOrDefault(func);
        }

        public void WritePerson(Person person)
        {
            this.Write(person);
        }

        public void DeletePerson(Person person)
        {
            if (!this.TryDelete(person))
            {
                throw new FileNotFoundException();
            }
        }
    }
}