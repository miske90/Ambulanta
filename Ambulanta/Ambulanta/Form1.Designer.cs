namespace Ambulanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.nov = new System.Windows.Forms.Button();
            this.Izmena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.pretraga = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ucitaj listu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nov
            // 
            this.nov.Location = new System.Drawing.Point(305, 76);
            this.nov.Name = "nov";
            this.nov.Size = new System.Drawing.Size(75, 23);
            this.nov.TabIndex = 2;
            this.nov.Text = "Nov";
            this.nov.UseVisualStyleBackColor = true;
            this.nov.Click += new System.EventHandler(this.nov_Click);
            // 
            // Izmena
            // 
            this.Izmena.Location = new System.Drawing.Point(305, 125);
            this.Izmena.Name = "Izmena";
            this.Izmena.Size = new System.Drawing.Size(75, 23);
            this.Izmena.TabIndex = 3;
            this.Izmena.Text = "Izmena";
            this.Izmena.UseVisualStyleBackColor = true;
            this.Izmena.Click += new System.EventHandler(this.Izmena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Specijalizacija";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(8, 61);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(273, 121);
            this.lista.TabIndex = 9;
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(100, 217);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(100, 20);
            this.pretraga.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Pretraga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Izmena);
            this.Controls.Add(this.nov);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nov;
        private System.Windows.Forms.Button Izmena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox pretraga;
        private System.Windows.Forms.Button button2;
    }
}

