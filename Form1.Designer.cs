namespace InfoMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnMOTHER = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnGRAPHICS = new System.Windows.Forms.Button();
            this.btnSTORAGE = new System.Windows.Forms.Button();
            this.btnRES = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelResources = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RAMBar = new CircularProgressBar.CircularProgressBar();
            this.CPUBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnOther);
            this.panelMenu.Controls.Add(this.btnMOTHER);
            this.panelMenu.Controls.Add(this.btnCPU);
            this.panelMenu.Controls.Add(this.btnGRAPHICS);
            this.panelMenu.Controls.Add(this.btnSTORAGE);
            this.panelMenu.Controls.Add(this.btnRES);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOther
            // 
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOther.Image = global::InfoMonitor.Properties.Resources.stream_solid;
            this.btnOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOther.Location = new System.Drawing.Point(0, 380);
            this.btnOther.Name = "btnOther";
            this.btnOther.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOther.Size = new System.Drawing.Size(220, 60);
            this.btnOther.TabIndex = 6;
            this.btnOther.Text = "    Other Information";
            this.btnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnMOTHER
            // 
            this.btnMOTHER.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMOTHER.FlatAppearance.BorderSize = 0;
            this.btnMOTHER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMOTHER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMOTHER.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMOTHER.Image = global::InfoMonitor.Properties.Resources.memory_solid;
            this.btnMOTHER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMOTHER.Location = new System.Drawing.Point(0, 320);
            this.btnMOTHER.Name = "btnMOTHER";
            this.btnMOTHER.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMOTHER.Size = new System.Drawing.Size(220, 60);
            this.btnMOTHER.TabIndex = 5;
            this.btnMOTHER.Text = "       Motherboard         Information";
            this.btnMOTHER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMOTHER.UseVisualStyleBackColor = true;
            this.btnMOTHER.Click += new System.EventHandler(this.btnMOTHER_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCPU.Image = global::InfoMonitor.Properties.Resources.microchip_solid1;
            this.btnCPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPU.Location = new System.Drawing.Point(0, 260);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCPU.Size = new System.Drawing.Size(220, 60);
            this.btnCPU.TabIndex = 4;
            this.btnCPU.Text = "          Processor            Information";
            this.btnCPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnGRAPHICS
            // 
            this.btnGRAPHICS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGRAPHICS.FlatAppearance.BorderSize = 0;
            this.btnGRAPHICS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGRAPHICS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRAPHICS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGRAPHICS.Image = global::InfoMonitor.Properties.Resources.desktop_solid;
            this.btnGRAPHICS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGRAPHICS.Location = new System.Drawing.Point(0, 200);
            this.btnGRAPHICS.Name = "btnGRAPHICS";
            this.btnGRAPHICS.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGRAPHICS.Size = new System.Drawing.Size(220, 60);
            this.btnGRAPHICS.TabIndex = 3;
            this.btnGRAPHICS.Text = "           Graphics              Information";
            this.btnGRAPHICS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGRAPHICS.UseVisualStyleBackColor = true;
            this.btnGRAPHICS.Click += new System.EventHandler(this.btnGRAPHICS_Click);
            // 
            // btnSTORAGE
            // 
            this.btnSTORAGE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSTORAGE.FlatAppearance.BorderSize = 0;
            this.btnSTORAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTORAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTORAGE.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSTORAGE.Image = global::InfoMonitor.Properties.Resources.hdd_solid;
            this.btnSTORAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTORAGE.Location = new System.Drawing.Point(0, 140);
            this.btnSTORAGE.Name = "btnSTORAGE";
            this.btnSTORAGE.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSTORAGE.Size = new System.Drawing.Size(220, 60);
            this.btnSTORAGE.TabIndex = 2;
            this.btnSTORAGE.Text = "            Storage               Information";
            this.btnSTORAGE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSTORAGE.UseVisualStyleBackColor = true;
            this.btnSTORAGE.Click += new System.EventHandler(this.btnSTORAGE_Click);
            // 
            // btnRES
            // 
            this.btnRES.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRES.FlatAppearance.BorderSize = 0;
            this.btnRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRES.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRES.Image = global::InfoMonitor.Properties.Resources.chart_line_solid;
            this.btnRES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRES.Location = new System.Drawing.Point(0, 80);
            this.btnRES.Name = "btnRES";
            this.btnRES.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRES.Size = new System.Drawing.Size(220, 60);
            this.btnRES.TabIndex = 1;
            this.btnRES.Text = "          Resources           Monitor";
            this.btnRES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRES.UseVisualStyleBackColor = true;
            this.btnRES.Click += new System.EventHandler(this.btnRES_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Monitor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1044, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(438, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelResources
            // 
            this.panelResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResources.AutoSize = true;
            this.panelResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelResources.Controls.Add(this.label3);
            this.panelResources.Controls.Add(this.label2);
            this.panelResources.Controls.Add(this.RAMBar);
            this.panelResources.Controls.Add(this.CPUBar);
            this.panelResources.Location = new System.Drawing.Point(220, 80);
            this.panelResources.Name = "panelResources";
            this.panelResources.Size = new System.Drawing.Size(1044, 601);
            this.panelResources.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(746, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "RAM";
            // 
            // RAMBar
            // 
            this.RAMBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RAMBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.RAMBar.AnimationSpeed = 400;
            this.RAMBar.BackColor = System.Drawing.Color.Transparent;
            this.RAMBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.RAMBar.ForeColor = System.Drawing.Color.White;
            this.RAMBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RAMBar.InnerMargin = 2;
            this.RAMBar.InnerWidth = -1;
            this.RAMBar.Location = new System.Drawing.Point(100, 120);
            this.RAMBar.MarqueeAnimationSpeed = 1000;
            this.RAMBar.Name = "RAMBar";
            this.RAMBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RAMBar.OuterMargin = -25;
            this.RAMBar.OuterWidth = 10;
            this.RAMBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RAMBar.ProgressWidth = 30;
            this.RAMBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.RAMBar.Size = new System.Drawing.Size(320, 320);
            this.RAMBar.StartAngle = 270;
            this.RAMBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RAMBar.SubscriptColor = System.Drawing.Color.Black;
            this.RAMBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.RAMBar.SubscriptText = "";
            this.RAMBar.SuperscriptColor = System.Drawing.Color.Black;
            this.RAMBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.RAMBar.SuperscriptText = "";
            this.RAMBar.TabIndex = 1;
            this.RAMBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.RAMBar.Value = 68;
            // 
            // CPUBar
            // 
            this.CPUBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPUBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPUBar.AnimationSpeed = 400;
            this.CPUBar.BackColor = System.Drawing.Color.Transparent;
            this.CPUBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.CPUBar.ForeColor = System.Drawing.Color.White;
            this.CPUBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.CPUBar.InnerMargin = 2;
            this.CPUBar.InnerWidth = -1;
            this.CPUBar.Location = new System.Drawing.Point(620, 120);
            this.CPUBar.MarqueeAnimationSpeed = 1000;
            this.CPUBar.Name = "CPUBar";
            this.CPUBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CPUBar.OuterMargin = -25;
            this.CPUBar.OuterWidth = 10;
            this.CPUBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CPUBar.ProgressWidth = 30;
            this.CPUBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPUBar.Size = new System.Drawing.Size(320, 320);
            this.CPUBar.StartAngle = 270;
            this.CPUBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CPUBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPUBar.SubscriptText = "";
            this.CPUBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPUBar.SuperscriptText = "";
            this.CPUBar.TabIndex = 1;
            this.CPUBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPUBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelResources);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelResources.ResumeLayout(false);
            this.panelResources.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRES;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnMOTHER;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnGRAPHICS;
        private System.Windows.Forms.Button btnSTORAGE;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResources;
        private CircularProgressBar.CircularProgressBar CPUBar;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar RAMBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

