using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_Contract.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services
{
	public class LineItemService : ILineItemService
	{
		private readonly IPresistentLineItemContract presistentLineItemContract;

		public LineItemService(IPresistentLineItemContract presistentLineItemContract)
		{
			this.presistentLineItemContract = presistentLineItemContract;
		}

		public IQueryable<ILineItem> GetLineItems()
		{
			return this.presistentLineItemContract.Read().AsQueryable();
		}

		public void WriteLineItems(ILineItem lineItem)
		{
			this.presistentLineItemContract.Write(lineItem);
		}
	}
}
