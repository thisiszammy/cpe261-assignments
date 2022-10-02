// See https://aka.ms/new-console-template for more information

using Week4Assignment1_OS;
using Week4Assignment1_VirtualMachine;

internal class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        //VirtualMachine _vm = new VirtualMachine();
        //_vm.DisplayMachineInformation();

        VirtualMachineWrapper vm = new VirtualMachineWrapper();
        vm.RelayInformation();
    }
    
    internal class VirtualMachineWrapper : VirtualMachine
    {
        public VirtualMachineWrapper()
        {

        }

        public void RelayInformation()
        {
            DisplayMachineInformation();
        }
    }
}