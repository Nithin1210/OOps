using Newtonsoft.Json;
using OOPs.StockAccountManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace OOPs.CommercialDataProcessing
{
    public class CustomerStockOperation
    {
        List<CompanyStockDetails> companyStock = new List<CompanyStockDetails>();
        List<CustomerStockDetails> customerStock = new List<CustomerStockDetails>();
        public int amount;
        public CustomerStockOperation(int amount)
        {
            this.amount = amount;
        }



        public void ReadCompanyStock(String filePath)
        {
            var json = File.ReadAllText(filePath);
            companyStock = JsonConvert.DeserializeObject<List<CompanyStockDetails>>(json);
            Display(companyStock);
        }
        public void ReadCustomerStock(String filePath)
        {
            var json = File.ReadAllText(filePath);
            customerStock = JsonConvert.DeserializeObject<List<CustomerStockDetails>>(json);
            Display(customerStock);
        }
        public void Display(List<CompanyStockDetails> companyStock)
        {
            foreach (var data in companyStock)
            {
                Console.WriteLine(data.StockName + " " + data.NoOfShares + " " + data.SharePrice);
            }
        }
        public void Display(List<CustomerStockDetails> customerStocks)
        {
            foreach (var data in customerStocks)
            {
                Console.WriteLine(data.StockSymbol + " " + data.NoOfShares + " " + data.SharePrice);
            }
        }
        public void BuyStock(string name, int numofShares)

        {
            CompanyStockDetails buyStock = new CompanyStockDetails();
            foreach (var data in companyStock)
            {
                if (data.StockName.ToLower().Equals(name.ToLower()))
                {
                    if (data.NoOfShares >= numofShares && data.SharePrice * numofShares <= amount)
                    {
                        buyStock = data;
                        data.NoOfShares -= numofShares;
                        amount -= data.SharePrice * numofShares;
                        break;
                    }
                }
            }
            if (buyStock == null)
            {
                Console.WriteLine(" Those Stock Doesn't Exist !!");
            }
            else
            {
                CustomerStockDetails buyCustomerStocks = new CustomerStockDetails();
                foreach (var data in customerStock)
                {
                    if (data.StockSymbol.ToLower().Equals(name.ToLower()))
                    {
                        buyCustomerStocks = data;
                        data.NoOfShares += numofShares;
                        break;
                    }
                    else
                    {
                        buyCustomerStocks = null;
                    }
                }
                if (buyCustomerStocks == null)
                {
                    buyCustomerStocks = new CustomerStockDetails();
                    buyCustomerStocks.StockSymbol = name;
                    buyCustomerStocks.SharePrice = buyStock.SharePrice;
                    buyCustomerStocks.NoOfShares = numofShares;
                    customerStock.Add(buyCustomerStocks);
                }
            }
        }
        public void SellStock(string name, int numofShares)
        {
            CustomerStockDetails sellCustomerStocks = new CustomerStockDetails();
            foreach (var data in customerStock)
            {
                if (data.StockSymbol.ToLower().Equals(name.ToLower()))
                {
                    if (numofShares <= data.NoOfShares)
                    {
                        sellCustomerStocks = data;
                        data.NoOfShares -= numofShares;
                        break;
                    }
                }
                else
                {
                    sellCustomerStocks = null;
                }
            }
            if (sellCustomerStocks == null)
            {
                Console.WriteLine(" !! No stocks available right now !!");
            }
            else
            {
                CompanyStockDetails sellStock = new CompanyStockDetails();
                foreach (var data in companyStock)
                {
                    if (data.StockName.ToLower().Equals(name.ToLower()))
                    {
                        sellStock = data;
                        data.NoOfShares += numofShares;
                        amount += data.SharePrice * numofShares;
                        break;
                    }
                }
            }
        }
        public void WriteToCustomerJsonFile(string filepath)
        {
            var json = JsonConvert.SerializeObject(customerStock);
            File.WriteAllText(filepath, json);
        }
        public void WriteToStockJsonFile(string filepath)
        {
            var json = JsonConvert.SerializeObject(companyStock);
            File.WriteAllText(filepath, json);
        }
    }
}
