using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerInfo.Set;
using ComputerInfo.WMI;

namespace ComputerInfo.Set
{
    public class Upload
    {
        public static void UploadSetting()
        {
            //Define CPU
            CPU.GainCPU();
            Untill.SetCPU();

            //Define GPU
            GPU.GainGPU();
            Untill.SetGPU();

            //Define RAM
            RAM.GainRAM();
            Untill.SetRAM();

            //Define Disk
            Disk.GainDisk();
            Untill.SetDisk();
        }
    }
}
