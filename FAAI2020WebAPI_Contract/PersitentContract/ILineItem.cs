using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
    public interface ILineItem
    {
        public string ArticleId { get; set; }
        public double Quantity { get; set; }

        public string Text { get; set; }
    }
}
