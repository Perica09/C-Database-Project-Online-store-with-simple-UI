namespace DataBaseSeminarska
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Nositel = new System.Windows.Forms.TextBox();
            this.CVC = new System.Windows.Forms.TextBox();
            this.Datum_Istekuvanje = new System.Windows.Forms.TextBox();
            this.Broj_Karticka = new System.Windows.Forms.TextBox();
            this.Plati_Karticka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nositel
            // 
            this.Nositel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nositel.Location = new System.Drawing.Point(53, 66);
            this.Nositel.Name = "Nositel";
            this.Nositel.Size = new System.Drawing.Size(340, 34);
            this.Nositel.TabIndex = 1;
            // 
            // CVC
            // 
            this.CVC.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVC.Location = new System.Drawing.Point(47, 274);
            this.CVC.Name = "CVC";
            this.CVC.Size = new System.Drawing.Size(340, 34);
            this.CVC.TabIndex = 3;
            // 
            // Datum_Istekuvanje
            // 
            this.Datum_Istekuvanje.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datum_Istekuvanje.Location = new System.Drawing.Point(53, 399);
            this.Datum_Istekuvanje.Name = "Datum_Istekuvanje";
            this.Datum_Istekuvanje.Size = new System.Drawing.Size(340, 34);
            this.Datum_Istekuvanje.TabIndex = 4;
            // 
            // Broj_Karticka
            // 
            this.Broj_Karticka.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Broj_Karticka.Location = new System.Drawing.Point(53, 174);
            this.Broj_Karticka.Name = "Broj_Karticka";
            this.Broj_Karticka.Size = new System.Drawing.Size(340, 34);
            this.Broj_Karticka.TabIndex = 5;
            // 
            // Plati_Karticka
            // 
            this.Plati_Karticka.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plati_Karticka.Location = new System.Drawing.Point(88, 496);
            this.Plati_Karticka.Name = "Plati_Karticka";
            this.Plati_Karticka.Size = new System.Drawing.Size(266, 62);
            this.Plati_Karticka.TabIndex = 6;
            this.Plati_Karticka.Text = "ПЛАТИ";
            this.Plati_Karticka.UseVisualStyleBackColor = true;
            this.Plati_Karticka.Click += new System.EventHandler(this.Plati_Karticka_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Носител на картичката:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "Број на картичката \r\n(Со празни места)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "CVC";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 70);
            this.label4.TabIndex = 16;
            this.label4.Text = "Датум на истекување \r\n(Во формат дд/мм/гггг)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Plati_Karticka);
            this.Controls.Add(this.Broj_Karticka);
            this.Controls.Add(this.Datum_Istekuvanje);
            this.Controls.Add(this.CVC);
            this.Controls.Add(this.Nositel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(474, 647);
            this.MinimumSize = new System.Drawing.Size(474, 647);
            this.Name = "Form3";
            this.Text = "Плаќање со кредитна картичка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nositel;
        private System.Windows.Forms.TextBox CVC;
        private System.Windows.Forms.TextBox Datum_Istekuvanje;
        private System.Windows.Forms.TextBox Broj_Karticka;
        private System.Windows.Forms.Button Plati_Karticka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}