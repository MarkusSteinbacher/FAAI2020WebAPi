using FAAI2020WebAPI_PresistentFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services.Dto
{
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
