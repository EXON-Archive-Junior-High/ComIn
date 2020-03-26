using System;
using System.IO;
using System.Management;
using ComputerInfo.Define;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.WMI
{
    class Disk
    {

        private static List<DriveInfo> volumes = new List<DriveInfo>();
        public static DriveInfo[] driver = DriveInfo.GetDrives();

        public static void GainDisk()
        {

            for (int i = 0; i < driver.Length; i++)
            {

                if (driver[i].IsReady)
                {
                    volumes.Add(driver[i]);
                }


            }
        }

        public static int GetVolumeCount => volumes.Count;
        public static List<DriveInfo> DISK_Volumes { get; } = volumes;
    }
}
