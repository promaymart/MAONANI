namespace Inventory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1558, 102);
            this.panel2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 42);
            this.label9.TabIndex = 7;
            this.label9.Text = "CRUD SYSTEM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(51, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ngalan sa user";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(73, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Position";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(179)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(12, 453);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(228, 40);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(179)))));
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(12, 526);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(228, 40);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStockOut
            // 
            this.btnStockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(206)))), ((int)(((byte)(244)))));
            this.btnStockOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockOut.FlatAppearance.BorderSize = 0;
            this.btnStockOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnStockOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockOut.Location = new System.Drawing.Point(12, 376);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(228, 40);
            this.btnStockOut.TabIndex = 3;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockOut.UseVisualStyleBackColor = false;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(206)))), ((int)(((byte)(244)))));
            this.btnStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnStockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockIn.Location = new System.Drawing.Point(12, 295);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(228, 40);
            this.btnStockIn.TabIndex = 2;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(249)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(12, 213);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(228, 40);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(249)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 132);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(246, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 543);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "F6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1558, 696);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnInventory);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}