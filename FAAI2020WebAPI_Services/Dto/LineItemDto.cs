namespace FAAI2020WebAPI_Services
{
    using FAAI2020WebAPI_PresistentFile;

    public class LineItemDto
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
