using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Assignment1_OS;

namespace Week4Assignment1.Applications
{
    public class OSEmulator : VirtualOS
    {
        public OSEmulator()
        {

        }

        string emulatedSignature;
        public string EmulatedSignature
        {
            get => emulatedSignature;
            set
            {
                emulatedSignature = UniqueSignature;
            }
        }
    }
}
