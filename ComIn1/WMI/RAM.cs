using ComputerInfo.Define;
using System;
using System.Management;

namespace ComputerInfo.WMI
{
    class RAM
    {
        private static Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();

        public static void GainRAM()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(WMIQuery.WMI_RAM).Get())
            {
                try
                {
                    RAM_Speed = wmi[WMIQuery.WMI_RAM_SPEED].ToString();
                    RAM_Voltage = wmi[WMIQuery.WMI_RAM_VOLTAGE].ToString().Insert(1, ".");
                    RAM_Manufacturer = wmi[WMIQuery.WMI_RAM_MANUFACTURER].ToString();
                    RAM_free_physical_memeory = int.Parse(wmi["FreePhysicalMemory"].ToString());
                }
                catch
                {
                    continue;
                }
            }
            RAM_Pysical_Size = info.TotalPhysicalMemory;//info.TotalPhysicalMemory == 0 ? 1 : info.TotalPhysicalMemory;
            RAM_Virtual_Size = info.TotalVirtualMemory;//info.TotalVirtualMemory == 0 ? 1 : info.TotalVirtualMemory;
        }

        /*
        private uint GetTotalUsedMemory()
        {
            ManagementClass cls = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection instances = cls.GetInstances();

            foreach (ManagementObject info in instances)
            {
                int total_physical_memeory = int.Parse(info["TotalVisibleMemorySize"].ToString());
                int free_physical_memeory = int.Parse(info["FreePhysicalMemory"].ToString());
                int remain_physical_memory = total_physical_memeory - free_physical_memeory;
                int usagePercent = 100 * remain_physical_memory / total_physical_memeory;

                Console.WriteLine("Memory Information ================================");
                Console.WriteLine("Total Physical Memory :{0:#,###} KB", info["TotalVisibleMemorySize"]);
                Console.WriteLine("Free Physical Memory :{0:#,###} MB", info["FreePhysicalMemory"]);

                Console.WriteLine("Memory Usage Percent = {0} %", 100 * remain_physical_memory / total_physical_memeory);
                Console.WriteLine("Remain Physical Memory : {0:#,###}", remain_physical_memory);

                return (uint)(remain_physical_memory / 1000);
            }

            return 0;
        }
        */

        public static UInt64 RAM_Pysical_Size { get; private set; }

        public static UInt64 RAM_Virtual_Size { get; private set; }

        public static UInt64 RAM_Available_Physical => info.AvailablePhysicalMemory;

        public static UInt64 RAM_Available_Virtual => info.AvailableVirtualMemory;

        public static String RAM_Speed { get; private set; }

        public static String RAM_Voltage { get; private set; }

        public static String RAM_Manufacturer { get; private set; }

        public static Int32 RAM_free_physical_memeory { get; private set; }

    }
}
