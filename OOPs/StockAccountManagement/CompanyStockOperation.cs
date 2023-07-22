using Newtonsoft.Json;
using OOPs.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.StockAccountManagement
{
    internal class CompanyStockOperation
    {
        public static List<CompanyStockDetails> list;

        public void ReadCompanyJson(String filePath)
        {
            var json = File.ReadAllText(filePath);
            List<CompanyStockDetails> list = JsonConvert.DeserializeObject < List < CompanyStockDetails >> (json);
            foreach(var data in list)
            {
                Console.WriteLine(data.StockName + " "+data.NoOfShares +" "+data.SharePrice );
            }
        }
       

    }
}
