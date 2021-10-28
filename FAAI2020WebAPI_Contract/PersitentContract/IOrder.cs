namespace FAAI2020WebAPI_Contract.PersitentContract
{
    using System;

    public interface IOrder
    {
         string DocumentId { get; set; }
         string PersonId { get; set; }
         string Subject { get; set; }
         DateTime Date { get; set; }
    }
}
