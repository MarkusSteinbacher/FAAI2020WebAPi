namespace FAAI2020WebAPI_PersistentFile
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Model;
    using FileHelpers;
    using System;
    using System.Collections.Generic;

    public class FileHandler : IPresitentContract
    {
        public IEnumerable<IPerson> Read()
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(Person));
            var result = (IEnumerable<IPerson>)fileHelperEngine.ReadFile($@"C:\Users\Administrator\Desktop\FileHelper\Person.txt");
            return result;
        }

        public void Write(IPresistentBase data)
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(IPresistentBase));
            fileHelperEngine.WriteFile($@"C:\Users\Administrator\Desktop\FileHelper\
                                        { DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}Person.txt", new List<IPresistentBase>() { data });

            fileHelperEngine.AppendToFile($@"C:\Users\Administrator\Desktop\FileHelper\
                                        { DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}Person.txt", new List<IPresistentBase>() { data });
        }
    }
}
