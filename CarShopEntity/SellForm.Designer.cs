namespace CarShopEntity
{
    partial class SellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.homePageLink = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.carBrandTxtBox = new System.Windows.Forms.TextBox();
            this.carYearTxtBox = new System.Windows.Forms.TextBox();
            this.carModelTxtBox = new System.Windows.Forms.TextBox();
            this.carPriceTxtBox = new System.Windows.Forms.TextBox();
            this.carKmTxtBox = new System.Windows.Forms.TextBox();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // homePageLink
            // 
            this.homePageLink.AutoSize = true;
            this.homePageLink.Location = new System.Drawing.Point(12, 9);
            this.homePageLink.Name = "homePageLink";
            this.homePageLink.Size = new System.Drawing.Size(51, 13);
            this.homePageLink.TabIndex = 1;
            this.homePageLink.TabStop = true;
            this.homePageLink.Text = "Car Shop";
            this.homePageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homePageLink_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.carBrandTxtBox);
            this.panel1.Controls.Add(this.carYearTxtBox);
            this.panel1.Controls.Add(this.carModelTxtBox);
            this.panel1.Controls.Add(this.carPriceTxtBox);
            this.panel1.Controls.Add(this.carKmTxtBox);
            this.panel1.Controls.Add(this.btnSellCar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.homePageLink);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 453);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(92, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sell/Buy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // carBrandTxtBox
            // 
            this.carBrandTxtBox.Location = new System.Drawing.Point(34, 131);
            this.carBrandTxtBox.Name = "carBrandTxtBox";
            this.carBrandTxtBox.Size = new System.Drawing.Size(84, 20);
            this.carBrandTxtBox.TabIndex = 44;
            // 
            // carYearTxtBox
            // 
            this.carYearTxtBox.Location = new System.Drawing.Point(281, 131);
            this.carYearTxtBox.Name = "carYearTxtBox";
            this.carYearTxtBox.Size = new System.Drawing.Size(84, 20);
            this.carYearTxtBox.TabIndex = 43;
            // 
            // carModelTxtBox
            // 
            this.carModelTxtBox.Location = new System.Drawing.Point(166, 131);
            this.carModelTxtBox.Name = "carModelTxtBox";
            this.carModelTxtBox.Size = new System.Drawing.Size(84, 20);
            this.carModelTxtBox.TabIndex = 42;
            // 
            // carPriceTxtBox
            // 
            this.carPriceTxtBox.Location = new System.Drawing.Point(520, 131);
            this.carPriceTxtBox.Name = "carPriceTxtBox";
            this.carPriceTxtBox.Size = new System.Drawing.Size(84, 20);
            this.carPriceTxtBox.TabIndex = 41;
            // 
            // carKmTxtBox
            // 
            this.carKmTxtBox.Location = new System.Drawing.Point(405, 131);
            this.carKmTxtBox.Name = "carKmTxtBox";
            this.carKmTxtBox.Size = new System.Drawing.Size(84, 20);
            this.carKmTxtBox.TabIndex = 40;
            // 
            // btnSellCar
            // 
            this.btnSellCar.Location = new System.Drawing.Point(34, 178);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(75, 23);
            this.btnSellCar.TabIndex = 39;
            this.btnSellCar.Text = "Sell Now";
            this.btnSellCar.UseVisualStyleBackColor = true;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(536, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Car Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(423, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Car Km:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(302, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Car Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(177, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Car Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Car Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(165, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "SELL YOUR CAR JUST IN DAYS! ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(34, 222);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 13);
            this.linkLabel2.TabIndex = 46;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "My List";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 150);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.panel1);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel homePageLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSellCar;
        private System.Windows.Forms.TextBox carBrandTxtBox;
        private System.Windows.Forms.TextBox carYearTxtBox;
        private System.Windows.Forms.TextBox carModelTxtBox;
        private System.Windows.Forms.TextBox carPriceTxtBox;
        private System.Windows.Forms.TextBox carKmTxtBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
    }
}