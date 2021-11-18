namespace FAAI2020WebAPI_PersistentFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_PresistentFile;

    public class LineItemFileHandler : BaseFileHandler<LineItem>, IPresistentLineItemContract
	{
        public LineItemFileHandler() 
            : base(typeof(LineItem))
        {
        }

        protected override string FileName => "LineItems.txt";
 
        public IEnumerable<LineItem> ReadLineItems()
        {
            return this.Read();
        }

        public LineItem ReadLineItem(string id)
        {
            return this.Read().FirstOrDefault(f => f.ArticleId == id);
        }

        public LineItem ReadLineItem(Func<LineItem, bool> func)
        {
            return this.Read().FirstOrDefault(func);
        }

        public void WriteLineItem(LineItem lineItem)
        {
            this.Write(lineItem);
        }

        public IEnumerable<LineItem> ReadLineItems(string orderID)
        {
            return this.Read().Where(w => w.OrderId == orderID);
        }
    }
}
