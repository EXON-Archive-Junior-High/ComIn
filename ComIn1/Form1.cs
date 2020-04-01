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
                    Text1.Text = Untill.CPU_Current_Clock;
                    Text2.Text = Untill.CPU_Core_Count + " Core";
                    Text3.Text = Untill.CPU_Thread_Count + " Tread";
                    Text4.Text = Untill.CPU_Voltage;
                    break;

                case "GPU":
                    Type_Label.Text = "GPU";
                    Name_Label.Text = Untill.GPU_Name;
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
    }
}
