using OOPs.DataInventoryManagement;
using OOPs.StockAccountManagement;
using System;
using System.Threading.Channels;

namespace OOPs.InventoryManagement
{
    public class program
    {
        static string inventory_filePath = @"E:\BridgeLabz\OOps\OOPs\StockAccountManagement\CompanyData.json";
        public static void Main(string[] args)
        {
            //InventoryDetailsOperation details = new InventoryDetailsOperation();
            //details.ReadInventoryJson(inventory_filePath);

            //InventoryManagementOperations details = new InventoryManagementOperations();
            //details.ReadInventoryJson(inventory_filePath);

            CompanyDetailsOperation details = new CompanyDetailsOperation();
            details.ReadCompanyJson(inventory_filePath);

            
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

