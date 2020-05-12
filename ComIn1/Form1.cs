using ComputerInfo.Set;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Management;

//Code By EXON
namespace ComIn1
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter, ramCounter;

        int cpuVal, ramVal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Upload.UploadSetting();

            Type("CPU");
            Type("GPU");
            Type("RAM");
        }

        
            
        private void InitPerformanceCounter()
        {

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        }



        private void GetValue()
        {

            cpuVal = (int)cpuCounter.NextValue();

            ramVal = (int)ramCounter.NextValue();

        }

        private void Type(string Type)
        {
            switch (Type)
            {
                case "CPU":
                    label8.Text = Untill.CPU_Name;

                    label9.Text = "Current Clock";
                    label10.Text = "Core Count";
                    label11.Text = "Thread Count";
                    label12.Text = "Voltage";
                    label13.Text = "L2Cache Size";
                    label14.Text = "L3Cache Size";

                    label9.Text += ": " + Untill.CPU_Current_Clock;
                    label10.Text += ": " + Untill.CPU_Core_Count + " Core";
                    label11.Text += ": " + Untill.CPU_Thread_Count + " Tread";
                    label12.Text += ": " + Untill.CPU_Voltage;
                    label13.Text += ": " + Untill.CPU_L2Cache_Size;
                    label14.Text += ": " + Untill.CPU_L3Cache_Size;
                    break;

                case "GPU":
                    label15.Text = Untill.GPU_Name;

                    label6.Text = "Processor Name";
                    label5.Text = "Manufacturer";
                    label4.Text = "Refresh Rate";
                    label3.Text = "Max RefreshRate";
                    label2.Text = "Min RefreshRate";
                    label1.Text = "GPU RAM";

                    label6.Text += ": " + Untill.GPU_Video_Processor_Name;
                    label5.Text += ": " + Untill.GPU_Manufacturer;
                    label4.Text += ": " + Untill.GPU_Current_Refresh_Rate;
                    label3.Text += ": " + Untill.GPU_Max_Refresh_Rate;
                    label2.Text += ": " + Untill.GPU_Min_Refresh_Rate;
                    label1.Text += ": " + Untill.GPU_RAM;
                    break;

                case "RAM":
                    label23.Text = "RAM";

                    label21.Text = "Speed";
                    label20.Text = "Manufacturer";
                    label19.Text = "Voltage";
                    label18.Text = "Physical Size";
                    label17.Text = "Virtual Size";

                    label21.Text += ": " + Untill.RAM_Speed;
                    label20.Text += ": " + Untill.RAM_Manafacturer;
                    label19.Text += ": " + Untill.RAM_Voltage;
                    label18.Text += ": " + Untill.RAM_Total_Physical_Size;
                    label17.Text += ": " + Untill.RAM_Total_Virtual_Size;
                    break;
            }
        }

        private void CPU_Name_Button_Click(object sender, EventArgs e)
        {

        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
