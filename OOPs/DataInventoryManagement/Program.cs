using System;
using System.Threading.Channels;

namespace OOPs.DataInventoryManagement
{
    public class program
    {
        static string inventory_filePath = @"E:\Json\OOPs\DataInventoryManagement\InventoryData.json";
        public static void Main(string[] args)
        {
            InventoryDetailsOperation details = new InventoryDetailsOperation();
            details.ReadInventoryJson(inventory_filePath);
        }

    }
}
