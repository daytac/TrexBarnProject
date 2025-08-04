namespace TrexBarn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBudget = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAnimalAge = new System.Windows.Forms.TextBox();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbWool = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEgg = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pbHoney = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCheese = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheese = new System.Windows.Forms.Label();
            this.lblHoney = new System.Windows.Forms.Label();
            this.lblWool = new System.Windows.Forms.Label();
            this.lblEgg = new System.Windows.Forms.Label();
            this.pbMilk = new System.Windows.Forms.ProgressBar();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProductTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(736, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(458, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.Location = new System.Drawing.Point(72, 207);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(150, 35);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Satın Al";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lblBudget);
            this.panel2.Controls.Add(this.rdbMale);
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Controls.Add(this.rdbFemale);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtAnimalAge);
            this.panel2.Controls.Add(this.cmbAnimalType);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(19, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 319);
            this.panel2.TabIndex = 4;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBudget.Location = new System.Drawing.Point(65, 261);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(77, 37);
            this.lblBudget.TabIndex = 16;
            this.lblBudget.Text = "0000";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbMale.Location = new System.Drawing.Point(196, 176);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(70, 25);
            this.rdbMale.TabIndex = 9;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Erkek";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.BackColor = System.Drawing.Color.DarkGray;
            this.rdbFemale.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbFemale.Location = new System.Drawing.Point(135, 176);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(57, 25);
            this.rdbFemale.TabIndex = 8;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Dişi";
            this.rdbFemale.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cinsiyeti:";
            // 
            // txtAnimalAge
            // 
            this.txtAnimalAge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnimalAge.Location = new System.Drawing.Point(134, 138);
            this.txtAnimalAge.Name = "txtAnimalAge";
            this.txtAnimalAge.Size = new System.Drawing.Size(131, 32);
            this.txtAnimalAge.TabIndex = 6;
            this.txtAnimalAge.Text = "0";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(134, 89);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(131, 32);
            this.cmbAnimalType.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(62, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(68, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Yaşı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 74);
            this.label7.TabIndex = 3;
            this.label7.Text = "Satın Alınacak \r\nHayvanın Özellikleri";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üretim\r\nİlerlemeleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Süt:";
            // 
            // pbWool
            // 
            this.pbWool.Location = new System.Drawing.Point(99, 175);
            this.pbWool.Name = "pbWool";
            this.pbWool.Size = new System.Drawing.Size(172, 32);
            this.pbWool.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yün:";
            // 
            // pbEgg
            // 
            this.pbEgg.Location = new System.Drawing.Point(99, 125);
            this.pbEgg.Name = "pbEgg";
            this.pbEgg.Size = new System.Drawing.Size(172, 32);
            this.pbEgg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yumurta:";
            // 
            // pbHoney
            // 
            this.pbHoney.Location = new System.Drawing.Point(99, 227);
            this.pbHoney.Name = "pbHoney";
            this.pbHoney.Size = new System.Drawing.Size(172, 32);
            this.pbHoney.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bal:";
            // 
            // pbCheese
            // 
            this.pbCheese.Location = new System.Drawing.Point(99, 272);
            this.pbCheese.Name = "pbCheese";
            this.pbCheese.Size = new System.Drawing.Size(172, 32);
            this.pbCheese.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peynir:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(4, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "Satılacak Ürün:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(134, 63);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(138, 32);
            this.cmbProduct.TabIndex = 12;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.DarkGray;
            this.btnSell.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSell.Location = new System.Drawing.Point(549, 59);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(128, 33);
            this.btnSell.TabIndex = 5;
            this.btnSell.Text = "Sat";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(277, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 48);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ürün \r\nSayısı";
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMilk.Location = new System.Drawing.Point(277, 80);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(50, 24);
            this.lblMilk.TabIndex = 14;
            this.lblMilk.Text = "0000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblCheese);
            this.panel1.Controls.Add(this.lblHoney);
            this.panel1.Controls.Add(this.lblWool);
            this.panel1.Controls.Add(this.lblEgg);
            this.panel1.Controls.Add(this.lblMilk);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pbCheese);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pbHoney);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbEgg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbWool);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbMilk);
            this.panel1.Location = new System.Drawing.Point(370, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 319);
            this.panel1.TabIndex = 2;
            // 
            // lblCheese
            // 
            this.lblCheese.AutoSize = true;
            this.lblCheese.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheese.Location = new System.Drawing.Point(281, 274);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.Size = new System.Drawing.Size(50, 24);
            this.lblCheese.TabIndex = 18;
            this.lblCheese.Text = "0000";
            // 
            // lblHoney
            // 
            this.lblHoney.AutoSize = true;
            this.lblHoney.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHoney.Location = new System.Drawing.Point(281, 227);
            this.lblHoney.Name = "lblHoney";
            this.lblHoney.Size = new System.Drawing.Size(50, 24);
            this.lblHoney.TabIndex = 17;
            this.lblHoney.Text = "0000";
            // 
            // lblWool
            // 
            this.lblWool.AutoSize = true;
            this.lblWool.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWool.Location = new System.Drawing.Point(281, 177);
            this.lblWool.Name = "lblWool";
            this.lblWool.Size = new System.Drawing.Size(50, 24);
            this.lblWool.TabIndex = 16;
            this.lblWool.Text = "0000";
            // 
            // lblEgg
            // 
            this.lblEgg.AutoSize = true;
            this.lblEgg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgg.Location = new System.Drawing.Point(281, 126);
            this.lblEgg.Name = "lblEgg";
            this.lblEgg.Size = new System.Drawing.Size(50, 24);
            this.lblEgg.TabIndex = 15;
            this.lblEgg.Text = "0000";
            // 
            // pbMilk
            // 
            this.pbMilk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbMilk.Location = new System.Drawing.Point(99, 78);
            this.pbMilk.Name = "pbMilk";
            this.pbMilk.Size = new System.Drawing.Size(172, 32);
            this.pbMilk.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(278, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 24);
            this.label20.TabIndex = 19;
            this.label20.Text = "Ürün Adedi:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.nudNumber);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.cmbProduct);
            this.panel3.Controls.Add(this.btnSell);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(19, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 117);
            this.panel3.TabIndex = 5;
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudNumber.Location = new System.Drawing.Point(392, 63);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(131, 32);
            this.nudNumber.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(262, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(189, 37);
            this.label21.TabIndex = 14;
            this.label21.Text = "Satış İşlemleri";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProductTimer
            // 
            this.ProductTimer.Enabled = true;
            this.ProductTimer.Interval = 1000;
            this.ProductTimer.Tick += new System.EventHandler(this.ProductTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Çiflik ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAnimalAge;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbWool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbEgg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbHoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbCheese;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.Label lblHoney;
        private System.Windows.Forms.Label lblWool;
        private System.Windows.Forms.Label lblEgg;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer ProductTimer;
        private System.Windows.Forms.ProgressBar pbMilk;
        private System.Windows.Forms.NumericUpDown nudNumber;
    }
}

