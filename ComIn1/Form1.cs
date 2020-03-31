using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerInfo.WMI;
using ComputerInfo.Set;
using ComputerInfo.Define;
using System.IO;
using System.Diagnostics;

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


        private void TypeVisible(string Type, bool b)
        {
            switch (Type) 
            {
                case "CPU":
                    Name_Label.Visible = b;
                    break;

                case "GPU":
                    break;

                case "RAM":
                    break;

                case "All":
                    Name_Label.Visible = b;
                    break;
            }

        }

        private void Type(string Type)
        {
            switch (Type)
            {
                case "CPU":
                    Name_Label.Text = Untill.CPU_Name;
                    break;

                case "GPU":
                    Name_Label.Text = Untill.GPU_Name;
                    break;

                case "RAM":
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
