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
            Untill untill = new Untill();

            //Define CPU
            CPU.GainCPU();
            untill.SetCPU();

            //Define GPU
            GPU.GainGPU();


            //Define RAM
            RAM.GainRAM();


            //Define Disk
            Disk.GainDisk();
            //Untill.SetDisk();
        }
    }
}
