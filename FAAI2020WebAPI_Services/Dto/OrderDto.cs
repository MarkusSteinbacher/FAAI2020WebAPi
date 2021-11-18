namespace FAAI2020WebAPI_Services.Dto
{
    using FAAI2020WebAPI_PresistentFile;
    using System;

    public class OrderDto
    {
        public string DocumentId { get; set; }
        public string PersonId { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }

        internal Order ToOrder()
        {
            return new Order()
            {
                DocumentId = this.DocumentId,
                PersonId = this.PersonId,
                Subject = this.Subject,
                Date = this.Date
            };
        }
    }
}
