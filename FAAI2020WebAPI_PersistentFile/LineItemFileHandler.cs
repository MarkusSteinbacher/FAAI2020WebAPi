using FAAI2020WebAPI_Contract.PersitentContract;
using System.Collections.Generic;
using System.Linq;

namespace FAAI2020WebAPI_PersistentFile
{
	public class LineItemFileHandler : BaseFileHandler<ILineItem> ,IPresistentLineItemContract
	{
        public LineItemFileHandler() : base(typeof(ILineItem))
        {
        }

        protected override string FileName => "LineItems.txt";

        public IEnumerable<ILineItem> ReadLineItems()
        {
            return this.Read();
        }

        public ILineItem ReadLineItem(string id)
        {
            return this.Read().FirstOrDefault(f => f.ArticleId == id);
        }

        public void WriteLineItem(ILineItem lineItem)
        {
            this.Write(lineItem);
        }
    }
}
