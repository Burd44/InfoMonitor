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


namespace InfoMonitor
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            /*ActivateButton(btnSender);*/
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelResources.Controls.Add(childForm);
            this.panelResources.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void CloseChildForm(Form childForm, object btnSender)
        {
            activeForm.Close();
        }

        private void btnRES_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResources(), sender);
            DisableButton();
            Color color = Color.Red;
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = Color.DarkRed;

        }
        private void btnSTORAGE_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStorage(), sender);
            DisableButton();
            Color color = Color.Orange;
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = Color.DarkOrange;
        }

        private void btnGRAPHICS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGraphics(), sender);
            DisableButton();
            Color color = Color.Gold;
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = Color.Goldenrod;
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProcessor(), sender);
            DisableButton();
            Color color = Color.Green;
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = Color.DarkGreen;
        }

        private void btnMOTHER_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMotherboard(), sender);
            DisableButton();
            Color color = Color.Blue;
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = Color.DarkBlue;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOther(), sender);
            DisableButton();
            Color color = Color.MediumPurple;
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = color;
            panelLogo.BackColor = Color.DarkViolet;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                DisableButton();
                CloseChildForm(activeForm, sender);
                lblTitle.Text = "Home";
                panelLogo.BackColor = Color.FromArgb(39, 39, 58);
                panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            }
        }

        PerformanceCounter CPU = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter RAM = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private void timer1_Tick(object sender, EventArgs e)
        {
            CPUBar.Value = (int)CPU.NextValue();
            CPUBar.Text = " " + CPUBar.Value.ToString() + "%";
            RAMBar.Value = (int)RAM.NextValue();
            RAMBar.Text = RAMBar.Value.ToString() + "%";
        }
    }
}
