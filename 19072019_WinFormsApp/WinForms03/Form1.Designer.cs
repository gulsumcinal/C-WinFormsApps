﻿namespace WinForms03
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
            this.txtBoxOlay = new System.Windows.Forms.TextBox();
            this.lstBoxOlay = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxOlay
            // 
            this.txtBoxOlay.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtBoxOlay.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxOlay.Location = new System.Drawing.Point(266, 30);
            this.txtBoxOlay.Multiline = true;
            this.txtBoxOlay.Name = "txtBoxOlay";
            this.txtBoxOlay.Size = new System.Drawing.Size(227, 147);
            this.txtBoxOlay.TabIndex = 0;
            this.txtBoxOlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxOlay_KeyDown);
            this.txtBoxOlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOlay_KeyPress);
            this.txtBoxOlay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxOlay_KeyUp);
            // 
            // lstBoxOlay
            // 
            this.lstBoxOlay.FormattingEnabled = true;
            this.lstBoxOlay.Location = new System.Drawing.Point(266, 206);
            this.lstBoxOlay.Name = "lstBoxOlay";
            this.lstBoxOlay.Size = new System.Drawing.Size(227, 147);
            this.lstBoxOlay.TabIndex = 1;
            this.lstBoxOlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxOlay_KeyDown);
            this.lstBoxOlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOlay_KeyPress);
            this.lstBoxOlay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxOlay_KeyUp);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(342, 374);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_click);
            this.btnTemizle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxOlay_KeyDown);
            this.btnTemizle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOlay_KeyPress);
            this.btnTemizle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxOlay_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lstBoxOlay);
            this.Controls.Add(this.txtBoxOlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOlay;
        private System.Windows.Forms.ListBox lstBoxOlay;
        private System.Windows.Forms.Button btnTemizle;
    }
}

