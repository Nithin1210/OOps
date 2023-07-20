using Newtonsoft.Json;
using OOPs.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.StockAccountManagement
{
    internal class CompanyDetailsOperation
    {
        public void ReadCompanyJson(String filePath)
        {
            var json = File.ReadAllText(filePath);
            List<CompanyDetails> list = JsonConvert.DeserializeObject < List < CompanyDetails >> (json);
            foreach(var data in list)
            {
                Console.WriteLine(data.StockName + " "+data.NoOfShares +" "+data.SharePrice );
            }
        }

    }
}
