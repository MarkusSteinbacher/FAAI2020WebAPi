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
	public class OrderFileHandler : IPersistentOrderContract
	{
        public IEnumerable<IOrder> Read()
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(Order));
            var result = (IEnumerable<IOrder>)fileHelperEngine.ReadFile($@"C:\Users\Administrator\Desktop\FileHelper\Orders.txt");
            return result;
        }

        public IOrder Read(string id)
		{
            throw new NotImplementedException();
		}

        public void Write(IOrder order)
        {
            FileHelperEngine fileHelperEngine = new FileHelperEngine(typeof(Order));
            fileHelperEngine.WriteFile($@"C:\Users\Administrator\Desktop\FileHelper\
                                        { DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}Orders.txt", new List<IOrder>() { order });

            fileHelperEngine.AppendToFile($@"C: \Users\Administrator\Desktop\FileHelper\
                                        { DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}Orders.txt", new List<IOrder>() { order });
        }
    }


}
