using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Assignment1_VirtualMachine;

namespace Week4Assignment1_OS
{
    public class VirtualOS : VirtualMachine
    {
        // constructor
        public VirtualOS()
        {
            string temp = UniqueSignature;
        }

        string uniqueSignature;
        private protected string UniqueSignature
        {
            get => uniqueSignature;
            set
            {
                uniqueSignature = value;
            }
        }
    }
}
