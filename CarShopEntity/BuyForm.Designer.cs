namespace CarShopEntity
{
    partial class BuyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.btnSellCar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.homePageLink);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 451);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 249);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(133, 390);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 58;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSellCar
            // 
            this.btnSellCar.Location = new System.Drawing.Point(31, 390);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(75, 23);
            this.btnSellCar.TabIndex = 57;
            this.btnSellCar.Text = "Search";
            this.btnSellCar.UseVisualStyleBackColor = true;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "WE OFFER BEST PRICE AND QUALITY. BUY NOW!";
            // 
            // homePageLink
            // 
            this.homePageLink.AutoSize = true;
            this.homePageLink.Location = new System.Drawing.Point(9, 10);
            this.homePageLink.Name = "homePageLink";
            this.homePageLink.Size = new System.Drawing.Size(51, 13);
            this.homePageLink.TabIndex = 40;
            this.homePageLink.TabStop = true;
            this.homePageLink.Text = "Car Shop";
            this.homePageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homePageLink_LinkClicked);
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BuyForm";
            this.Text = "BuyForm";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSellCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel homePageLink;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}