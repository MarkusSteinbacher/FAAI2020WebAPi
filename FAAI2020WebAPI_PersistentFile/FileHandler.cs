namespace FAAI2020WebAPI_PersistentFile
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Model;
    using FileHelpers;
    using System;
    using System.Collections.Generic;

    public class FileHandler : IPersistentContract
    {

        public FileHandler()
        {
        }

        public IEnumerable<IPersistentBase> Read()
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(Person));       
            var result = (IEnumerable<IPerson>)fileHelperEngine
                .ReadFile(@$"C:\Users\Markus Steinbacher\Desktop\FileHelper\Persons.txt");
            return result;
        }

        public void Write(IPersistentBase data)
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(IPersistentBase));
            fileHelperEngine.WriteFile(@$"C:\Users\Markus Steinbacher\Desktop\FileHelper\
                    {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}
                    Person.txt", new List<IPersistentBase>() { data });

            //fileHelperEngine.AppendToFile(@$"C:\Users\Markus Steinbacher\Desktop\FileHelper\
            //        {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}
            //        Person.txt", new List<IPPersitentBase>() { data });
        }
    }
}
