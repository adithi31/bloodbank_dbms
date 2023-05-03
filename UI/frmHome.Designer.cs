namespace WindowsFormsApp4.UI
{
    partial class frmHome
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpositiveCount = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApositiveCount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.lblAnegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblONegative = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegativeCount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblABpositiveCount = new System.Windows.Forms.Label();
            this.lblABpositive = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBpositiveCount = new System.Windows.Forms.Label();
            this.lblBpositive = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem,
            this.patientToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 2, 0, 6);
            this.menuStripTop.Size = new System.Drawing.Size(793, 27);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFooter.Controls.Add(this.label5);
            this.panelFooter.Controls.Add(this.label3);
            this.panelFooter.Controls.Add(this.label2);
            this.panelFooter.Controls.Add(this.lblDevTitle);
            this.panelFooter.Controls.Add(this.lblAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 371);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(793, 32);
            this.panelFooter.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "__";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(90, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "BLOOD BANK MANAGEMENT SYSTEM";
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevTitle.Location = new System.Drawing.Point(374, 9);
            this.lblDevTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(80, 15);
            this.lblDevTitle.TabIndex = 2;
            this.lblDevTitle.Text = "Developed by";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAppName.Location = new System.Drawing.Point(498, 6);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(122, 21);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Team SpiceGen";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOpositive.Controls.Add(this.lblName);
            this.panelOpositive.Controls.Add(this.lblOpositiveCount);
            this.panelOpositive.Controls.Add(this.lblBloodGroup);
            this.panelOpositive.Location = new System.Drawing.Point(231, 41);
            this.panelOpositive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(134, 65);
            this.panelOpositive.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 38);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Donors";
            // 
            // lblOpositiveCount
            // 
            this.lblOpositiveCount.AutoSize = true;
            this.lblOpositiveCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOpositiveCount.Location = new System.Drawing.Point(72, 2);
            this.lblOpositiveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpositiveCount.Name = "lblOpositiveCount";
            this.lblOpositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblOpositiveCount.TabIndex = 8;
            this.lblOpositiveCount.Text = "100";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBloodGroup.Location = new System.Drawing.Point(2, 8);
            this.lblBloodGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(78, 51);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblApositiveCount);
            this.panel1.Controls.Add(this.lblApositive);
            this.panel1.Location = new System.Drawing.Point(231, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 65);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            this.lblApositiveCount.AutoSize = true;
            this.lblApositiveCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblApositiveCount.Location = new System.Drawing.Point(72, 2);
            this.lblApositiveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApositiveCount.Name = "lblApositiveCount";
            this.lblApositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblApositiveCount.TabIndex = 8;
            this.lblApositiveCount.Text = "100";
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblApositive.Location = new System.Drawing.Point(2, 10);
            this.lblApositive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(76, 51);
            this.lblApositive.TabIndex = 0;
            this.lblApositive.Text = "A+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAnegativeCount);
            this.panel2.Controls.Add(this.lblAnegative);
            this.panel2.Location = new System.Drawing.Point(415, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 65);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Donors";
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnegativeCount.Location = new System.Drawing.Point(72, 2);
            this.lblAnegativeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblAnegativeCount.TabIndex = 8;
            this.lblAnegativeCount.Text = "100";
            // 
            // lblAnegative
            // 
            this.lblAnegative.AutoSize = true;
            this.lblAnegative.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnegative.Location = new System.Drawing.Point(2, 10);
            this.lblAnegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnegative.Name = "lblAnegative";
            this.lblAnegative.Size = new System.Drawing.Size(64, 51);
            this.lblAnegative.TabIndex = 0;
            this.lblAnegative.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblOnegativeCount);
            this.panel3.Controls.Add(this.lblONegative);
            this.panel3.Location = new System.Drawing.Point(415, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 65);
            this.panel3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOnegativeCount.Location = new System.Drawing.Point(72, 2);
            this.lblOnegativeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblOnegativeCount.TabIndex = 8;
            this.lblOnegativeCount.Text = "100";
            // 
            // lblONegative
            // 
            this.lblONegative.AutoSize = true;
            this.lblONegative.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblONegative.Location = new System.Drawing.Point(2, 8);
            this.lblONegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblONegative.Name = "lblONegative";
            this.lblONegative.Size = new System.Drawing.Size(66, 51);
            this.lblONegative.TabIndex = 0;
            this.lblONegative.Text = "O-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABnegativeCount);
            this.panel4.Controls.Add(this.lblABnegative);
            this.panel4.Location = new System.Drawing.Point(415, 296);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 65);
            this.panel4.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            this.lblABnegativeCount.AutoSize = true;
            this.lblABnegativeCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABnegativeCount.Location = new System.Drawing.Point(80, 4);
            this.lblABnegativeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABnegativeCount.Name = "lblABnegativeCount";
            this.lblABnegativeCount.Size = new System.Drawing.Size(49, 30);
            this.lblABnegativeCount.TabIndex = 8;
            this.lblABnegativeCount.Text = "100";
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABnegative.Location = new System.Drawing.Point(0, 7);
            this.lblABnegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(81, 47);
            this.lblABnegative.TabIndex = 0;
            this.lblABnegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblBnegativeCount);
            this.panel5.Controls.Add(this.lblBnegative);
            this.panel5.Location = new System.Drawing.Point(415, 209);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 65);
            this.panel5.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(82, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBnegativeCount.Location = new System.Drawing.Point(72, 2);
            this.lblBnegativeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblBnegativeCount.TabIndex = 8;
            this.lblBnegativeCount.Text = "100";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBnegative.Location = new System.Drawing.Point(2, 10);
            this.lblBnegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(61, 51);
            this.lblBnegative.TabIndex = 0;
            this.lblBnegative.Text = "B-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblABpositiveCount);
            this.panel6.Controls.Add(this.lblABpositive);
            this.panel6.Location = new System.Drawing.Point(231, 296);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 65);
            this.panel6.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(88, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Donors";
            // 
            // lblABpositiveCount
            // 
            this.lblABpositiveCount.AutoSize = true;
            this.lblABpositiveCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABpositiveCount.Location = new System.Drawing.Point(80, 2);
            this.lblABpositiveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABpositiveCount.Name = "lblABpositiveCount";
            this.lblABpositiveCount.Size = new System.Drawing.Size(53, 32);
            this.lblABpositiveCount.TabIndex = 8;
            this.lblABpositiveCount.Text = "100";
            // 
            // lblABpositive
            // 
            this.lblABpositive.AutoSize = true;
            this.lblABpositive.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABpositive.Location = new System.Drawing.Point(2, 7);
            this.lblABpositive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABpositive.Name = "lblABpositive";
            this.lblABpositive.Size = new System.Drawing.Size(92, 47);
            this.lblABpositive.TabIndex = 0;
            this.lblABpositive.Text = "AB+";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBpositiveCount);
            this.panel7.Controls.Add(this.lblBpositive);
            this.panel7.Location = new System.Drawing.Point(231, 209);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(134, 65);
            this.panel7.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(82, 38);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            this.lblBpositiveCount.AutoSize = true;
            this.lblBpositiveCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositiveCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBpositiveCount.Location = new System.Drawing.Point(72, 2);
            this.lblBpositiveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBpositiveCount.Name = "lblBpositiveCount";
            this.lblBpositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblBpositiveCount.TabIndex = 8;
            this.lblBpositiveCount.Text = "100";
            // 
            // lblBpositive
            // 
            this.lblBpositive.AutoSize = true;
            this.lblBpositive.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBpositive.Location = new System.Drawing.Point(2, 10);
            this.lblBpositive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBpositive.Name = "lblBpositive";
            this.lblBpositive.Size = new System.Drawing.Size(73, 51);
            this.lblBpositive.TabIndex = 0;
            this.lblBpositive.Text = "B+";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(722, 6);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(60, 21);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(793, 403);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblOpositiveCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApositiveCount;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.Label lblAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblONegative;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegativeCount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblABpositiveCount;
        private System.Windows.Forms.Label lblABpositive;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBpositiveCount;
        private System.Windows.Forms.Label lblBpositive;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
    }
}