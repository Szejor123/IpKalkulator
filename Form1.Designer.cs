﻿
namespace IpKalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.networkAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstUsefulTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastUsefulTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ipOctet1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ipOctet2 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet3 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cidrTextBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(355, 106);
            this.IPTextBox.Mask = "###\\.###\\.###\\.###";
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(87, 23);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.Text = "255255255255";
            this.IPTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.IPAddressText_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska:";
            // 
            // MaskaTextBox
            // 
            this.MaskaTextBox.Location = new System.Drawing.Point(355, 135);
            this.MaskaTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskaTextBox.Name = "MaskaTextBox";
            this.MaskaTextBox.Size = new System.Drawing.Size(87, 23);
            this.MaskaTextBox.TabIndex = 2;
            this.MaskaTextBox.Text = "255255255255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres sieci:";
            // 
            // networkAddressTextBox
            // 
            this.networkAddressTextBox.Location = new System.Drawing.Point(355, 164);
            this.networkAddressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAddressTextBox.Name = "networkAddressTextBox";
            this.networkAddressTextBox.ReadOnly = true;
            this.networkAddressTextBox.Size = new System.Drawing.Size(87, 23);
            this.networkAddressTextBox.TabIndex = 5;
            this.networkAddressTextBox.Text = "000000000000";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(355, 193);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(87, 23);
            this.BroadcastTextBox.TabIndex = 7;
            this.BroadcastTextBox.Text = "000000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "AdresRozgłoszeniowy:";
            // 
            // firstUsefulTextBox
            // 
            this.firstUsefulTextBox.Location = new System.Drawing.Point(355, 222);
            this.firstUsefulTextBox.Mask = "###\\.###\\.###\\.###";
            this.firstUsefulTextBox.Name = "firstUsefulTextBox";
            this.firstUsefulTextBox.ReadOnly = true;
            this.firstUsefulTextBox.Size = new System.Drawing.Size(87, 23);
            this.firstUsefulTextBox.TabIndex = 9;
            this.firstUsefulTextBox.Text = "000000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pierwszy użyteczny adres:";
            // 
            // lastUsefulTextBox
            // 
            this.lastUsefulTextBox.Location = new System.Drawing.Point(355, 251);
            this.lastUsefulTextBox.Mask = "###\\.###\\.###\\.###";
            this.lastUsefulTextBox.Name = "lastUsefulTextBox";
            this.lastUsefulTextBox.ReadOnly = true;
            this.lastUsefulTextBox.Size = new System.Drawing.Size(87, 23);
            this.lastUsefulTextBox.TabIndex = 11;
            this.lastUsefulTextBox.Text = "000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ostatni użyteczny adres:";
            // 
            // ipOctet1
            // 
            this.ipOctet1.Location = new System.Drawing.Point(304, 29);
            this.ipOctet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet1.Name = "ipOctet1";
            this.ipOctet1.Size = new System.Drawing.Size(45, 23);
            this.ipOctet1.TabIndex = 13;
            this.ipOctet1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adres IP:";
            // 
            // ipOctet2
            // 
            this.ipOctet2.Location = new System.Drawing.Point(355, 29);
            this.ipOctet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet2.Name = "ipOctet2";
            this.ipOctet2.Size = new System.Drawing.Size(45, 23);
            this.ipOctet2.TabIndex = 15;
            this.ipOctet2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet3
            // 
            this.ipOctet3.Location = new System.Drawing.Point(406, 29);
            this.ipOctet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet3.Name = "ipOctet3";
            this.ipOctet3.Size = new System.Drawing.Size(45, 23);
            this.ipOctet3.TabIndex = 16;
            this.ipOctet3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet4
            // 
            this.ipOctet4.Location = new System.Drawing.Point(457, 29);
            this.ipOctet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet4.Name = "ipOctet4";
            this.ipOctet4.Size = new System.Drawing.Size(45, 23);
            this.ipOctet4.TabIndex = 17;
            this.ipOctet4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Maska:";
            // 
            // cidrTextBox
            // 
            this.cidrTextBox.Location = new System.Drawing.Point(295, 69);
            this.cidrTextBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.cidrTextBox.Name = "cidrTextBox";
            this.cidrTextBox.Size = new System.Drawing.Size(45, 23);
            this.cidrTextBox.TabIndex = 19;
            this.cidrTextBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Licz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidrTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ipOctet4);
            this.Controls.Add(this.ipOctet3);
            this.Controls.Add(this.ipOctet2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ipOctet1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastUsefulTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstUsefulTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.networkAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IPAddressTextBox;
        private System.Windows.Forms.MaskedTextBox IPTextBox;
        private System.Windows.Forms.MaskedTextBox IPText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox networkAddressTextBox;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox firstUsefulTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox lastUsefulTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ipOctet1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ipOctet2;
        private System.Windows.Forms.NumericUpDown ipOctet3;
        private System.Windows.Forms.NumericUpDown ipOctet4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cidrTextBox;
        private System.Windows.Forms.Button button1;
    }
}

