using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

namespace InfoMonitor.Forms
{
    public partial class FormResources : Form
    {
        public FormResources()
        {
            InitializeComponent();
        }
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            
        private void FormResources_Load(object sender, EventArgs e)
        {
           
        }
    }
}
