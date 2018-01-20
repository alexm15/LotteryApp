using LotteryClassLibrary;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotteryApp.Models
{
    public class SerialNumberRegistry
    {
        

        private FileManager fileManager;
        public List<SelectListItem> AvailableSerialNumbers { get; } = new List<SelectListItem>();


        public SerialNumberRegistry() {
            fileManager = new FileManager();
            List<string> initialSerialNumbers = fileManager.GetSerialNumbers("../LotteryClassLibrary/SerialNumbers.dat");
            SerialNumberToSelectListItems(initialSerialNumbers);
        }

        private void SerialNumberToSelectListItems(List<string> initialSerialNumbers)
        {
            foreach (var serialNumber in initialSerialNumbers)
            {
                AvailableSerialNumbers.Add(new SelectListItem { Value = serialNumber, Text = serialNumber });
            }
        }
    }
}
