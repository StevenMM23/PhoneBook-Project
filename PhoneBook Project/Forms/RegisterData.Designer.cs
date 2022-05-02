namespace PhoneBook_Project.Forms
{
    partial class RegisterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterData));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.InformationGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.Fnametxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.TelTxt = new System.Windows.Forms.TextBox();
            this.Celltxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.commentxt = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.InformationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 57);
            this.toolStripButton1.Text = "New Data";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(105, 57);
            this.toolStripButton2.Text = "Save (F5)";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // InformationGroup
            // 
            this.InformationGroup.Controls.Add(this.commentxt);
            this.InformationGroup.Controls.Add(this.Addresstxt);
            this.InformationGroup.Controls.Add(this.Emailtxt);
            this.InformationGroup.Controls.Add(this.Celltxt);
            this.InformationGroup.Controls.Add(this.TelTxt);
            this.InformationGroup.Controls.Add(this.LastNametxt);
            this.InformationGroup.Controls.Add(this.Fnametxt);
            this.InformationGroup.Controls.Add(this.idtxt);
            this.InformationGroup.Controls.Add(this.label8);
            this.InformationGroup.Controls.Add(this.label7);
            this.InformationGroup.Controls.Add(this.label6);
            this.InformationGroup.Controls.Add(this.label5);
            this.InformationGroup.Controls.Add(this.label4);
            this.InformationGroup.Controls.Add(this.label3);
            this.InformationGroup.Controls.Add(this.label2);
            this.InformationGroup.Controls.Add(this.label1);
            this.InformationGroup.Enabled = false;
            this.InformationGroup.Location = new System.Drawing.Point(27, 73);
            this.InformationGroup.Name = "InformationGroup";
            this.InformationGroup.Size = new System.Drawing.Size(505, 494);
            this.InformationGroup.TabIndex = 1;
            this.InformationGroup.TabStop = false;
            this.InformationGroup.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cell Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Comment:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(131, 41);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(293, 22);
            this.idtxt.TabIndex = 8;
            // 
            // Fnametxt
            // 
            this.Fnametxt.Location = new System.Drawing.Point(131, 90);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(293, 22);
            this.Fnametxt.TabIndex = 9;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(131, 139);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(293, 22);
            this.LastNametxt.TabIndex = 10;
            // 
            // TelTxt
            // 
            this.TelTxt.Location = new System.Drawing.Point(131, 188);
            this.TelTxt.Name = "TelTxt";
            this.TelTxt.Size = new System.Drawing.Size(293, 22);
            this.TelTxt.TabIndex = 11;
            // 
            // Celltxt
            // 
            this.Celltxt.Location = new System.Drawing.Point(131, 237);
            this.Celltxt.Name = "Celltxt";
            this.Celltxt.Size = new System.Drawing.Size(293, 22);
            this.Celltxt.TabIndex = 12;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(131, 286);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(293, 22);
            this.Emailtxt.TabIndex = 13;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(131, 335);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(293, 22);
            this.Addresstxt.TabIndex = 14;
            // 
            // commentxt
            // 
            this.commentxt.Location = new System.Drawing.Point(131, 384);
            this.commentxt.Multiline = true;
            this.commentxt.Name = "commentxt";
            this.commentxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentxt.Size = new System.Drawing.Size(348, 70);
            this.commentxt.TabIndex = 15;
            // 
            // RegisterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 592);
            this.Controls.Add(this.InformationGroup);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterData";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.InformationGroup.ResumeLayout(false);
            this.InformationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox InformationGroup;
        private System.Windows.Forms.TextBox commentxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Celltxt;
        private System.Windows.Forms.TextBox TelTxt;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.TextBox Fnametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}