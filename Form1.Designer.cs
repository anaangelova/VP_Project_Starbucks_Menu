﻿namespace VP_Proekt_Starbucks_Menu
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
            this.lblHot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStarbucks = new System.Windows.Forms.Label();
            this.pbDessert = new System.Windows.Forms.PictureBox();
            this.pbSand = new System.Windows.Forms.PictureBox();
            this.pbColdDrinks = new System.Windows.Forms.PictureBox();
            this.pbFrapp = new System.Windows.Forms.PictureBox();
            this.pbColdCoffee = new System.Windows.Forms.PictureBox();
            this.pbHotCoffee = new System.Windows.Forms.PictureBox();
            this.order.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHot
            // 
            this.lblHot.AutoSize = true;
            this.lblHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHot.ForeColor = System.Drawing.Color.Sienna;
            this.lblHot.Location = new System.Drawing.Point(5, 64);
            this.lblHot.Name = "lblHot";
            this.lblHot.Size = new System.Drawing.Size(115, 24);
            this.lblHot.TabIndex = 3;
            this.lblHot.Text = "Hot coffees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(426, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cold coffees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(217, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Frappuccinos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(11, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cold drinks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(217, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sandwiches ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(426, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bakery";
            // 
            // order
            // 
            this.order.Controls.Add(this.button1);
            this.order.Controls.Add(this.btnPay);
            this.order.Controls.Add(this.tbTotal);
            this.order.Controls.Add(this.label7);
            this.order.Controls.Add(this.listBox1);
            this.order.Location = new System.Drawing.Point(7, 78);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(228, 279);
            this.order.TabIndex = 15;
            this.order.TabStop = false;
            this.order.Text = "Total order";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(6, 233);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(216, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "PAY NOW";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(78, 174);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(82, 20);
            this.tbTotal.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total price: $";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 121);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.order);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(635, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 505);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblStarbucks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 44);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.logo21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblStarbucks
            // 
            this.lblStarbucks.AutoSize = true;
            this.lblStarbucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarbucks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStarbucks.Location = new System.Drawing.Point(50, 15);
            this.lblStarbucks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStarbucks.Name = "lblStarbucks";
            this.lblStarbucks.Size = new System.Drawing.Size(172, 20);
            this.lblStarbucks.TabIndex = 0;
            this.lblStarbucks.Text = "STARBUCKS MENU";
            // 
            // pbDessert
            // 
            this.pbDessert.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.BlueberryMuffin;
            this.pbDessert.Location = new System.Drawing.Point(430, 313);
            this.pbDessert.Name = "pbDessert";
            this.pbDessert.Size = new System.Drawing.Size(166, 173);
            this.pbDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDessert.TabIndex = 13;
            this.pbDessert.TabStop = false;
            this.pbDessert.Click += new System.EventHandler(this.pbDessert_Click);
            // 
            // pbSand
            // 
            this.pbSand.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.Tomato_Mozzarella;
            this.pbSand.Location = new System.Drawing.Point(219, 313);
            this.pbSand.Name = "pbSand";
            this.pbSand.Size = new System.Drawing.Size(166, 173);
            this.pbSand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSand.TabIndex = 11;
            this.pbSand.TabStop = false;
            this.pbSand.Click += new System.EventHandler(this.pbSand_Click);
            // 
            // pbColdDrinks
            // 
            this.pbColdDrinks.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.IcedPineapple;
            this.pbColdDrinks.Location = new System.Drawing.Point(12, 311);
            this.pbColdDrinks.Name = "pbColdDrinks";
            this.pbColdDrinks.Size = new System.Drawing.Size(168, 175);
            this.pbColdDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbColdDrinks.TabIndex = 8;
            this.pbColdDrinks.TabStop = false;
            this.pbColdDrinks.Click += new System.EventHandler(this.pbColdDrinks_Click);
            // 
            // pbFrapp
            // 
            this.pbFrapp.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.ChocolateFrappuccino;
            this.pbFrapp.Location = new System.Drawing.Point(221, 95);
            this.pbFrapp.Name = "pbFrapp";
            this.pbFrapp.Size = new System.Drawing.Size(168, 174);
            this.pbFrapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFrapp.TabIndex = 7;
            this.pbFrapp.TabStop = false;
            this.pbFrapp.Click += new System.EventHandler(this.pbFrapp_Click);
            // 
            // pbColdCoffee
            // 
            this.pbColdCoffee.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.SaltedCaramelCreamColdBrew;
            this.pbColdCoffee.Location = new System.Drawing.Point(430, 97);
            this.pbColdCoffee.Name = "pbColdCoffee";
            this.pbColdCoffee.Size = new System.Drawing.Size(166, 173);
            this.pbColdCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbColdCoffee.TabIndex = 5;
            this.pbColdCoffee.TabStop = false;
            this.pbColdCoffee.Click += new System.EventHandler(this.pbColdCoffee_Click);
            // 
            // pbHotCoffee
            // 
            this.pbHotCoffee.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.Americano1;
            this.pbHotCoffee.ImageLocation = "";
            this.pbHotCoffee.Location = new System.Drawing.Point(12, 97);
            this.pbHotCoffee.Name = "pbHotCoffee";
            this.pbHotCoffee.Size = new System.Drawing.Size(168, 173);
            this.pbHotCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbHotCoffee.TabIndex = 2;
            this.pbHotCoffee.TabStop = false;
            this.pbHotCoffee.Click += new System.EventHandler(this.pbHotCoffee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(875, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbDessert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbSand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbColdDrinks);
            this.Controls.Add(this.pbFrapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbColdCoffee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHot);
            this.Controls.Add(this.pbHotCoffee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbHotCoffee;
        private System.Windows.Forms.Label lblHot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbColdCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFrapp;
        private System.Windows.Forms.PictureBox pbColdDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbDessert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox order;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStarbucks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

