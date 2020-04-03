using ComputerInfo.Set;
using System;
using System.Windows.Forms;

namespace ComIn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Upload.UploadSetting();


            Type("CPU");
        }

        private void Type(string Type)
        {
            switch (Type)
            {
                case "CPU":
                    Type_Label.Text = "CPU";
                    Name_Label.Text = Untill.CPU_Name;

                    Text1.Text = "Current Clock";
                    Text2.Text = "Core Count";
                    Text3.Text = "Thread Count";
                    Text4.Text = "Voltage";
                    Text5.Text = "L2Cache Size";
                    Text6.Text = "L3Cache Size";

                    label1.Text = ": " + Untill.CPU_Current_Clock;
                    label2.Text = ": " + Untill.CPU_Core_Count + " Core";
                    label3.Text = ": " + Untill.CPU_Thread_Count + " Tread";
                    label4.Text = ": " + Untill.CPU_Voltage;
                    label5.Text = ": " + Untill.CPU_L2Cache_Size;
                    label6.Text = ": " + Untill.CPU_L3Cache_Size;
                    break;

                case "GPU":
                    Type_Label.Text = "GPU";
                    Name_Label.Text = Untill.GPU_Name;

                    Text1.Text = "Processor Name";
                    Text2.Text = "RAM";
                    Text3.Text = "Refresh Rate";
                    Text4.Text = "Max RefreshRate";
                    Text5.Text = "Min RefreshRate";
                    Text6.Text = "Manufacturer";

                    label1.Text = ": " + Untill.GPU_Video_Processor_Name;
                    label2.Text = ": " + Untill.GPU_RAM;
                    label3.Text = ": " + Untill.GPU_Current_Refresh_Rate;
                    label4.Text = ": " + Untill.GPU_Max_Refresh_Rate;
                    label5.Text = ": " + Untill.GPU_Min_Refresh_Rate;
                    label6.Text = ": " + Untill.GPU_Manufacturer;
                    break;

                case "RAM":
                    Type_Label.Text = "RAM";
                    Name_Label.Text = "RAM";
                    break;
            }
        }

        private void CPU_Button_Click(object sender, EventArgs e)
        {
            Type("CPU");
        }

        private void GPU_Button_Click(object sender, EventArgs e)
        {
            Type("GPU");
        }

        private void RAM_Button_Click(object sender, EventArgs e)
        {
            Type("RAM");
        }

        private void CPU_Name_Button_Click(object sender, EventArgs e)
        {

        }

        private void X_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
