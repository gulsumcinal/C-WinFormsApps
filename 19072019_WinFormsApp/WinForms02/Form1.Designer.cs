namespace WinForms02
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_CharacterToLower = new System.Windows.Forms.TextBox();
            this.txt_CharacterCasingToUpper = new System.Windows.Forms.TextBox();
            this.txt_YalnizSayi = new System.Windows.Forms.TextBox();
            this.txt_YalnizKarakter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.txt_CharacterToLower);
            this.panel1.Controls.Add(this.txt_CharacterCasingToUpper);
            this.panel1.Controls.Add(this.txt_YalnizSayi);
            this.panel1.Controls.Add(this.txt_YalnizKarakter);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 241);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter Gir: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Karakter Küçültme: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Karakter Büyütme: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sayı Gir: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 20);
            this.textBox5.TabIndex = 2;
            // 
            // txt_CharacterToLower
            // 
            this.txt_CharacterToLower.Location = new System.Drawing.Point(116, 147);
            this.txt_CharacterToLower.Name = "txt_CharacterToLower";
            this.txt_CharacterToLower.Size = new System.Drawing.Size(204, 20);
            this.txt_CharacterToLower.TabIndex = 2;
            this.txt_CharacterToLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterToLower_KeyPress);
            // 
            // txt_CharacterCasingToUpper
            // 
            this.txt_CharacterCasingToUpper.Location = new System.Drawing.Point(116, 104);
            this.txt_CharacterCasingToUpper.Name = "txt_CharacterCasingToUpper";
            this.txt_CharacterCasingToUpper.Size = new System.Drawing.Size(204, 20);
            this.txt_CharacterCasingToUpper.TabIndex = 2;
            this.txt_CharacterCasingToUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToUpper_KeyPress);
            // 
            // txt_YalnizSayi
            // 
            this.txt_YalnizSayi.Location = new System.Drawing.Point(116, 61);
            this.txt_YalnizSayi.Name = "txt_YalnizSayi";
            this.txt_YalnizSayi.Size = new System.Drawing.Size(204, 20);
            this.txt_YalnizSayi.TabIndex = 2;
            this.txt_YalnizSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizSayi_KeyPress);
            // 
            // txt_YalnizKarakter
            // 
            this.txt_YalnizKarakter.Location = new System.Drawing.Point(116, 18);
            this.txt_YalnizKarakter.Name = "txt_YalnizKarakter";
            this.txt_YalnizKarakter.Size = new System.Drawing.Size(204, 20);
            this.txt_YalnizKarakter.TabIndex = 2;
            this.txt_YalnizKarakter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizKarakter_KeyPress);
            this.txt_YalnizKarakter.MouseEnter += new System.EventHandler(this.txt_YalnizKarakter_MouseEnter);
            this.txt_YalnizKarakter.MouseLeave += new System.EventHandler(this.txt_YalnizKarakter_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_CharacterToLower;
        private System.Windows.Forms.TextBox txt_CharacterCasingToUpper;
        private System.Windows.Forms.TextBox txt_YalnizSayi;
        private System.Windows.Forms.TextBox txt_YalnizKarakter;
    }
}

