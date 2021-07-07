using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestIfLaptopInheritsFromComputer()
        {
            //Computer as = new Computer();
            Laptop comp = new Laptop("HP Omen", "NVIDIA 2070 SUPER", "Intel I7", true);
            // RAM is inherited from Copmuter
            Assert.AreEqual(16, comp.RAM);
        }

        [TestMethod]
        public void CheckLaptopClassInheritsPropertyFromAbstractEntityClass()
        {
            Laptop laptop = new Laptop("HP", "NVIDIA 2070 SUPER", "INTEL i7", true);
            Assert.IsNotNull(laptop.ID); // make sure ID is not null
        }

        /*
        [TestMethod]
        public void TestComputerGetsSetsComputerName()
        {
            Computer comp = new Computer("HP Omen", "NVIDIA 2070 SUPER", "Intel I7");
            Assert.AreEqual("HP Omen", comp.ComputerName);
        }

        [TestMethod]
        public void TestIfComputerSetsCPU()
        {
            Computer comp = new Computer("HP Omen", "NVIDIA 2070 SUPER", "Intel I7");
            Assert.AreEqual("Intel I7", comp.CPUType);
        }

        [TestMethod]
        public void TestIfComputerSetsGPU()
        {
            Computer comp = new Computer("HP Omen", "NVIDIA 2070 SUPER", "Intel I7");
            Assert.AreEqual("NVIDIA 2070 SUPER", comp.GPUType);
        }
        */

        [TestMethod]
        public void TestThatLaptopSetsStorageAmount()
        {
            Laptop comp = new Laptop("HP Omen", "NVIDIA 2070 SUPER", "Intel I7", true);
            comp.IncreaseStorage(100);
            Assert.AreEqual(100, comp.StorageAmount);
        }

        [TestMethod]
        public void TestThatLaptopSetsID()
        {
            Laptop comp = new Laptop("HP Omen", "NVIDIA 2070 SUPER", "Intel I7", true);
            Assert.IsNotNull(comp.ID);
        }

        [TestMethod]
        public void TestThatSmartphoneSetsID()
        {
            Smartphone comp = new Smartphone("Iphone", "some proprietary gpu", "Intel celeron", true);
            comp.IncreaseStorage(105);
            //Assert.AreEqual(100, comp.StorageAmount);
            Assert.IsNotNull(comp.ID);
        }

        [TestMethod]
        public void TestThatSmartphoneIncreasesStorage()
        {
            Smartphone comp = new Smartphone("Iphone", "some proprietary gpu", "Intel celeron", true);
            comp.IncreaseStorage(105);
            Assert.AreEqual(105, comp.StorageAmount);
        }

    }
}
