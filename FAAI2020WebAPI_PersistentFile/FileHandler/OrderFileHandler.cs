namespace FAAI2020WebAPI_PersistentFile
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_PresistentFile;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderFileHandler : BaseFileHandler<Order>, IPersistentOrderContract
    {
        protected override string FileName => "Ordes.txt";

        public OrderFileHandler() : base(typeof(Order))
        {
        }

        public IEnumerable<Order> ReadOrders()
        {
            return this.Read();
        }

        public Order ReadOrder(Func<Order, bool> func)
        {
            return this.Read().FirstOrDefault(func);
        }

        public void WriteOrder(Order order)
        {
            this.Write(order);
        }
    }
}