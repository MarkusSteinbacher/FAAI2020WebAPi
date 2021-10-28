namespace FAAI2020WebAPI_PersistentFile
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Model;
    using FileHelpers;
    using System;
    using System.Collections.Generic;

    public class OrderFileHandler : IPersistentOrderContract
    {
        public IEnumerable<IOrder> Read()
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(Order));
            var result = (IEnumerable<IOrder>)fileHelperEngine
                .ReadFile(@$"C:\Users\Markus Steinbacher\Desktop\FileHelper\Orders.txt");
            return result;
        }

        public IOrder Read(string id)
        {
            throw new NotImplementedException();
        }

        public void Write(IOrder order)
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(Order));
            fileHelperEngine.AppendToFile(@$"C:\Users\Markus Steinbacher\Desktop\FileHelper\Orders.txt",
                new List<IOrder>() { order });
        }
    }
}
