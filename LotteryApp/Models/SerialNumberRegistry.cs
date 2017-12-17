using LotteryClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotteryApp.Models
{
    public class SerialNumberRegistry
    {
        public IEnumerable<string> SerialNumbers { get; set; }
        private FileManager fileManager;

        public SerialNumberRegistry() {
            fileManager = new FileManager();
            SerialNumbers = fileManager.GetSerialNumbers("../LotteryClassLibrary/SerialNumbers.dat");
        }
    }
}
