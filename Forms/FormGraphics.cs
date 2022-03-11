using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace InfoMonitor.Forms
{
    public partial class FormGraphics : Form
    {
        public FormGraphics()
        {
            InitializeComponent();
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                label1.Text = "Nume: " + obj["Name"];
                label2.Text = "Memorie VRAM : " + obj["AdapterRAM"];
            }
        }

        private void FormGraphics_Load(object sender, EventArgs e)
        {

        }
    }
}
