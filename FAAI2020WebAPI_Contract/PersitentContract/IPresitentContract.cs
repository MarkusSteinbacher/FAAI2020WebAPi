using System.Collections.Generic;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
    public interface IPresitentContract
    {
        void Write(IPresistentBase data);
        IEnumerable<IPerson> Read();
    }
}
