namespace FAAI2020WebAPI_Services
{
	using AutoMapper;
	using FAAI2020WebAPI_Model;
	using FAAI2020WebAPI_PersistentFile;
	using System.Linq;

	public class LineItemService : ILineItemService
	{
		private readonly IPresistentLineItemContract presistentLineItemContract;
        private readonly IMapper mapper;

        public LineItemService(IPresistentLineItemContract presistentLineItemContract, IMapper mapper)
		{
			this.presistentLineItemContract = presistentLineItemContract;
            this.mapper = mapper;
        }

		public IQueryable<LineItemDto> GetLineItems()
		{
			//return this.presistentLineItemContract.ReadLineItems().AsQueryable();
			//ToDo: Map
			return null;
		}

		public void WriteLineItems(LineItemDto lineItemDto)
		{
			var result = this.mapper.Map<LineItem>(lineItemDto);
			this.presistentLineItemContract.WriteLineItem(result);
		}
    }
}
