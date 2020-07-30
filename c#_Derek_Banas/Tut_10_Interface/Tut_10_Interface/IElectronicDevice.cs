using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_10_Interface
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}
