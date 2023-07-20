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
        public void DeleteInventoryManagement(string objectName, string InventoryName)
        {
            InventoryDetails details = new InventoryDetails();
            if(objectName.ToLower().Equals("rice"))
            {
                foreach(var data in list.RiceList)
                {
                    if (data.Name.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                    list.RiceList . Remove(details);
            }
            if (objectName.ToLower().Equals("wheat"))
            {
                foreach (var data in list.WheatList)
                {
                    if (data.Name.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                    list.WheatList.Remove(details);
            }
            if (objectName.ToLower().Equals("pulse"))
            {
                foreach (var data in list.PulsesList)
                {
                    if (data.Name.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                    list.PulsesList.Remove(details);
            }
            if (details==null)
                Console.WriteLine("No Inventory details Exists");


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



