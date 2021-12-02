namespace FAAI2020WebAPI_Services.Dto
{
    using FAAI2020WebAPI_PresistentFile;
    using System;
    using System.Collections.Generic;

    public class OrderDto : BaseDto
    {
        public string PersonId { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public List<LineItemDto> LineItems { get; set; }
    }
}
