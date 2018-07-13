namespace cappuccino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxBanner = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DrinkLabel = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCalcPrice = new System.Windows.Forms.Button();
            this.btnOneShot = new System.Windows.Forms.RadioButton();
            this.btnTwoShot = new System.Windows.Forms.RadioButton();
            this.btnThreeShot = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSmallSize = new System.Windows.Forms.RadioButton();
            this.btnRegularSize = new System.Windows.Forms.RadioButton();
            this.btnLargeSize = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cappuccinoBtn = new System.Windows.Forms.RadioButton();
            this.darkBtn = new System.Windows.Forms.RadioButton();
            this.lightBtn = new System.Windows.Forms.RadioButton();
            this.espressoBtn = new System.Windows.Forms.RadioButton();
            this.frenchBtn = new System.Windows.Forms.RadioButton();
            this.chocolateBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxCoffee = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanner)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCoffee)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxBanner
            // 
            this.picBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBanner.Image")));
            this.picBoxBanner.Location = new System.Drawing.Point(9, 1);
            this.picBoxBanner.Name = "picBoxBanner";
            this.picBoxBanner.Size = new System.Drawing.Size(662, 94);
            this.picBoxBanner.TabIndex = 0;
            this.picBoxBanner.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // DrinkLabel
            // 
            this.DrinkLabel.AutoSize = true;
            this.DrinkLabel.Location = new System.Drawing.Point(12, 2);
            this.DrinkLabel.Name = "DrinkLabel";
            this.DrinkLabel.Size = new System.Drawing.Size(155, 13);
            this.DrinkLabel.TabIndex = 6;
            this.DrinkLabel.Text = "An Espresso with steamed milk.";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(277, 323);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // btnCalcPrice
            // 
            this.btnCalcPrice.Location = new System.Drawing.Point(196, 323);
            this.btnCalcPrice.Name = "btnCalcPrice";
            this.btnCalcPrice.Size = new System.Drawing.Size(75, 23);
            this.btnCalcPrice.TabIndex = 12;
            this.btnCalcPrice.Text = "Calculate Price";
            this.btnCalcPrice.UseVisualStyleBackColor = true;
            this.btnCalcPrice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOneShot
            // 
            this.btnOneShot.AutoSize = true;
            this.btnOneShot.Location = new System.Drawing.Point(16, 31);
            this.btnOneShot.Name = "btnOneShot";
            this.btnOneShot.Size = new System.Drawing.Size(45, 17);
            this.btnOneShot.TabIndex = 17;
            this.btnOneShot.TabStop = true;
            this.btnOneShot.Text = "One";
            this.btnOneShot.UseVisualStyleBackColor = true;
            // 
            // btnTwoShot
            // 
            this.btnTwoShot.AutoSize = true;
            this.btnTwoShot.Location = new System.Drawing.Point(16, 54);
            this.btnTwoShot.Name = "btnTwoShot";
            this.btnTwoShot.Size = new System.Drawing.Size(46, 17);
            this.btnTwoShot.TabIndex = 18;
            this.btnTwoShot.TabStop = true;
            this.btnTwoShot.Text = "Two";
            this.btnTwoShot.UseVisualStyleBackColor = true;
            // 
            // btnThreeShot
            // 
            this.btnThreeShot.AutoSize = true;
            this.btnThreeShot.Location = new System.Drawing.Point(16, 77);
            this.btnThreeShot.Name = "btnThreeShot";
            this.btnThreeShot.Size = new System.Drawing.Size(53, 17);
            this.btnThreeShot.TabIndex = 19;
            this.btnThreeShot.TabStop = true;
            this.btnThreeShot.Text = "Three";
            this.btnThreeShot.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThreeShot);
            this.groupBox1.Controls.Add(this.btnTwoShot);
            this.groupBox1.Controls.Add(this.btnOneShot);
            this.groupBox1.Location = new System.Drawing.Point(478, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 105);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shots of Espresso";
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // btnSmallSize
            // 
            this.btnSmallSize.AutoSize = true;
            this.btnSmallSize.Location = new System.Drawing.Point(10, 19);
            this.btnSmallSize.Name = "btnSmallSize";
            this.btnSmallSize.Size = new System.Drawing.Size(50, 17);
            this.btnSmallSize.TabIndex = 13;
            this.btnSmallSize.TabStop = true;
            this.btnSmallSize.Text = "Small";
            this.btnSmallSize.UseVisualStyleBackColor = true;
            // 
            // btnRegularSize
            // 
            this.btnRegularSize.AutoSize = true;
            this.btnRegularSize.Location = new System.Drawing.Point(10, 42);
            this.btnRegularSize.Name = "btnRegularSize";
            this.btnRegularSize.Size = new System.Drawing.Size(62, 17);
            this.btnRegularSize.TabIndex = 14;
            this.btnRegularSize.TabStop = true;
            this.btnRegularSize.Text = "Regular";
            this.btnRegularSize.UseVisualStyleBackColor = true;
            // 
            // btnLargeSize
            // 
            this.btnLargeSize.AutoSize = true;
            this.btnLargeSize.Location = new System.Drawing.Point(10, 65);
            this.btnLargeSize.Name = "btnLargeSize";
            this.btnLargeSize.Size = new System.Drawing.Size(52, 17);
            this.btnLargeSize.TabIndex = 15;
            this.btnLargeSize.TabStop = true;
            this.btnLargeSize.Text = "Large";
            this.btnLargeSize.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLargeSize);
            this.groupBox2.Controls.Add(this.btnRegularSize);
            this.groupBox2.Controls.Add(this.btnSmallSize);
            this.groupBox2.Location = new System.Drawing.Point(60, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 105);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            this.groupBox2.VisibleChanged += new System.EventHandler(this.groupBox2_VisibleChanged);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            this.groupBox2.Leave += new System.EventHandler(this.groupBox2_Leave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 543);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(639, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(187, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 193);
            this.panel1.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cappuccinoBtn
            // 
            this.cappuccinoBtn.AutoSize = true;
            this.cappuccinoBtn.Location = new System.Drawing.Point(70, 101);
            this.cappuccinoBtn.Name = "cappuccinoBtn";
            this.cappuccinoBtn.Size = new System.Drawing.Size(82, 17);
            this.cappuccinoBtn.TabIndex = 31;
            this.cappuccinoBtn.TabStop = true;
            this.cappuccinoBtn.Text = "Cappuccino";
            this.cappuccinoBtn.UseVisualStyleBackColor = true;
            this.cappuccinoBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cappuccinoBtn_MouseClick);
            // 
            // darkBtn
            // 
            this.darkBtn.AutoSize = true;
            this.darkBtn.Location = new System.Drawing.Point(158, 101);
            this.darkBtn.Name = "darkBtn";
            this.darkBtn.Size = new System.Drawing.Size(79, 17);
            this.darkBtn.TabIndex = 32;
            this.darkBtn.TabStop = true;
            this.darkBtn.Text = "Dark Roast";
            this.darkBtn.UseVisualStyleBackColor = true;
            this.darkBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.darkBtn_MouseClick);
            // 
            // lightBtn
            // 
            this.lightBtn.AutoSize = true;
            this.lightBtn.Location = new System.Drawing.Point(243, 101);
            this.lightBtn.Name = "lightBtn";
            this.lightBtn.Size = new System.Drawing.Size(79, 17);
            this.lightBtn.TabIndex = 33;
            this.lightBtn.TabStop = true;
            this.lightBtn.Text = "Light Roast";
            this.lightBtn.UseVisualStyleBackColor = true;
            this.lightBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lightBtn_MouseClick);
            // 
            // espressoBtn
            // 
            this.espressoBtn.AutoSize = true;
            this.espressoBtn.Location = new System.Drawing.Point(328, 101);
            this.espressoBtn.Name = "espressoBtn";
            this.espressoBtn.Size = new System.Drawing.Size(68, 17);
            this.espressoBtn.TabIndex = 34;
            this.espressoBtn.TabStop = true;
            this.espressoBtn.Text = "Espresso";
            this.espressoBtn.UseVisualStyleBackColor = true;
            this.espressoBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.espressoBtn_MouseClick);
            // 
            // frenchBtn
            // 
            this.frenchBtn.AutoSize = true;
            this.frenchBtn.Location = new System.Drawing.Point(402, 101);
            this.frenchBtn.Name = "frenchBtn";
            this.frenchBtn.Size = new System.Drawing.Size(89, 17);
            this.frenchBtn.TabIndex = 35;
            this.frenchBtn.TabStop = true;
            this.frenchBtn.Text = "French Roast";
            this.frenchBtn.UseVisualStyleBackColor = true;
            this.frenchBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frenchBtn_MouseClick);
            // 
            // chocolateBtn
            // 
            this.chocolateBtn.AutoSize = true;
            this.chocolateBtn.Location = new System.Drawing.Point(494, 101);
            this.chocolateBtn.Name = "chocolateBtn";
            this.chocolateBtn.Size = new System.Drawing.Size(93, 17);
            this.chocolateBtn.TabIndex = 36;
            this.chocolateBtn.TabStop = true;
            this.chocolateBtn.Text = "Hot Chocolate";
            this.chocolateBtn.UseVisualStyleBackColor = true;
            this.chocolateBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chocolateBtn_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DrinkLabel);
            this.panel2.Location = new System.Drawing.Point(262, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 18);
            this.panel2.TabIndex = 37;
            // 
            // picBoxCoffee
            // 
            this.picBoxCoffee.Location = new System.Drawing.Point(79, 410);
            this.picBoxCoffee.Name = "picBoxCoffee";
            this.picBoxCoffee.Size = new System.Drawing.Size(534, 133);
            this.picBoxCoffee.TabIndex = 38;
            this.picBoxCoffee.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Location = new System.Drawing.Point(674, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 561);
            this.panel3.TabIndex = 39;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(28, 460);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(283, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCheckout.Location = new System.Drawing.Point(8, 497);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(323, 52);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 578);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.picBoxCoffee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chocolateBtn);
            this.Controls.Add(this.frenchBtn);
            this.Controls.Add(this.espressoBtn);
            this.Controls.Add(this.lightBtn);
            this.Controls.Add(this.darkBtn);
            this.Controls.Add(this.cappuccinoBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBoxBanner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCoffee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBanner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DrinkLabel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalcPrice;
        private System.Windows.Forms.RadioButton btnOneShot;
        private System.Windows.Forms.RadioButton btnTwoShot;
        private System.Windows.Forms.RadioButton btnThreeShot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnSmallSize;
        private System.Windows.Forms.RadioButton btnRegularSize;
        private System.Windows.Forms.RadioButton btnLargeSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton cappuccinoBtn;
        private System.Windows.Forms.RadioButton darkBtn;
        private System.Windows.Forms.RadioButton lightBtn;
        private System.Windows.Forms.RadioButton espressoBtn;
        private System.Windows.Forms.RadioButton frenchBtn;
        private System.Windows.Forms.RadioButton chocolateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxCoffee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

