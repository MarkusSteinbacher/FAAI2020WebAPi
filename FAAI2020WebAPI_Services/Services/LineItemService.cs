namespace FAAI2020WebAPI_Services
{
	using AutoMapper;
	using FAAI2020WebAPI_PersistentFile;
    using FAAI2020WebAPI_PersistentFile.PresistentContracts;
    using FAAI2020WebAPI_PresistentFile;
    using System.Collections.Generic;
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
            var result = this.mapper.Map<List<LineItemDto>>(this.presistentLineItemContract.ReadLineItems());
            return result.AsQueryable();
        }

		public void WriteLineItems(LineItemDto lineItemDto)
		{
			var result = this.mapper.Map<LineItem>(lineItemDto);
			this.presistentLineItemContract.WriteLineItem(result);
		}
    }
}
