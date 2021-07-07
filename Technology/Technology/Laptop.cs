using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {

        public bool HasKeyboard { get; }
        // new field will be (is touchscreen)
        public Laptop(string computerName, string gpuType, string cpuType, bool hasKeyBoard) : base(computerName, gpuType, cpuType)
        {
            this.HasKeyboard = HasKeyboard;
        }
        // new method will be a string of canPlayMinecraft?

        public void UseTouchscreen()
        {
            if (HasKeyboard)
            {
                Console.WriteLine("Boop boop keyboard is in use");
            }
            else
            {
                Console.WriteLine("You disgusting little POS. THATS NOT your keyboard. get yo nasty, grubby little hands off my screen. That is how pink eye spreads");
            }
        }

        public override void IncreaseStorage(int storageIncrease)
        {
            Console.WriteLine($"Boop Boop increasing storage by.... {storageIncrease}");
            this.StorageAmount = storageIncrease;
        }

    }
}
