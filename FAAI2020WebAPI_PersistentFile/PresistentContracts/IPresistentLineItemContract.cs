namespace FAAI2020WebAPI_PersistentFile.PresistentContracts
{
	using FAAI2020WebAPI_PresistentFile;
	using System;
	using System.Collections.Generic;

	public interface IPresistentLineItemContract
	{
		void WriteLineItem(LineItem lineItem);
		IEnumerable<LineItem> ReadLineItems();
		LineItem ReadLineItem(string id);
		LineItem ReadLineItem(Func<LineItem, bool> func);
	}
}
