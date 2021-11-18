﻿using FAAI2020WebAPI_PresistentFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services
{
    public class LineItemDto
    {
        public string ArticleId { get; set; }
        public double Quantity { get; set; }
        public string Text { get; set; }

        internal LineItem ToLineItem()
        {
            return new LineItem()
            {
                ArticleId = this.ArticleId,
                Quantity = this.Quantity,
                Text = this.Text
            };
        }
    }
}
