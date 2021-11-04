namespace FAAI2020WebAPI_PersistentFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FAAI2020WebAPI_Contract.PersitentContract;

    public class LineItemFileHandler : BaseFileHandler<ILineItem>, IPresistentLineItemContract
	{
        public LineItemFileHandler() 
            : base(typeof(ILineItem))
        {
        }

        protected override string FileName => "LineItems.txt";
 
        public IEnumerable<ILineItem> ReadLineItems()
        {
            return this.Read();
        }

        public ILineItem ReadLineItem(Func<ILineItem, bool> func)
        {
            return this.Read().FirstOrDefault(func);
        }

        public void WriteLineItem(ILineItem lineItem)
        {
            this.Write(lineItem);
        }
    }
}
