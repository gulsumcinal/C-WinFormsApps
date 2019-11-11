namespace WinForms01
{
    partial class FrmDonguler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonguler));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.listBoxDoWhile = new System.Windows.Forms.ListBox();
            this.listBoxIEnum = new System.Windows.Forms.ListBox();
            this.listBoxForeach = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnEnum = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar = {10, 20, 25, 28, 34} kümesinin içindeki sayıları ve en altına bu sayıla" +
    "rın toplamını gösterecek döngü kodlarını yazınız.";
            // 
            // listBoxFor
            // 
            this.listBoxFor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxFor.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.Location = new System.Drawing.Point(17, 55);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(133, 316);
            this.listBoxFor.TabIndex = 1;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxWhile.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.Location = new System.Drawing.Point(182, 55);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(133, 316);
            this.listBoxWhile.TabIndex = 1;
            // 
            // listBoxDoWhile
            // 
            this.listBoxDoWhile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxDoWhile.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxDoWhile.FormattingEnabled = true;
            this.listBoxDoWhile.Location = new System.Drawing.Point(349, 55);
            this.listBoxDoWhile.Name = "listBoxDoWhile";
            this.listBoxDoWhile.Size = new System.Drawing.Size(133, 316);
            this.listBoxDoWhile.TabIndex = 1;
            // 
            // listBoxIEnum
            // 
            this.listBoxIEnum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxIEnum.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxIEnum.FormattingEnabled = true;
            this.listBoxIEnum.Location = new System.Drawing.Point(514, 55);
            this.listBoxIEnum.Name = "listBoxIEnum";
            this.listBoxIEnum.Size = new System.Drawing.Size(133, 316);
            this.listBoxIEnum.TabIndex = 1;
            // 
            // listBoxForeach
            // 
            this.listBoxForeach.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxForeach.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxForeach.FormattingEnabled = true;
            this.listBoxForeach.Location = new System.Drawing.Point(681, 55);
            this.listBoxForeach.Name = "listBoxForeach";
            this.listBoxForeach.Size = new System.Drawing.Size(133, 316);
            this.listBoxForeach.TabIndex = 1;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.Black;
            this.btnFor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFor.Location = new System.Drawing.Point(17, 386);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(133, 45);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWhile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWhile.Location = new System.Drawing.Point(182, 386);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(133, 45);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoWhile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoWhile.Location = new System.Drawing.Point(349, 386);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(133, 45);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnEnum
            // 
            this.btnEnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEnum.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnum.Location = new System.Drawing.Point(514, 386);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(133, 45);
            this.btnEnum.TabIndex = 2;
            this.btnEnum.Text = "Enum";
            this.btnEnum.UseVisualStyleBackColor = false;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForeach.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForeach.Location = new System.Drawing.Point(681, 386);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(133, 45);
            this.btnForeach.TabIndex = 2;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = false;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // FrmDonguler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 475);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnEnum);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.listBoxForeach);
            this.Controls.Add(this.listBoxIEnum);
            this.Controls.Add(this.listBoxDoWhile);
            this.Controls.Add(this.listBoxWhile);
            this.Controls.Add(this.listBoxFor);
            this.Controls.Add(this.label1);
            this.Name = "FrmDonguler";
            this.Text = "Döngüler ve Listbox Formu";
            this.Load += new System.EventHandler(this.FrmDonguler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.ListBox listBoxDoWhile;
        private System.Windows.Forms.ListBox listBoxIEnum;
        private System.Windows.Forms.ListBox listBoxForeach;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Button btnForeach;
    }
}

