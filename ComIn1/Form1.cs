using ComputerInfo.Set;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Management;

//Code By EXON 2020
namespace ComIn1
{
    public partial class ComIn : Form
    {
         
        public ComIn()
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
                    label1.Text = "RAM";

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

        public void TypeVisible(string type, bool vib)
        {
            switch (type)
            {
                case "all":
                    // CPU
                    label8.Visible = vib;
                    label7.Visible = vib;

                    label9.Visible = vib;
                    label10.Visible = vib;
                    label11.Visible = vib;
                    label12.Visible = vib;
                    label13.Visible = vib;
                    label14.Visible = vib;

                    //GPU
                    label15.Visible = vib;
                    label16.Visible = vib;

                    label6.Visible = vib;
                    label5.Visible = vib;
                    label4.Visible = vib;
                    label3.Visible = vib;
                    label2.Visible = vib;
                    label1.Visible = vib;

                    //RAM
                    pictureBox3.Visible = vib;
                    label23.Visible = vib;

                    label21.Visible = vib;
                    label20.Visible = vib;
                    label19.Visible = vib;
                    label18.Visible = vib;
                    label17.Visible = vib;
                    break;

            }
        }

        public void Go(string home)
        {
            switch (home)
            {
                case "home":
                    label16.Text = "GPU";
                    label7.Text = "CPU";
                    TypeVisible("all", true);
                    Type("CPU");
                    Type("GPU");
                    Type("RAM");
                    break;

                case "info":
                    pictureBox3.Visible = false;
                    label8.Text = "";
                    label7.Text = "ComIn";

                    label9.Text = "ComIn 은 엑슨이 개발한 컴퓨터 사양 확인 \n프로그램입니다!";
                    label10.Text = "";
                    label11.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    label14.Text = "";

                    label15.Text = "";
                    label16.Text = "Developer";

                    label6.Text = "평범한 디자이너 개발자 엑슨[EXON]입니다!";
                    label5.Text = "Mail: exon.indiv@gmail.com";
                    label4.Text = "Discord: EXON#0062";
                    label3.Text = "";
                    label2.Text = "";
                    label1.Text = "";

                    label23.Text = "";

                    label21.Text = "";
                    label20.Text = "";
                    label19.Text = "";
                    label18.Text = "";
                    label17.Text = "";
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Go("home");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Go("info");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
