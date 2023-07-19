﻿using Newtonsoft.Json;
using OOPs.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPs.InventoryManagement
{
    public class InventoryManagementOperations
    {
        InventoryManagementDetails list;
        public void ReadInventoryJson(string filepath)
        {
            var json = File.ReadAllText(filepath);
            list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);
            Display(list.RiceList);
            Display(list.WheatList);
            Display(list.PulsesList);
        }
        public void AddInventoryManagement(string objectName)
        {
            Console.WriteLine("here we go my dear Friend we can make you proud and Brave ");
            if (objectName.ToLower().Equals("rice"))
            {
                Console.WriteLine("Enter the Details : Name,Weight,PricePerKg");
                InventoryDetails details = new InventoryDetails()
                {
                    Name = Console.ReadLine(),
                    Weight = Convert.ToInt32(Console.ReadLine()),
                    PricePerKg = Convert.ToInt32(Console.ReadLine())
                };
                list.RiceList.Add(details);
            }
            if (objectName.ToLower().Equals("wheat"))
            {
                Console.WriteLine("Enter the Details : Name,Weignt,PricePerKg");
                InventoryDetails details = new InventoryDetails()
                {
                    Name = Console.ReadLine(),
                    Weight = Convert.ToInt32(Console.ReadLine()),
                    PricePerKg = Convert.ToInt32(Console.ReadLine())
                };
                list.WheatList.Add(details);
            }
            if (objectName.ToLower().Equals("pulses"))
            {
                Console.WriteLine("Enter the Details : Name,Weignt,PricePerKg");
                InventoryDetails details = new InventoryDetails()
                {
                    Name = Console.ReadLine(),
                    Weight = Convert.ToInt32(Console.ReadLine()),
                    PricePerKg = Convert.ToInt32(Console.ReadLine())
                };
                list.PulsesList.Add(details);
            }
        }
            public void WriteToJsonFile(string filepath)
            {

                var json = JsonConvert.SerializeObject(list);
                File.WriteAllText(filepath, json);
            }



            public void Display(List<InventoryDetails> list)
            {
                foreach (var data in list)
                {
                    Console.WriteLine(data.Name + " " + data.Weight + " " + data.PricePerKg);
                
            }
            }
    }
}



