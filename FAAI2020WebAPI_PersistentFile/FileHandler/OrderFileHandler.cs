using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_PersistentFile.PresistentContracts;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_PersistentFile
{
    public class OrderFileHandler : BaseFileHandler<IOrder>, IPersistentOrderContract
    {
        protected override string FileName => "Ordes.txt";

        public OrderFileHandler() : base(typeof(IOrder))
        {
        }

        public IEnumerable<IOrder> ReadOrders()
        {
            return this.Read();
        }

        public IOrder ReadOrder(Func<IOrder, bool> func)
        {
            return this.Read().FirstOrDefault(func);
        }

        public void WriteOrder(IOrder order)
        {
            this.Write(order);
        }
    }


}