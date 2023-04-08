namespace OOP_Hamburgerci
{
    partial class Form2
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
            this.grpMunuEkleme = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMunuEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMunuEkleme
            // 
            this.grpMunuEkleme.Controls.Add(this.btnekle);
            this.grpMunuEkleme.Controls.Add(this.nmrMenuFiyati);
            this.grpMunuEkleme.Controls.Add(this.label2);
            this.grpMunuEkleme.Controls.Add(this.txtMenuAdı);
            this.grpMunuEkleme.Controls.Add(this.label1);
            this.grpMunuEkleme.Location = new System.Drawing.Point(23, 16);
            this.grpMunuEkleme.Name = "grpMunuEkleme";
            this.grpMunuEkleme.Size = new System.Drawing.Size(307, 203);
            this.grpMunuEkleme.TabIndex = 0;
            this.grpMunuEkleme.TabStop = false;
            this.grpMunuEkleme.Text = "Menü Ekleme Paneli";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(165, 148);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(94, 29);
            this.btnekle.TabIndex = 4;
            this.btnekle.TabStop = false;
            this.btnekle.Text = "Menu Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(109, 97);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(150, 27);
            this.nmrMenuFiyati.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menü Fiyatı";
            // 
            // txtMenuAdı
            // 
            this.txtMenuAdı.Location = new System.Drawing.Point(109, 47);
            this.txtMenuAdı.Name = "txtMenuAdı";
            this.txtMenuAdı.Size = new System.Drawing.Size(150, 27);
            this.txtMenuAdı.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.grpMunuEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMunuEkleme.ResumeLayout(false);
            this.grpMunuEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMunuEkleme;
        private Button btnekle;
        private NumericUpDown nmrMenuFiyati;
        private Label label2;
        private TextBox txtMenuAdı;
        private Label label1;
    }
}