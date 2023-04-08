namespace OOP_Hamburgerci
{
    partial class Form3
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
            this.grpMunuEkstraEkleme = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.nmrEkstraFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEkstraAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMunuEkstraEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMunuEkstraEkleme
            // 
            this.grpMunuEkstraEkleme.Controls.Add(this.btnekle);
            this.grpMunuEkstraEkleme.Controls.Add(this.nmrEkstraFiyati);
            this.grpMunuEkstraEkleme.Controls.Add(this.label2);
            this.grpMunuEkstraEkleme.Controls.Add(this.txtEkstraAdı);
            this.grpMunuEkstraEkleme.Controls.Add(this.label1);
            this.grpMunuEkstraEkleme.Location = new System.Drawing.Point(12, 12);
            this.grpMunuEkstraEkleme.Name = "grpMunuEkstraEkleme";
            this.grpMunuEkstraEkleme.Size = new System.Drawing.Size(307, 203);
            this.grpMunuEkstraEkleme.TabIndex = 1;
            this.grpMunuEkstraEkleme.TabStop = false;
            this.grpMunuEkstraEkleme.Text = "Ekstra  Malzeme Ekleme Paneli";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(165, 148);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(94, 29);
            this.btnekle.TabIndex = 4;
            this.btnekle.TabStop = false;
            this.btnekle.Text = "Ekstra Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // nmrEkstraFiyati
            // 
            this.nmrEkstraFiyati.Location = new System.Drawing.Point(109, 97);
            this.nmrEkstraFiyati.Name = "nmrEkstraFiyati";
            this.nmrEkstraFiyati.Size = new System.Drawing.Size(150, 27);
            this.nmrEkstraFiyati.TabIndex = 3;
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
            // txtEkstraAdı
            // 
            this.txtEkstraAdı.Location = new System.Drawing.Point(109, 47);
            this.txtEkstraAdı.Name = "txtEkstraAdı";
            this.txtEkstraAdı.Size = new System.Drawing.Size(150, 27);
            this.txtEkstraAdı.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Adı";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 242);
            this.Controls.Add(this.grpMunuEkstraEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpMunuEkstraEkleme.ResumeLayout(false);
            this.grpMunuEkstraEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMunuEkstraEkleme;
        private Button btnekle;
        private NumericUpDown nmrEkstraFiyati;
        private Label label2;
        private TextBox txtEkstraAdı;
        private Label label1;
    }
}