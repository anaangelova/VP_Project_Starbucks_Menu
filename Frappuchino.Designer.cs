﻿namespace VP_Proekt_Starbucks_Menu
{
    partial class Frappuchino
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
            this.lblChocolate = new System.Windows.Forms.Label();
            this.lblSmores = new System.Windows.Forms.Label();
            this.lblCaramel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudChocolate = new System.Windows.Forms.NumericUpDown();
            this.nudSmores = new System.Windows.Forms.NumericUpDown();
            this.nudCaramel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSizeChocolate = new System.Windows.Forms.ComboBox();
            this.cbSizeSmores = new System.Windows.Forms.ComboBox();
            this.cbSizeCaramel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPriceChocolate = new System.Windows.Forms.Label();
            this.lblPriceSmores = new System.Windows.Forms.Label();
            this.lblPriceCaramel = new System.Windows.Forms.Label();
            this.btnOrderChoco = new System.Windows.Forms.Button();
            this.btnOrderSmores = new System.Windows.Forms.Button();
            this.btnOrderCaramel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pbSmores = new System.Windows.Forms.PictureBox();
            this.pbCaramel = new System.Windows.Forms.PictureBox();
            this.pbChocolate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChocolate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaramel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaramel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChocolate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChocolate.Location = new System.Drawing.Point(16, 69);
            this.lblChocolate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(131, 29);
            this.lblChocolate.TabIndex = 3;
            this.lblChocolate.Text = "Chocolate";
            // 
            // lblSmores
            // 
            this.lblSmores.AutoSize = true;
            this.lblSmores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSmores.Location = new System.Drawing.Point(280, 69);
            this.lblSmores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSmores.Name = "lblSmores";
            this.lblSmores.Size = new System.Drawing.Size(108, 29);
            this.lblSmores.TabIndex = 4;
            this.lblSmores.Text = "S\'mores";
            // 
            // lblCaramel
            // 
            this.lblCaramel.AutoSize = true;
            this.lblCaramel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaramel.Location = new System.Drawing.Point(547, 71);
            this.lblCaramel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaramel.Name = "lblCaramel";
            this.lblCaramel.Size = new System.Drawing.Size(111, 29);
            this.lblCaramel.TabIndex = 5;
            this.lblCaramel.Text = "Caramel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity:";
            // 
            // nudChocolate
            // 
            this.nudChocolate.Location = new System.Drawing.Point(16, 330);
            this.nudChocolate.Margin = new System.Windows.Forms.Padding(4);
            this.nudChocolate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudChocolate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChocolate.Name = "nudChocolate";
            this.nudChocolate.Size = new System.Drawing.Size(200, 22);
            this.nudChocolate.TabIndex = 9;
            this.nudChocolate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSmores
            // 
            this.nudSmores.Location = new System.Drawing.Point(285, 330);
            this.nudSmores.Margin = new System.Windows.Forms.Padding(4);
            this.nudSmores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSmores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSmores.Name = "nudSmores";
            this.nudSmores.Size = new System.Drawing.Size(200, 22);
            this.nudSmores.TabIndex = 10;
            this.nudSmores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCaramel
            // 
            this.nudCaramel.Location = new System.Drawing.Point(552, 329);
            this.nudCaramel.Margin = new System.Windows.Forms.Padding(4);
            this.nudCaramel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCaramel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCaramel.Name = "nudCaramel";
            this.nudCaramel.Size = new System.Drawing.Size(200, 22);
            this.nudCaramel.TabIndex = 11;
            this.nudCaramel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Size:";
            // 
            // cbSizeChocolate
            // 
            this.cbSizeChocolate.FormattingEnabled = true;
            this.cbSizeChocolate.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.cbSizeChocolate.Location = new System.Drawing.Point(16, 394);
            this.cbSizeChocolate.Margin = new System.Windows.Forms.Padding(4);
            this.cbSizeChocolate.Name = "cbSizeChocolate";
            this.cbSizeChocolate.Size = new System.Drawing.Size(199, 24);
            this.cbSizeChocolate.TabIndex = 15;
            this.cbSizeChocolate.SelectedIndexChanged += new System.EventHandler(this.cbSizeChocolate_SelectedIndexChanged);
            // 
            // cbSizeSmores
            // 
            this.cbSizeSmores.FormattingEnabled = true;
            this.cbSizeSmores.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.cbSizeSmores.Location = new System.Drawing.Point(285, 394);
            this.cbSizeSmores.Margin = new System.Windows.Forms.Padding(4);
            this.cbSizeSmores.Name = "cbSizeSmores";
            this.cbSizeSmores.Size = new System.Drawing.Size(199, 24);
            this.cbSizeSmores.TabIndex = 16;
            this.cbSizeSmores.SelectedIndexChanged += new System.EventHandler(this.cbSizeSmores_SelectedIndexChanged);
            // 
            // cbSizeCaramel
            // 
            this.cbSizeCaramel.FormattingEnabled = true;
            this.cbSizeCaramel.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.cbSizeCaramel.Location = new System.Drawing.Point(552, 394);
            this.cbSizeCaramel.Margin = new System.Windows.Forms.Padding(4);
            this.cbSizeCaramel.Name = "cbSizeCaramel";
            this.cbSizeCaramel.Size = new System.Drawing.Size(199, 24);
            this.cbSizeCaramel.TabIndex = 17;
            this.cbSizeCaramel.SelectedIndexChanged += new System.EventHandler(this.cbSizeCaramel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 434);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price: $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price: $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 434);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Price: $";
            // 
            // lblPriceChocolate
            // 
            this.lblPriceChocolate.AutoSize = true;
            this.lblPriceChocolate.Location = new System.Drawing.Point(71, 434);
            this.lblPriceChocolate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceChocolate.Name = "lblPriceChocolate";
            this.lblPriceChocolate.Size = new System.Drawing.Size(36, 17);
            this.lblPriceChocolate.TabIndex = 21;
            this.lblPriceChocolate.Text = "3,80";
            // 
            // lblPriceSmores
            // 
            this.lblPriceSmores.AutoSize = true;
            this.lblPriceSmores.Location = new System.Drawing.Point(336, 434);
            this.lblPriceSmores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceSmores.Name = "lblPriceSmores";
            this.lblPriceSmores.Size = new System.Drawing.Size(36, 17);
            this.lblPriceSmores.TabIndex = 22;
            this.lblPriceSmores.Text = "4,10";
            // 
            // lblPriceCaramel
            // 
            this.lblPriceCaramel.AutoSize = true;
            this.lblPriceCaramel.Location = new System.Drawing.Point(601, 434);
            this.lblPriceCaramel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceCaramel.Name = "lblPriceCaramel";
            this.lblPriceCaramel.Size = new System.Drawing.Size(36, 17);
            this.lblPriceCaramel.TabIndex = 23;
            this.lblPriceCaramel.Text = "3,90";
            // 
            // btnOrderChoco
            // 
            this.btnOrderChoco.Location = new System.Drawing.Point(16, 454);
            this.btnOrderChoco.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderChoco.Name = "btnOrderChoco";
            this.btnOrderChoco.Size = new System.Drawing.Size(200, 28);
            this.btnOrderChoco.TabIndex = 24;
            this.btnOrderChoco.Text = "Order";
            this.btnOrderChoco.UseVisualStyleBackColor = true;
            this.btnOrderChoco.Click += new System.EventHandler(this.btnOrderChoco_Click);
            // 
            // btnOrderSmores
            // 
            this.btnOrderSmores.Location = new System.Drawing.Point(285, 454);
            this.btnOrderSmores.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderSmores.Name = "btnOrderSmores";
            this.btnOrderSmores.Size = new System.Drawing.Size(200, 28);
            this.btnOrderSmores.TabIndex = 25;
            this.btnOrderSmores.Text = "Order";
            this.btnOrderSmores.UseVisualStyleBackColor = true;
            this.btnOrderSmores.Click += new System.EventHandler(this.btnOrderSmores_Click);
            // 
            // btnOrderCaramel
            // 
            this.btnOrderCaramel.Location = new System.Drawing.Point(552, 454);
            this.btnOrderCaramel.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderCaramel.Name = "btnOrderCaramel";
            this.btnOrderCaramel.Size = new System.Drawing.Size(200, 28);
            this.btnOrderCaramel.TabIndex = 26;
            this.btnOrderCaramel.Text = "Order";
            this.btnOrderCaramel.UseVisualStyleBackColor = true;
            this.btnOrderCaramel.Click += new System.EventHandler(this.btnOrderCaramel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(92, 497);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(571, 28);
            this.btnFinish.TabIndex = 27;
            this.btnFinish.Text = "Finish Order";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pbSmores
            // 
            this.pbSmores.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.FRAPPsMORESS;
            this.pbSmores.Location = new System.Drawing.Point(285, 105);
            this.pbSmores.Margin = new System.Windows.Forms.Padding(4);
            this.pbSmores.Name = "pbSmores";
            this.pbSmores.Size = new System.Drawing.Size(150, 150);
            this.pbSmores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSmores.TabIndex = 2;
            this.pbSmores.TabStop = false;
            // 
            // pbCaramel
            // 
            this.pbCaramel.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.frappCaramel;
            this.pbCaramel.Location = new System.Drawing.Point(552, 105);
            this.pbCaramel.Margin = new System.Windows.Forms.Padding(4);
            this.pbCaramel.Name = "pbCaramel";
            this.pbCaramel.Size = new System.Drawing.Size(150, 159);
            this.pbCaramel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCaramel.TabIndex = 1;
            this.pbCaramel.TabStop = false;
            // 
            // pbChocolate
            // 
            this.pbChocolate.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.frappChocolate;
            this.pbChocolate.Location = new System.Drawing.Point(16, 105);
            this.pbChocolate.Margin = new System.Windows.Forms.Padding(4);
            this.pbChocolate.Name = "pbChocolate";
            this.pbChocolate.Size = new System.Drawing.Size(150, 152);
            this.pbChocolate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbChocolate.TabIndex = 0;
            this.pbChocolate.TabStop = false;
            this.pbChocolate.Click += new System.EventHandler(this.pbChocolate_Click);
            // 
            // Frappuchino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 540);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnOrderCaramel);
            this.Controls.Add(this.btnOrderSmores);
            this.Controls.Add(this.btnOrderChoco);
            this.Controls.Add(this.lblPriceCaramel);
            this.Controls.Add(this.lblPriceSmores);
            this.Controls.Add(this.lblPriceChocolate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSizeCaramel);
            this.Controls.Add(this.cbSizeSmores);
            this.Controls.Add(this.cbSizeChocolate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCaramel);
            this.Controls.Add(this.nudSmores);
            this.Controls.Add(this.nudChocolate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaramel);
            this.Controls.Add(this.lblSmores);
            this.Controls.Add(this.lblChocolate);
            this.Controls.Add(this.pbSmores);
            this.Controls.Add(this.pbCaramel);
            this.Controls.Add(this.pbChocolate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frappuchino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frappuchino";
            ((System.ComponentModel.ISupportInitialize)(this.nudChocolate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaramel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaramel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChocolate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbChocolate;
        private System.Windows.Forms.PictureBox pbCaramel;
        private System.Windows.Forms.PictureBox pbSmores;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblSmores;
        private System.Windows.Forms.Label lblCaramel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudChocolate;
        private System.Windows.Forms.NumericUpDown nudSmores;
        private System.Windows.Forms.NumericUpDown nudCaramel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSizeChocolate;
        private System.Windows.Forms.ComboBox cbSizeSmores;
        private System.Windows.Forms.ComboBox cbSizeCaramel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPriceChocolate;
        private System.Windows.Forms.Label lblPriceSmores;
        private System.Windows.Forms.Label lblPriceCaramel;
        private System.Windows.Forms.Button btnOrderChoco;
        private System.Windows.Forms.Button btnOrderSmores;
        private System.Windows.Forms.Button btnOrderCaramel;
        private System.Windows.Forms.Button btnFinish;
    }
}