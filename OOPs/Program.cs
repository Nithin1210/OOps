using OOPs.DataInventoryManagement;
using OOPs.StockAccountManagement;
using System;
using System.Threading.Channels;

namespace OOPs.CommercialDataProcessing
{
    public class program
    {
        
        static string filePath1 = @"E:\BridgeLabz\OOps\OOPs\StockAccountManagement\CompanyStock.json";
        static string filePath2 = @"E:\BridgeLabz\OOps\OOPs\CommercialDataProcessing\CustomerStock.json";
        public static void Main(string[] args)
        {
            //InventoryDetailsOperation details = new InventoryDetailsOperation();
            //details.ReadInventoryJson(inventory_filePath);

            //InventoryManagementOperations details = new InventoryManagementOperations();
            //details.ReadInventoryJson(inventory_filePath);

            //CompanyDetailsOperation details = new CompanyDetailsOperation();
            //details.ReadCompanyJson(inventory_filePath);


            bool flag = true;

            CompanyStockOperation operation = new CompanyStockOperation();
            Console.WriteLine("Enter your Amount to check Stocks : ");
            int num = Convert.ToInt32(Console.ReadLine());
            CustomerStockOperation customeroperation = new CustomerStockOperation(num);
            while (flag)
            {
                Console.WriteLine("Enter the Value :\n1.Display Stocks \n2.Buy Stocks \n3.Sell Stock\n4.Exit :-)");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine(" Company stocks are :-");
                        customeroperation.ReadCompanyStock(filePath1);
                        Console.WriteLine("customer Stocks are :-");
                        customeroperation.ReadCustomerStock(filePath2);
                        break;
                    case 2:
                        Console.WriteLine("Enter Stock Name");
                        string stock = Console.ReadLine();
                        Console.WriteLine("Enter number of shares");
                        int numShare = Convert.ToInt32(Console.ReadLine());
                        customeroperation.BuyStock(stock, numShare);
                        customeroperation.WriteToCustomerJsonFile(filePath2);
                        customeroperation.WriteToStockJsonFile(filePath1);
                        break;
                    case 3:
                        Console.WriteLine("Enter Stock Name");
                        string stock1 = Console.ReadLine();
                        Console.WriteLine("Enter number of shares");
                        int numShare1 = Convert.ToInt32(Console.ReadLine());
                        customeroperation.SellStock(stock1, numShare1);
                        customeroperation.WriteToCustomerJsonFile(filePath2);
                        customeroperation.WriteToStockJsonFile(filePath1);
                        break;
                    case 4:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine(" Number mission impossibe !! ,contact : customercare@123 ");
                        break;



                }
            }
            
            /*

            bool flag = true;
            InventoryManagementOperations details = new InventoryManagementOperations();
            while (flag)
            {
                Console.WriteLine("Enter the Value :\n1.Display \n2.Add \n3.Delete \n4.Bye :-)");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        details.ReadInventoryJson(inventory_filePath);
                        break;
                    case 2:
                        Console.WriteLine("Add the Details (rice or wheat or pulses) : Name,Weight,PricePerKg");
                        string name = Console.ReadLine();
                        details.AddInventoryManagement(name);
                        details.WriteToJsonFile(inventory_filePath);
                        break;
                    case 3:
                        Console.WriteLine("Enter the item name (Rice,Wheat,Pulse)");
                        string name1 = Console.ReadLine();
                        details.DeleteInventoryManagement(name1, inventory_filePath);
                        details.WriteToJsonFile(inventory_filePath);
                        break;
                    case 4:
                        flag = false;
                        break;

         */

                }

            }
        }

