using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class Computer : AbstractEntity
    {
        public string ComputerName { get; }
        public string GPUType { get; }
        public string CPUType { get; }
        public int RAM { get; set; }
        public int StorageAmount { get; set; } // will be set by IncreaseStorageMethod
        public readonly int SerialNumber;

        public Computer(string computerName, string gpuType, string cpuType) : base()
        {
            this.ComputerName = computerName;

            Random randomSerial = new Random();
            this.SerialNumber = randomSerial.Next(0, 50000); // not checking for dupes here
            this.GPUType = gpuType;
            this.CPUType = cpuType;
            this.RAM = 16;
        }

        public virtual void IncreaseRam(int ramIncrease)
        {
            this.RAM = ramIncrease;
        }

        public abstract void IncreaseStorage(int storageIncrease);
    }
}
