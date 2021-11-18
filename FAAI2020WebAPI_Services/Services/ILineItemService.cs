namespace FAAI2020WebAPI_Services
{
    using System.Collections.Generic;
    using System.Linq;

	public interface ILineItemService
	{
		IEnumerable<LineItemDto> GetLineItems();
		void WriteLineItems(LineItemDto lineItem);
	}
}
