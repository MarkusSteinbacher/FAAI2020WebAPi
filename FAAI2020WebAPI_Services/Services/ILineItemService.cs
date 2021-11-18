namespace FAAI2020WebAPI_Services
{
	using System.Linq;

	public interface ILineItemService
	{
		IQueryable<LineItemDto> GetLineItems();
		void WriteLineItems(LineItemDto lineItem);
	}
}
