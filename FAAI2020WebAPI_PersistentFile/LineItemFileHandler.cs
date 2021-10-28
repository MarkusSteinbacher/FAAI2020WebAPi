using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_Model;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_PersistentFile
{
	public class LineItemFileHandler : IPresistentLineItemContract
	{
        public IEnumerable<ILineItem> Read()
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(LineItem));
            var result = (IEnumerable<ILineItem>)fileHelperEngine.ReadFile($@"C:\Users\lechn\Desktop\FileHelper\LineItems.txt");
            return result;
        }

        public ILineItem Read(string id)
        {
            throw new NotImplementedException();
        }

        public void Write(ILineItem lineItem)
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(LineItem));
            fileHelperEngine.WriteFile($@"C:\Users\lechn\Desktop\FileHelper\LineItems.txt", new List<ILineItem>() { lineItem });
            fileHelperEngine.AppendToFile($@"C:\Users\lechn\Desktop\FileHelper\LineItems.txt", new List<ILineItem>() { lineItem });
        }
    }
}
