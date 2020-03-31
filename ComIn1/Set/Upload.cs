using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerInfo.Set;
using ComputerInfo.WMI;
using System.Diagnostics;
using System.IO;

namespace ComputerInfo.Set
{
    public class Upload
    {

        public static void UploadSetting()
        {

            //Define CPU
            CPU.GainCPU();

            //Define GPU
            GPU.GainGPU();

            //Define RAM
            RAM.GainRAM();

            DriveInfo[] allDrives = DriveInfo.GetDrives();



            Untill.CPU_Name = CPU.CPU_Name;
            Untill.CPU_Current_Clock = String.Format("{0:F2} Ghz", (CPU.CPU_Current_Clock / 1000f));
            Untill.CPU_Voltage = String.Format("{0:F3} V", CPU.CPU_Voltage);
            Untill.CPU_L2Cache_Size = String.Format("{0:F2} Mb", (CPU.CPU_L2Cache_Size / 1024f));
            Untill.CPU_L3Cache_Size = String.Format("{0:F2} Mb", (CPU.CPU_L3Cache_Size / 1024f));
            Untill.CPU_Core_Count = CPU.CPU_Core_Count.ToString();
            Untill.CPU_Thread_Count = CPU.CPU_Thread_Count.ToString();

            Untill.GPU_Name = GPU.GPU_Name;
            Untill.company = GPU.GPU_Adapter_Compatiability;
            Untill.GPU_Manufacturer = GPU.GPU_Adapter_Compatiability;
            Untill.GPU_Caption = GPU.GPU_Caption;
            Untill.GPU_Video_Processor_Name = GPU.GPU_Video_Processor;
            Untill.GPU_RAM = String.Format("{0:F2} GB", (Convert.ToInt64(GPU.GPU_Adapter_RAM) / 1024f / 1024f / 1024f));
            Untill.GPU_Current_Refresh_Rate = GPU.GPU_Current_Refresh_Rate + "hz";
            Untill.GPU_Max_Refresh_Rate = GPU.GPU_Max_Refresh_Rate + "hz";
            Untill.GPU_Min_Refresh_Rate = GPU.GPU_Min_Refresh_Rate + "hz";
            Untill.GPU_Current_Resolution = GPU.GPU_Video_Mode_Description;
            Untill.GPU_Driver_Version = GPU.GPU_Driver_Version;


            Untill.Pysical_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            Untill.Virtual_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            Untill.RAM_Manafacturer = RAM.RAM_Manufacturer;
            Untill.RAM_Speed = String.Format("{0} Mhz", RAM.RAM_Speed);
            Untill.RAM_Voltage = String.Format("{0} V", RAM.RAM_Voltage);
            Untill.RAM_Total_Physical_Size = String.Format("{0:F2} GB", Untill.Pysical_Size);
            Untill.RAM_Total_Virtual_Size = String.Format("{0:F2} GB", Untill.Virtual_Size);
        }
    }
}
