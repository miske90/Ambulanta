namespace Ambulanta
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.nov = new System.Windows.Forms.Button();
            this.izmena = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ucitaj listu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(9, 64);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(331, 134);
            this.lista1.TabIndex = 1;
            // 
            // nov
            // 
            this.nov.Location = new System.Drawing.Point(346, 92);
            this.nov.Name = "nov";
            this.nov.Size = new System.Drawing.Size(75, 23);
            this.nov.TabIndex = 2;
            this.nov.Text = "Nov";
            this.nov.UseVisualStyleBackColor = true;
            this.nov.Click += new System.EventHandler(this.nov_Click);
            // 
            // izmena
            // 
            this.izmena.Location = new System.Drawing.Point(346, 147);
            this.izmena.Name = "izmena";
            this.izmena.Size = new System.Drawing.Size(75, 23);
            this.izmena.TabIndex = 3;
            this.izmena.Text = "Izmena";
            this.izmena.UseVisualStyleBackColor = true;
            this.izmena.Click += new System.EventHandler(this.izmena_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pretraga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(122, 247);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(175, 20);
            this.pretraga.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresa";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.izmena);
            this.Controls.Add(this.nov);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.Button nov;
        private System.Windows.Forms.Button izmena;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}