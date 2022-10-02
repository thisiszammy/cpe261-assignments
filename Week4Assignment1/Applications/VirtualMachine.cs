using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment1_VirtualMachine
{
    public class VirtualMachine
    {
        protected internal class MachineManager
        {
            public void ModifyBitness(ref string oldBit, string newBit)
            {
                // some code to notify API, OS, Kernel, or any other necessary stuff.
                oldBit = newBit;
            }

            public void ModifyProcessor(ref string oldProcessor, string newProcessor)
            {
                // some code to notify API, OS, Kernel, or any other necessary stuff.
                oldProcessor = newProcessor;
            }

            public void ModifyInstalledRAM(ref double oldRAM, double newRAM)
            {
                // some code to notify API, OS, Kernel, or any other necessary stuff.
                oldRAM = newRAM;
            }


            public void ModifyMACAddress(ref string oldMACAddress, string newMACAddress)
            {
                // some code to notify API, OS, Kernel, or any other necessary stuff.
                oldMACAddress = newMACAddress;
            }

        }

        // Properties & Encapsulated Properties
        protected internal MachineManager machineManager;
        string bitness;
        public string Bitness
        {
            get => bitness; 
            set
            {
                machineManager.ModifyBitness(ref bitness, value);
            }
        }
        string processor;
        public string Processor
        {
            get => processor; 
            set
            {
                machineManager.ModifyProcessor(ref processor, value);
            }
        }
        double installedRAM;
        public double InstalledRAM
        {
            get => installedRAM; 
            set
            {
                machineManager.ModifyInstalledRAM(ref installedRAM, value);
            }
        }
        string macAddress;
        public string MacAddress
        {
            get => macAddress; 
            set
            {
                machineManager.ModifyMACAddress(ref macAddress, value);
            }
        }

        // Constructor
        public VirtualMachine()
        {
            machineManager = new MachineManager();
            bitness = "x64 bit";
            processor = "Intel(R) Core(TM) i7-8700 CPU @ 3.20GHz   3.19 GHz";
            installedRAM = 64;
            macAddress = " 00:00:00:a1:2b:cc";
        }

        protected internal void DisplayMachineInformation()
        {
            Console.WriteLine(JsonConvert.SerializeObject(this)); 
        }
    }
}
