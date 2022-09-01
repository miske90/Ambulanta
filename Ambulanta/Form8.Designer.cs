namespace Ambulanta
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.button2 = new System.Windows.Forms.Button();
            this.izmena = new System.Windows.Forms.Button();
            this.nov = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pretraga = new System.Windows.Forms.TextBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pretraga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // izmena
            // 
            this.izmena.Location = new System.Drawing.Point(271, 129);
            this.izmena.Name = "izmena";
            this.izmena.Size = new System.Drawing.Size(75, 23);
            this.izmena.TabIndex = 7;
            this.izmena.Text = "Izmena";
            this.izmena.UseVisualStyleBackColor = true;
            this.izmena.Click += new System.EventHandler(this.izmena_Click);
            // 
            // nov
            // 
            this.nov.Location = new System.Drawing.Point(271, 81);
            this.nov.Name = "nov";
            this.nov.Size = new System.Drawing.Size(75, 23);
            this.nov.TabIndex = 6;
            this.nov.Text = "Nov";
            this.nov.UseVisualStyleBackColor = true;
            this.nov.Click += new System.EventHandler(this.nov_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ucitaj listu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(122, 218);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(100, 20);
            this.pretraga.TabIndex = 9;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(8, 56);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(254, 121);
            this.lista2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cena";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.izmena);
            this.Controls.Add(this.nov);
            this.Controls.Add(this.button1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button izmena;
        private System.Windows.Forms.Button nov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pretraga;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}