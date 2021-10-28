namespace FAAI2020WebAPI_Model
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FileHelpers;
    using System;

    [DelimitedRecord(";")]
    public class Order : IOrder
    {
        public string DocumentId { get; set; }

        public string PersonId { get; set; }

        public string Subject { get; set; }

        public DateTime Date { get; set; }
    }
}
