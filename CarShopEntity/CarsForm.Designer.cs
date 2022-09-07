namespace CarShopEntity
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.buyLink = new System.Windows.Forms.LinkLabel();
            this.sellLink = new System.Windows.Forms.LinkLabel();
            this.homePageLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.aboutLink);
            this.panel1.Controls.Add(this.buyLink);
            this.panel1.Controls.Add(this.sellLink);
            this.panel1.Controls.Add(this.homePageLink);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 313);
            this.panel1.TabIndex = 0;
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(232, 13);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(35, 13);
            this.aboutLink.TabIndex = 3;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "About";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // buyLink
            // 
            this.buyLink.AutoSize = true;
            this.buyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buyLink.Location = new System.Drawing.Point(88, 184);
            this.buyLink.Name = "buyLink";
            this.buyLink.Size = new System.Drawing.Size(102, 46);
            this.buyLink.TabIndex = 2;
            this.buyLink.TabStop = true;
            this.buyLink.Text = "BUY";
            this.buyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buyLink_LinkClicked);
            // 
            // sellLink
            // 
            this.sellLink.AutoSize = true;
            this.sellLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.sellLink.Location = new System.Drawing.Point(88, 85);
            this.sellLink.Name = "sellLink";
            this.sellLink.Size = new System.Drawing.Size(118, 46);
            this.sellLink.TabIndex = 1;
            this.sellLink.TabStop = true;
            this.sellLink.Text = "SELL";
            this.sellLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sellLink_LinkClicked);
            // 
            // homePageLink
            // 
            this.homePageLink.AutoSize = true;
            this.homePageLink.Location = new System.Drawing.Point(13, 13);
            this.homePageLink.Name = "homePageLink";
            this.homePageLink.Size = new System.Drawing.Size(51, 13);
            this.homePageLink.TabIndex = 0;
            this.homePageLink.TabStop = true;
            this.homePageLink.Text = "Car Shop";
            this.homePageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homePageLink_LinkClicked);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 311);
            this.Controls.Add(this.panel1);
            this.Name = "CarsForm";
            this.Text = "CarsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.LinkLabel buyLink;
        private System.Windows.Forms.LinkLabel sellLink;
        private System.Windows.Forms.LinkLabel homePageLink;
    }
}