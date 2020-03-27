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

            Console.WriteLine();
        }

        private static void ButtonVisible(string buttonType, bool b)
        {
            switch (buttonType) 
            {
                case "CPU":
                    break;

                case "GPU":
                    break;

                case "RAM":
                    break;

                case "All":
                    break;
            }

        }

        private void CPU_Button_Click(object sender, EventArgs e)
        {
            ButtonVisible("All", false);
            ButtonVisible("CPU", true);
        }

        private void GPU_Button_Click(object sender, EventArgs e)
        {
            ButtonVisible("All", false);
            ButtonVisible("GPU", true);
        }

        private void RAM_Button_Click(object sender, EventArgs e)
        {
            ButtonVisible("All", false);
            ButtonVisible("RAM", true);
        }
    }
}
