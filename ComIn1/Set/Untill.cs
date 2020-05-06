using Microsoft.Win32;
using System;
using System.IO;
using System.Collections;
using System.Management;
using ComputerInfo.WMI;

namespace ComputerInfo.Set
{
    public class Untill
    {
        public static string CPU_Name;
        public static string CPU_Current_Clock;
        public static string CPU_Voltage;
        public static string CPU_L2Cache_Size;
        public static string CPU_L3Cache_Size;
        public static string CPU_Core_Count;
        public static string CPU_Thread_Count;

        public static string GPU_Name;
        public static string GPU_Adapter_Compatiability;
        public static string company;
        public static string GPU_Manufacturer;
        public static string GPU_Caption;
        public static string GPU_Video_Processor_Name;
        public static string GPU_RAM;
        public static string GPU_Current_Refresh_Rate;
        public static string GPU_Max_Refresh_Rate;
        public static string GPU_Min_Refresh_Rate;
        public static string GPU_Current_Resolution;
        public static string GPU_Driver_Version;


        public static double Pysical_Size;
        public static double Virtual_Size;
        public static string RAM_Manafacturer;
        public static string RAM_Speed;
        public static string RAM_Voltage;
        public static string RAM_Total_Physical_Size;
        public static string RAM_Total_Virtual_Size;
        public static int RAM_free_physical_memeory;

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
