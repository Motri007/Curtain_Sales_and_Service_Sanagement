namespace Curtain_Sales_and_Service_Sanagement
{
    partial class Warehouse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommodity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFilterType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterNameC = new System.Windows.Forms.TextBox();
            this.btnEditPrice = new System.Windows.Forms.Button();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvWarehouse = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.cmbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCommodity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Location = new System.Drawing.Point(0, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 34);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "بازگشت";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "زرشکی",
            "طلایی",
            "مشکی",
            "نقره ای"});
            this.cmbColor.Location = new System.Drawing.Point(271, 147);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(202, 26);
            this.cmbColor.TabIndex = 57;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "پرده",
            "با وسایل",
            "همراه کمربند",
            "با دستمزد",
            "حریر"});
            this.cmbType.Location = new System.Drawing.Point(271, 99);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(206, 26);
            this.cmbType.TabIndex = 56;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Items.AddRange(new object[] {
            "پارچه",
            "اتومات",
            "ریشه",
            "نوار",
            "چوب پرده",
            "گل میخ",
            "سرب",
            "کتیبه"});
            this.cmbName.Location = new System.Drawing.Point(543, 53);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(186, 26);
            this.cmbName.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(663, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = ": افزودن کالا";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCommodity
            // 
            this.btnCommodity.Location = new System.Drawing.Point(6, 53);
            this.btnCommodity.Name = "btnCommodity";
            this.btnCommodity.Size = new System.Drawing.Size(232, 123);
            this.btnCommodity.TabIndex = 43;
            this.btnCommodity.Text = "ثبت کالا";
            this.btnCommodity.UseVisualStyleBackColor = true;
            this.btnCommodity.Click += new System.EventHandler(this.btnCommodity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = ": نام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = ": قیمت واحد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = ": تعداد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = ": نوع";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = ": انداره";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(538, 147);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(176, 26);
            this.txtSize.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = ": رنگ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(537, 99);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(177, 26);
            this.txtNumber.TabIndex = 37;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(271, 53);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(172, 26);
            this.txtPrice.TabIndex = 36;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFilterType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFilterNameC);
            this.groupBox2.Controls.Add(this.btnEditPrice);
            this.groupBox2.Controls.Add(this.txtEditPrice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dgvWarehouse);
            this.groupBox2.Location = new System.Drawing.Point(13, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(6, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 124);
            this.button1.TabIndex = 64;
            this.button1.Text = "فاکتور گیری";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 18);
            this.label12.TabIndex = 63;
            this.label12.Text = ": جست و جو با نوع";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilterType
            // 
            this.txtFilterType.Location = new System.Drawing.Point(171, 55);
            this.txtFilterType.Name = "txtFilterType";
            this.txtFilterType.Size = new System.Drawing.Size(152, 26);
            this.txtFilterType.TabIndex = 62;
            this.txtFilterType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilterType.TextChanged += new System.EventHandler(this.txtFilterType_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = ": جست و جو با نام کالا";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilterNameC
            // 
            this.txtFilterNameC.Location = new System.Drawing.Point(464, 55);
            this.txtFilterNameC.Name = "txtFilterNameC";
            this.txtFilterNameC.Size = new System.Drawing.Size(148, 26);
            this.txtFilterNameC.TabIndex = 60;
            this.txtFilterNameC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilterNameC.TextChanged += new System.EventHandler(this.txtFilterNameC_TextChanged);
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPrice.Location = new System.Drawing.Point(6, 122);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Size = new System.Drawing.Size(159, 26);
            this.btnEditPrice.TabIndex = 59;
            this.btnEditPrice.Text = "بروزرسانی قیمت";
            this.btnEditPrice.UseVisualStyleBackColor = false;
            this.btnEditPrice.Click += new System.EventHandler(this.btnEditPrice_Click);
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtEditPrice.Enabled = false;
            this.txtEditPrice.Location = new System.Drawing.Point(6, 90);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(159, 26);
            this.txtEditPrice.TabIndex = 58;
            this.txtEditPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(616, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = ": لیست محصولات";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvWarehouse
            // 
            this.dgvWarehouse.BackgroundColor = System.Drawing.Color.White;
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Location = new System.Drawing.Point(171, 90);
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvWarehouse.RowHeadersWidth = 51;
            this.dgvWarehouse.RowTemplate.Height = 24;
            this.dgvWarehouse.Size = new System.Drawing.Size(598, 188);
            this.dgvWarehouse.TabIndex = 30;
            this.dgvWarehouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvWarehouse_MouseUp);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_FormClosing);
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommodity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvWarehouse;
        private System.Windows.Forms.Button btnEditPrice;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFilterType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterNameC;
        private System.Windows.Forms.Button btnBack;
    }
}