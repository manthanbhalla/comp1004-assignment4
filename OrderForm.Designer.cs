namespace Assignment4
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.platformBox = new System.Windows.Forms.TextBox();
            this.conditionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.webcamBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GPUtypeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.OSBox = new System.Windows.Forms.TextBox();
            this.HDD_sizeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CPUspeedBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CPU_numberBox = new System.Windows.Forms.TextBox();
            this.lcdsizeBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CPU_typeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CPU_brandBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RAMsizeBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SalesTaxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(687, 24);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip1";
            this.menuStrip2.Click += new System.EventHandler(this.fileButton);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printButton);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cancelButton);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backButton);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutButton);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.label5);
            this.ProductInfoGroupBox.Controls.Add(this.label7);
            this.ProductInfoGroupBox.Controls.Add(this.manufacturerBox);
            this.ProductInfoGroupBox.Controls.Add(this.label4);
            this.ProductInfoGroupBox.Controls.Add(this.modelBox);
            this.ProductInfoGroupBox.Controls.Add(this.platformBox);
            this.ProductInfoGroupBox.Controls.Add(this.conditionBox);
            this.ProductInfoGroupBox.Controls.Add(this.label2);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 44);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(409, 76);
            this.ProductInfoGroupBox.TabIndex = 21;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Manufacturer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Model";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Location = new System.Drawing.Point(78, 45);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.ReadOnly = true;
            this.manufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Platform";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(249, 45);
            this.modelBox.Name = "modelBox";
            this.modelBox.ReadOnly = true;
            this.modelBox.Size = new System.Drawing.Size(148, 20);
            this.modelBox.TabIndex = 15;
            // 
            // platformBox
            // 
            this.platformBox.Location = new System.Drawing.Point(249, 19);
            this.platformBox.Name = "platformBox";
            this.platformBox.ReadOnly = true;
            this.platformBox.Size = new System.Drawing.Size(148, 20);
            this.platformBox.TabIndex = 9;
            // 
            // conditionBox
            // 
            this.conditionBox.Location = new System.Drawing.Point(78, 19);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.ReadOnly = true;
            this.conditionBox.Size = new System.Drawing.Size(100, 20);
            this.conditionBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Condition";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.label14);
            this.TechSpecsGroupBox.Controls.Add(this.webcamBox);
            this.TechSpecsGroupBox.Controls.Add(this.label6);
            this.TechSpecsGroupBox.Controls.Add(this.label15);
            this.TechSpecsGroupBox.Controls.Add(this.GPUtypeBox);
            this.TechSpecsGroupBox.Controls.Add(this.label16);
            this.TechSpecsGroupBox.Controls.Add(this.OSBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDD_sizeBox);
            this.TechSpecsGroupBox.Controls.Add(this.label11);
            this.TechSpecsGroupBox.Controls.Add(this.CPUspeedBox);
            this.TechSpecsGroupBox.Controls.Add(this.label12);
            this.TechSpecsGroupBox.Controls.Add(this.CPU_numberBox);
            this.TechSpecsGroupBox.Controls.Add(this.lcdsizeBox);
            this.TechSpecsGroupBox.Controls.Add(this.label13);
            this.TechSpecsGroupBox.Controls.Add(this.label10);
            this.TechSpecsGroupBox.Controls.Add(this.CPU_typeBox);
            this.TechSpecsGroupBox.Controls.Add(this.label9);
            this.TechSpecsGroupBox.Controls.Add(this.CPU_brandBox);
            this.TechSpecsGroupBox.Controls.Add(this.label8);
            this.TechSpecsGroupBox.Controls.Add(this.RAMsizeBox);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 135);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(409, 197);
            this.TechSpecsGroupBox.TabIndex = 22;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "WebCam";
            // 
            // webcamBox
            // 
            this.webcamBox.Location = new System.Drawing.Point(249, 45);
            this.webcamBox.Name = "webcamBox";
            this.webcamBox.ReadOnly = true;
            this.webcamBox.Size = new System.Drawing.Size(148, 20);
            this.webcamBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "OS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "GPU Type";
            // 
            // GPUtypeBox
            // 
            this.GPUtypeBox.Location = new System.Drawing.Point(78, 138);
            this.GPUtypeBox.Name = "GPUtypeBox";
            this.GPUtypeBox.ReadOnly = true;
            this.GPUtypeBox.Size = new System.Drawing.Size(319, 20);
            this.GPUtypeBox.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "HDD";
            // 
            // OSBox
            // 
            this.OSBox.Location = new System.Drawing.Point(78, 164);
            this.OSBox.Name = "OSBox";
            this.OSBox.ReadOnly = true;
            this.OSBox.Size = new System.Drawing.Size(319, 20);
            this.OSBox.TabIndex = 13;
            // 
            // HDD_sizeBox
            // 
            this.HDD_sizeBox.Location = new System.Drawing.Point(249, 19);
            this.HDD_sizeBox.Name = "HDD_sizeBox";
            this.HDD_sizeBox.ReadOnly = true;
            this.HDD_sizeBox.Size = new System.Drawing.Size(148, 20);
            this.HDD_sizeBox.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "CPU Speed";
            // 
            // CPUspeedBox
            // 
            this.CPUspeedBox.Location = new System.Drawing.Point(78, 97);
            this.CPUspeedBox.Name = "CPUspeedBox";
            this.CPUspeedBox.ReadOnly = true;
            this.CPUspeedBox.Size = new System.Drawing.Size(72, 20);
            this.CPUspeedBox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "CPU Number";
            // 
            // CPU_numberBox
            // 
            this.CPU_numberBox.Location = new System.Drawing.Point(78, 71);
            this.CPU_numberBox.Name = "CPU_numberBox";
            this.CPU_numberBox.ReadOnly = true;
            this.CPU_numberBox.Size = new System.Drawing.Size(72, 20);
            this.CPU_numberBox.TabIndex = 25;
            // 
            // lcdsizeBox
            // 
            this.lcdsizeBox.Location = new System.Drawing.Point(249, 71);
            this.lcdsizeBox.Name = "lcdsizeBox";
            this.lcdsizeBox.ReadOnly = true;
            this.lcdsizeBox.Size = new System.Drawing.Size(148, 20);
            this.lcdsizeBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "LCD Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CPU Type";
            // 
            // CPU_typeBox
            // 
            this.CPU_typeBox.Location = new System.Drawing.Point(78, 45);
            this.CPU_typeBox.Name = "CPU_typeBox";
            this.CPU_typeBox.ReadOnly = true;
            this.CPU_typeBox.Size = new System.Drawing.Size(72, 20);
            this.CPU_typeBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "CPU Brand";
            // 
            // CPU_brandBox
            // 
            this.CPU_brandBox.Location = new System.Drawing.Point(78, 19);
            this.CPU_brandBox.Name = "CPU_brandBox";
            this.CPU_brandBox.ReadOnly = true;
            this.CPU_brandBox.Size = new System.Drawing.Size(72, 20);
            this.CPU_brandBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Memory";
            // 
            // RAMsizeBox
            // 
            this.RAMsizeBox.Location = new System.Drawing.Point(249, 97);
            this.RAMsizeBox.Name = "RAMsizeBox";
            this.RAMsizeBox.ReadOnly = true;
            this.RAMsizeBox.Size = new System.Drawing.Size(148, 20);
            this.RAMsizeBox.TabIndex = 17;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(450, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(116, 116);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 27;
            this.pictureBox.TabStop = false;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalBox);
            this.PriceGroupBox.Controls.Add(this.label17);
            this.PriceGroupBox.Controls.Add(this.SalesTaxBox);
            this.PriceGroupBox.Controls.Add(this.label1);
            this.PriceGroupBox.Controls.Add(this.costBox);
            this.PriceGroupBox.Controls.Add(this.label3);
            this.PriceGroupBox.Location = new System.Drawing.Point(450, 183);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(226, 114);
            this.PriceGroupBox.TabIndex = 28;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(120, 88);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(100, 20);
            this.TotalBox.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Total";
            // 
            // SalesTaxBox
            // 
            this.SalesTaxBox.Location = new System.Drawing.Point(120, 46);
            this.SalesTaxBox.Name = "SalesTaxBox";
            this.SalesTaxBox.ReadOnly = true;
            this.SalesTaxBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sales Tax (13%)";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(120, 23);
            this.costBox.Name = "costBox";
            this.costBox.ReadOnly = true;
            this.costBox.Size = new System.Drawing.Size(100, 20);
            this.costBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(508, 309);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 30;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.cancelButton);
            // 
            // Finishbutton
            // 
            this.Finishbutton.Location = new System.Drawing.Point(589, 309);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(75, 23);
            this.Finishbutton.TabIndex = 31;
            this.Finishbutton.Text = "Finish";
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.finishButton);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 360);
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox platformBox;
        private System.Windows.Forms.TextBox conditionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox webcamBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox GPUtypeBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox OSBox;
        private System.Windows.Forms.TextBox HDD_sizeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CPUspeedBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CPU_numberBox;
        private System.Windows.Forms.TextBox lcdsizeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CPU_typeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CPU_brandBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RAMsizeBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SalesTaxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Finishbutton;
    }
}