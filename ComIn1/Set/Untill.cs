using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Management;
using ComputerInfo.WMI;

namespace ComputerInfo.Set
{
    public class Untill
    {
        public static DriveInfo[] allDrives = DriveInfo.GetDrives();

        public static void SetCPU()
        {
            string CPU_Name = CPU.CPU_Name;
            string CPU_Current_Clock = String.Format("{0:F2} Ghz", (CPU.CPU_Current_Clock / 1000f));
            string CPU_Voltage = String.Format("{0:F3} V", CPU.CPU_Voltage);
            string CPU_L2Cache_Size = String.Format("{0:F2} Mb", (CPU.CPU_L2Cache_Size / 1024f));
            string CPU_L3Cache_Size = String.Format("{0:F2} Mb", (CPU.CPU_L3Cache_Size / 1024f));
            string CPU_Core_Count = CPU.CPU_Core_Count.ToString();
            string CPU_Thread_Count = CPU.CPU_Thread_Count.ToString();
        }

        public static void SetGPU()
        {
            string company = GPU.GPU_Adapter_Compatiability.ToLower();
            string GPU_Manufacturer = GPU.GPU_Adapter_Compatiability;
            string GPU_Caption = GPU.GPU_Caption;
            string GPU_Video_Processor_Name = GPU.GPU_Video_Processor;
            string GPU_RAM = String.Format("{0:F2} GB", (Convert.ToInt64(GPU.GPU_Adapter_RAM) / 1024f / 1024f / 1024f));
            string GPU_Current_Refresh_Rate = GPU.GPU_Current_Refresh_Rate + "hz";
            string GPU_Max_Refresh_Rate = GPU.GPU_Max_Refresh_Rate + "hz";
            string GPU_Min_Refresh_Rate = GPU.GPU_Min_Refresh_Rate + "hz";
            string GPU_Current_Resolution = GPU.GPU_Video_Mode_Description;
            string GPU_Driver_Version = GPU.GPU_Driver_Version;
            DateTime driverTime = DateTime.ParseExact(GPU.GPU_Driver_Date, "yyyyMMddHHmmss", null);
            string GPU_Driver_Date = String.Format("{0}/{1}/{2}", driverTime.Month, driverTime.Day, driverTime.Year);
        }

        public static void SetRAM()
        {
            Double Pysical_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            Double Virtual_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            string RAM_Manafacturer = RAM.RAM_Manufacturer;
            string RAM_Speed = String.Format("{0} Mhz", RAM.RAM_Speed);
            string RAM_Voltage = String.Format("{0} V", RAM.RAM_Voltage);
            string RAM_Total_Physical_Size = String.Format("{0:F2} GB", Pysical_Size);
            string RAM_Total_Virtual_Size = String.Format("{0:F2} GB", Virtual_Size);
        }

        public static void SetDisk()
        {


            foreach (DriveInfo disk in allDrives)
            {
                string Disk_Name = string.Format("{0}", disk.Name);
                string Disk_DriveType =  string.Format("{0}", disk.DriveType);
                if (disk.IsReady == true)
                {
                    string Disk_VolumeLabel = string.Format(disk.VolumeLabel);
                    string Disk_DriveFormat = string.Format(disk.DriveFormat);
                    long Disk_AvailableFreeSpace = disk.AvailableFreeSpace;
                    long Disk_TotalFreeSpace =  disk.TotalFreeSpace;
                    long Disk_TotalSize = disk.TotalSize;
                }
            }



        }
    }
}
