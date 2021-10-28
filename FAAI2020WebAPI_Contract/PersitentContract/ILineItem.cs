using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
	public interface ILineItem
	{
		string ArticleId { get; set; }
		double Quantity { get; set; }
		string Text { get; set; }
	}
}
