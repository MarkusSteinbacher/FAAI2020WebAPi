namespace FAAI2020WebAPI_Contract.PersitentContract
{
    using System.Collections.Generic;

    public interface IPersistentContract
    {
        void Write(IPersistentBase data);

        IEnumerable<IPersistentBase> Read();
    }
}
