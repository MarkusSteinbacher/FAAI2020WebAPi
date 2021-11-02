﻿using FAAI2020WebAPI_Contract.PersitentContract;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Model
{
	[DelimitedRecord(";")]
	public class LineItem : ILineItem
	{
		public string ArticleId { get; set; }
		public double Quantity { get; set; }
		public string Text { get; set; }
	}
}