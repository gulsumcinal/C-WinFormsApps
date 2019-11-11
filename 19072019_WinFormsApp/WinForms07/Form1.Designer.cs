namespace WinForms07
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPikachu = new System.Windows.Forms.PictureBox();
            this.pbGarfield = new System.Windows.Forms.PictureBox();
            this.pnlBitis = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPikachu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarfield)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPikachu
            // 
            this.pbPikachu.Image = ((System.Drawing.Image)(resources.GetObject("pbPikachu.Image")));
            this.pbPikachu.Location = new System.Drawing.Point(1, 107);
            this.pbPikachu.Name = "pbPikachu";
            this.pbPikachu.Size = new System.Drawing.Size(125, 101);
            this.pbPikachu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPikachu.TabIndex = 0;
            this.pbPikachu.TabStop = false;
            // 
            // pbGarfield
            // 
            this.pbGarfield.Image = ((System.Drawing.Image)(resources.GetObject("pbGarfield.Image")));
            this.pbGarfield.Location = new System.Drawing.Point(1, 264);
            this.pbGarfield.Name = "pbGarfield";
            this.pbGarfield.Size = new System.Drawing.Size(125, 110);
            this.pbGarfield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGarfield.TabIndex = 1;
            this.pbGarfield.TabStop = false;
            // 
            // pnlBitis
            // 
            this.pnlBitis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBitis.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBitis.Location = new System.Drawing.Point(932, 0);
            this.pnlBitis.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBitis.Name = "pnlBitis";
            this.pnlBitis.Size = new System.Drawing.Size(41, 492);
            this.pnlBitis.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(1, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 492);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlBitis);
            this.Controls.Add(this.pbGarfield);
            this.Controls.Add(this.pbPikachu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPikachu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarfield)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPikachu;
        private System.Windows.Forms.PictureBox pbGarfield;
        private System.Windows.Forms.Panel pnlBitis;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

