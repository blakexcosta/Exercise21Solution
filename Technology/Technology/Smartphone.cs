using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Smartphone : Computer
    {
        public bool IsATouchScreen { get; }
        // new field will be (is touchscreen)
        public Smartphone(string computerName, string gpuType, string cpuType, bool isTouchScreen) : base(computerName, gpuType, cpuType)
        {
            this.IsATouchScreen = isTouchScreen;
        }

        public override void IncreaseStorage(int storageIncrease)
        {
            this.StorageAmount = storageIncrease;
        }

        public override void IncreaseRam(int ramIncrease)
        {
            //base.IncreaseRam(ramIncrease);
            this.RAM = ramIncrease;
        }
    }
}
