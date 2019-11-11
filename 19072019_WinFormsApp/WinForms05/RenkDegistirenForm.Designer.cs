namespace WinForms05
{
    partial class RenkDegistirenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenkGirisi = new System.Windows.Forms.TextBox();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renk Giriniz";
            // 
            // txtRenkGirisi
            // 
            this.txtRenkGirisi.Location = new System.Drawing.Point(164, 94);
            this.txtRenkGirisi.Name = "txtRenkGirisi";
            this.txtRenkGirisi.Size = new System.Drawing.Size(100, 20);
            this.txtRenkGirisi.TabIndex = 1;
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(177, 136);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnRenkDegistir.TabIndex = 2;
            this.btnRenkDegistir.Text = "button1";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // RenkDegistirenForm
            // 
            this.AcceptButton = this.btnRenkDegistir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 286);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.txtRenkGirisi);
            this.Controls.Add(this.label1);
            this.Name = "RenkDegistirenForm";
            this.Text = "RenkDegistirenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenkGirisi;
        private System.Windows.Forms.Button btnRenkDegistir;
    }
}