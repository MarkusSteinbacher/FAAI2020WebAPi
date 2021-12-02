namespace FAAI2020WebAPI_Services
{
    using FAAI2020WebAPI_PresistentFile;
    using FAAI2020WebAPI_Services.Dto;

    public class LineItemDto : BaseDto
    {
        public string ArticleId { get; set; }
        public double Quantity { get; set; }
        public string Text { get; set; }

        internal LineItem ToLineItem()
        {
            return new LineItem()
            {
                ArticleId = this.ArticleId,
                Quantity = this.Quantity,
                Text = this.Text
            };
        }
    }
}
