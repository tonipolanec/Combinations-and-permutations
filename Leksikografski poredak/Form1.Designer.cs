namespace Leksikografski_poredak
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
            this.textBoxUnosSlova = new System.Windows.Forms.TextBox();
            this.listBoxIspisPermutacija = new System.Windows.Forms.ListBox();
            this.buttonPermutiraj = new System.Windows.Forms.Button();
            this.radioButtonBrojevi = new System.Windows.Forms.RadioButton();
            this.radioButtonSlova = new System.Windows.Forms.RadioButton();
            this.labelUkupnoPermutacija = new System.Windows.Forms.Label();
            this.checkBoxPronadiPermutaciju = new System.Windows.Forms.CheckBox();
            this.labelPermutacijaPoRedu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUnosSlova
            // 
            this.textBoxUnosSlova.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUnosSlova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnosSlova.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBoxUnosSlova.ForeColor = System.Drawing.Color.White;
            this.textBoxUnosSlova.Location = new System.Drawing.Point(50, 13);
            this.textBoxUnosSlova.Name = "textBoxUnosSlova";
            this.textBoxUnosSlova.Size = new System.Drawing.Size(229, 31);
            this.textBoxUnosSlova.TabIndex = 0;
            // 
            // listBoxIspisPermutacija
            // 
            this.listBoxIspisPermutacija.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBoxIspisPermutacija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxIspisPermutacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.listBoxIspisPermutacija.ForeColor = System.Drawing.Color.White;
            this.listBoxIspisPermutacija.FormattingEnabled = true;
            this.listBoxIspisPermutacija.ItemHeight = 31;
            this.listBoxIspisPermutacija.Location = new System.Drawing.Point(50, 206);
            this.listBoxIspisPermutacija.Name = "listBoxIspisPermutacija";
            this.listBoxIspisPermutacija.Size = new System.Drawing.Size(229, 310);
            this.listBoxIspisPermutacija.TabIndex = 1;
            this.listBoxIspisPermutacija.Visible = false;
            this.listBoxIspisPermutacija.SelectedIndexChanged += new System.EventHandler(this.listBoxIspisPermutacija_SelectedIndexChanged);
            // 
            // buttonPermutiraj
            // 
            this.buttonPermutiraj.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPermutiraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPermutiraj.FlatAppearance.BorderSize = 0;
            this.buttonPermutiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPermutiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonPermutiraj.ForeColor = System.Drawing.Color.White;
            this.buttonPermutiraj.Location = new System.Drawing.Point(153, 69);
            this.buttonPermutiraj.Name = "buttonPermutiraj";
            this.buttonPermutiraj.Size = new System.Drawing.Size(126, 38);
            this.buttonPermutiraj.TabIndex = 2;
            this.buttonPermutiraj.Text = "Permutiraj!";
            this.buttonPermutiraj.UseVisualStyleBackColor = false;
            this.buttonPermutiraj.Click += new System.EventHandler(this.buttonPermutiraj_Click);
            // 
            // radioButtonBrojevi
            // 
            this.radioButtonBrojevi.AutoSize = true;
            this.radioButtonBrojevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.radioButtonBrojevi.ForeColor = System.Drawing.Color.White;
            this.radioButtonBrojevi.Location = new System.Drawing.Point(50, 57);
            this.radioButtonBrojevi.Name = "radioButtonBrojevi";
            this.radioButtonBrojevi.Size = new System.Drawing.Size(97, 30);
            this.radioButtonBrojevi.TabIndex = 3;
            this.radioButtonBrojevi.Text = "Brojevi";
            this.radioButtonBrojevi.UseVisualStyleBackColor = true;
            this.radioButtonBrojevi.CheckedChanged += new System.EventHandler(this.radioButtonBrojevi_CheckedChanged);
            // 
            // radioButtonSlova
            // 
            this.radioButtonSlova.AutoSize = true;
            this.radioButtonSlova.Checked = true;
            this.radioButtonSlova.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.radioButtonSlova.ForeColor = System.Drawing.Color.White;
            this.radioButtonSlova.Location = new System.Drawing.Point(50, 86);
            this.radioButtonSlova.Name = "radioButtonSlova";
            this.radioButtonSlova.Size = new System.Drawing.Size(85, 30);
            this.radioButtonSlova.TabIndex = 4;
            this.radioButtonSlova.TabStop = true;
            this.radioButtonSlova.Text = "Slova";
            this.radioButtonSlova.UseVisualStyleBackColor = true;
            // 
            // labelUkupnoPermutacija
            // 
            this.labelUkupnoPermutacija.AutoSize = true;
            this.labelUkupnoPermutacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelUkupnoPermutacija.ForeColor = System.Drawing.Color.White;
            this.labelUkupnoPermutacija.Location = new System.Drawing.Point(45, 164);
            this.labelUkupnoPermutacija.Name = "labelUkupnoPermutacija";
            this.labelUkupnoPermutacija.Size = new System.Drawing.Size(0, 26);
            this.labelUkupnoPermutacija.TabIndex = 5;
            // 
            // checkBoxPronadiPermutaciju
            // 
            this.checkBoxPronadiPermutaciju.AutoSize = true;
            this.checkBoxPronadiPermutaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.checkBoxPronadiPermutaciju.ForeColor = System.Drawing.Color.White;
            this.checkBoxPronadiPermutaciju.Location = new System.Drawing.Point(50, 122);
            this.checkBoxPronadiPermutaciju.Name = "checkBoxPronadiPermutaciju";
            this.checkBoxPronadiPermutaciju.Size = new System.Drawing.Size(225, 30);
            this.checkBoxPronadiPermutaciju.TabIndex = 9;
            this.checkBoxPronadiPermutaciju.Text = "Pronadi permutaciju";
            this.checkBoxPronadiPermutaciju.UseVisualStyleBackColor = true;
            this.checkBoxPronadiPermutaciju.CheckedChanged += new System.EventHandler(this.checkBoxPronadiPermutaciju_CheckedChanged);
            // 
            // labelPermutacijaPoRedu
            // 
            this.labelPermutacijaPoRedu.AutoSize = true;
            this.labelPermutacijaPoRedu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelPermutacijaPoRedu.ForeColor = System.Drawing.Color.White;
            this.labelPermutacijaPoRedu.Location = new System.Drawing.Point(45, 530);
            this.labelPermutacijaPoRedu.MaximumSize = new System.Drawing.Size(240, 0);
            this.labelPermutacijaPoRedu.Name = "labelPermutacijaPoRedu";
            this.labelPermutacijaPoRedu.Size = new System.Drawing.Size(0, 26);
            this.labelPermutacijaPoRedu.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(360, 602);
            this.Controls.Add(this.labelPermutacijaPoRedu);
            this.Controls.Add(this.checkBoxPronadiPermutaciju);
            this.Controls.Add(this.labelUkupnoPermutacija);
            this.Controls.Add(this.radioButtonSlova);
            this.Controls.Add(this.radioButtonBrojevi);
            this.Controls.Add(this.buttonPermutiraj);
            this.Controls.Add(this.listBoxIspisPermutacija);
            this.Controls.Add(this.textBoxUnosSlova);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnosSlova;
        private System.Windows.Forms.ListBox listBoxIspisPermutacija;
        private System.Windows.Forms.Button buttonPermutiraj;
        private System.Windows.Forms.RadioButton radioButtonBrojevi;
        private System.Windows.Forms.RadioButton radioButtonSlova;
        private System.Windows.Forms.Label labelUkupnoPermutacija;
        private System.Windows.Forms.CheckBox checkBoxPronadiPermutaciju;
        private System.Windows.Forms.Label labelPermutacijaPoRedu;
    }
}

