namespace FAAI2020WebAPI_Contract.PersitentContract
{
    using System.Collections.Generic;
     //https://github.com/MarkusSteinbacher/FAAI2020WebAPi

    public interface IPersistentOrderContract 
    {
        IEnumerable<IOrder> Read();

        IOrder Read(string id);

        void Write(IOrder data);       
    }
}
