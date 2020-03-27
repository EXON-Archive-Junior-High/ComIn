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
        public DriveInfo[] allDrives = DriveInfo.GetDrives();

        public string CPU_Name;
        public string CPU_Current_Clock;
        public string CPU_Voltage;
        public string CPU_L2Cache_Size;
        public string CPU_L3Cache_Size;
        public string CPU_Core_Count;
        public string CPU_Thread_Count;

        public void SetCPU()
        {
            CPU_Name = CPU.CPU_Name;
            CPU_Current_Clock = String.Format("{0:F2} Ghz", (CPU.CPU_Current_Clock / 1000f));
            CPU_Voltage = String.Format("{0:F3} V", CPU.CPU_Voltage);
            CPU_L2Cache_Size = String.Format("{0:F2} Mb", (CPU.CPU_L2Cache_Size / 1024f));
            CPU_L3Cache_Size = String.Format("{0:F2} Mb", (CPU.CPU_L3Cache_Size / 1024f));
            CPU_Core_Count = CPU.CPU_Core_Count.ToString();
            CPU_Thread_Count = CPU.CPU_Thread_Count.ToString();
        }

        public string company = GPU.GPU_Adapter_Compatiability;
        public string GPU_Manufacturer = GPU.GPU_Adapter_Compatiability;
        public string GPU_Caption = GPU.GPU_Caption;
        public string GPU_Video_Processor_Name = GPU.GPU_Video_Processor;
        public string GPU_RAM = String.Format("{0:F2} GB", (Convert.ToInt64(GPU.GPU_Adapter_RAM) / 1024f / 1024f / 1024f));
        public string GPU_Current_Refresh_Rate = GPU.GPU_Current_Refresh_Rate + "hz";
        public string GPU_Max_Refresh_Rate = GPU.GPU_Max_Refresh_Rate + "hz";
        public string GPU_Min_Refresh_Rate = GPU.GPU_Min_Refresh_Rate + "hz";
        public string GPU_Current_Resolution = GPU.GPU_Video_Mode_Description;
        public string GPU_Driver_Version = GPU.GPU_Driver_Version;
        public static DateTime driverTime = DateTime.ParseExact(GPU.GPU_Driver_Date, "yyyyMMddHHmmss", null);
        public string GPU_Driver_Date = String.Format("{0}/{1}/{2}", driverTime.Month, driverTime.Day, driverTime.Year);

        public void SetGPU()
        {
            company = GPU.GPU_Adapter_Compatiability;
            GPU_Manufacturer = GPU.GPU_Adapter_Compatiability;
            GPU_Caption = GPU.GPU_Caption;
            GPU_Video_Processor_Name = GPU.GPU_Video_Processor;
            GPU_RAM = String.Format("{0:F2} GB", (Convert.ToInt64(GPU.GPU_Adapter_RAM) / 1024f / 1024f / 1024f));
            GPU_Current_Refresh_Rate = GPU.GPU_Current_Refresh_Rate + "hz";
            GPU_Max_Refresh_Rate = GPU.GPU_Max_Refresh_Rate + "hz";
            GPU_Min_Refresh_Rate = GPU.GPU_Min_Refresh_Rate + "hz";
            GPU_Current_Resolution = GPU.GPU_Video_Mode_Description;
            GPU_Driver_Version = GPU.GPU_Driver_Version;
            driverTime = DateTime.ParseExact(GPU.GPU_Driver_Date, "yyyyMMddHHmmss", null);
            GPU_Driver_Date = String.Format("{0}/{1}/{2}", driverTime.Month, driverTime.Day, driverTime.Year);
        }

        public static double Pysical_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
        public static double Virtual_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
        public string RAM_Manafacturer = RAM.RAM_Manufacturer;
        public string RAM_Speed = String.Format("{0} Mhz", RAM.RAM_Speed);
        public string RAM_Voltage = String.Format("{0} V", RAM.RAM_Voltage);
        public string RAM_Total_Physical_Size = String.Format("{0:F2} GB", Pysical_Size);
        public string RAM_Total_Virtual_Size = String.Format("{0:F2} GB", Virtual_Size);

        public void SetRAM()
        {
            Pysical_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            Virtual_Size = (RAM.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            RAM_Manafacturer = RAM.RAM_Manufacturer;
            RAM_Speed = String.Format("{0} Mhz", RAM.RAM_Speed);
            RAM_Voltage = String.Format("{0} V", RAM.RAM_Voltage);
            RAM_Total_Physical_Size = String.Format("{0:F2} GB", Pysical_Size);
            RAM_Total_Virtual_Size = String.Format("{0:F2} GB", Virtual_Size);
        }

        //public static DriveInfo Disk;
        //public static string Disk_Name = string.Format("{0}", Disk.Name);
        //public static string Disk_DriveType = string.Format("{0}", Disk.DriveType);

        //public static string Disk_VolumeLabel = string.Format(Disk.VolumeLabel);
        //public static string Disk_DriveFormat = string.Format(Disk.DriveFormat);
        //public static long Disk_AvailableFreeSpace = Disk.AvailableFreeSpace;
        //public static long Disk_TotalFreeSpace = Disk.TotalFreeSpace;
        //public static long Disk_TotalSize = Disk.TotalSize;

        //public static void SetDisk()
        //{


        //    foreach (DriveInfo disk in allDrives)
        //    {
        //        Disk = disk;
        //        Disk_Name = string.Format("{0}", disk.Name);
        //        string Disk_DriveType = string.Format("{0}", disk.DriveType);
        //        if (disk.IsReady == true)
        //        {
        //            Disk_VolumeLabel = string.Format(disk.VolumeLabel);
        //            Disk_DriveFormat = string.Format(disk.DriveFormat);
        //            Disk_AvailableFreeSpace = disk.AvailableFreeSpace;
        //            Disk_TotalFreeSpace = disk.TotalFreeSpace;
        //            Disk_TotalSize = disk.TotalSize;
        //        }
        //    }



        //}
    }
}
