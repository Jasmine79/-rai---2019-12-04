namespace Golf
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
            this.label_tagsagi_kod = new System.Windows.Forms.Label();
            this.label_Nev = new System.Windows.Forms.Label();
            this.label_Szuletett = new System.Windows.Forms.Label();
            this.label_Magassag = new System.Windows.Forms.Label();
            this.numericUpDown_kod = new System.Windows.Forms.NumericUpDown();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Magassag = new System.Windows.Forms.NumericUpDown();
            this.label_cm = new System.Windows.Forms.Label();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.listBox_Tagok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Magassag)).BeginInit();
            this.SuspendLayout();
            // 
            // label_tagsagi_kod
            // 
            this.label_tagsagi_kod.AutoSize = true;
            this.label_tagsagi_kod.Location = new System.Drawing.Point(61, 58);
            this.label_tagsagi_kod.Name = "label_tagsagi_kod";
            this.label_tagsagi_kod.Size = new System.Drawing.Size(69, 13);
            this.label_tagsagi_kod.TabIndex = 0;
            this.label_tagsagi_kod.Tag = "Tagsagi_kod";
            this.label_tagsagi_kod.Text = "Tagsági kód:";
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Location = new System.Drawing.Point(61, 102);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(30, 13);
            this.label_Nev.TabIndex = 1;
            this.label_Nev.Tag = "Név";
            this.label_Nev.Text = "Név:";
            // 
            // label_Szuletett
            // 
            this.label_Szuletett.AutoSize = true;
            this.label_Szuletett.Location = new System.Drawing.Point(61, 136);
            this.label_Szuletett.Name = "label_Szuletett";
            this.label_Szuletett.Size = new System.Drawing.Size(51, 13);
            this.label_Szuletett.TabIndex = 2;
            this.label_Szuletett.Tag = "szuletett";
            this.label_Szuletett.Text = "Született:";
            // 
            // label_Magassag
            // 
            this.label_Magassag.AutoSize = true;
            this.label_Magassag.Location = new System.Drawing.Point(61, 172);
            this.label_Magassag.Name = "label_Magassag";
            this.label_Magassag.Size = new System.Drawing.Size(59, 13);
            this.label_Magassag.TabIndex = 3;
            this.label_Magassag.Tag = "Magassag";
            this.label_Magassag.Text = "Magasság:";
            // 
            // numericUpDown_kod
            // 
            this.numericUpDown_kod.Location = new System.Drawing.Point(144, 54);
            this.numericUpDown_kod.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_kod.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_kod.Name = "numericUpDown_kod";
            this.numericUpDown_kod.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown_kod.TabIndex = 4;
            this.numericUpDown_kod.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(143, 99);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(130, 20);
            this.textBox_Nev.TabIndex = 5;
            this.textBox_Nev.Tag = "Nev";
            this.textBox_Nev.Text = "Név";
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(142, 131);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker_Szuletett.TabIndex = 6;
            // 
            // numericUpDown_Magassag
            // 
            this.numericUpDown_Magassag.Location = new System.Drawing.Point(142, 170);
            this.numericUpDown_Magassag.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown_Magassag.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_Magassag.Name = "numericUpDown_Magassag";
            this.numericUpDown_Magassag.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown_Magassag.TabIndex = 7;
            this.numericUpDown_Magassag.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label_cm
            // 
            this.label_cm.AutoSize = true;
            this.label_cm.Location = new System.Drawing.Point(280, 172);
            this.label_cm.Name = "label_cm";
            this.label_cm.Size = new System.Drawing.Size(21, 13);
            this.label_cm.TabIndex = 8;
            this.label_cm.Text = "cm";
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(67, 242);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(75, 23);
            this.button_Insert.TabIndex = 9;
            this.button_Insert.Text = "Rögzítés";
            this.button_Insert.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(67, 271);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(67, 300);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 11;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // listBox_Tagok
            // 
            this.listBox_Tagok.FormattingEnabled = true;
            this.listBox_Tagok.Location = new System.Drawing.Point(364, 55);
            this.listBox_Tagok.Name = "listBox_Tagok";
            this.listBox_Tagok.Size = new System.Drawing.Size(203, 264);
            this.listBox_Tagok.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Tagok);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.label_cm);
            this.Controls.Add(this.numericUpDown_Magassag);
            this.Controls.Add(this.dateTimePicker_Szuletett);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.numericUpDown_kod);
            this.Controls.Add(this.label_Magassag);
            this.Controls.Add(this.label_Szuletett);
            this.Controls.Add(this.label_Nev);
            this.Controls.Add(this.label_tagsagi_kod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Magassag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tagsagi_kod;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.Label label_Szuletett;
        private System.Windows.Forms.Label label_Magassag;
        private System.Windows.Forms.NumericUpDown numericUpDown_kod;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.NumericUpDown numericUpDown_Magassag;
        private System.Windows.Forms.Label label_cm;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ListBox listBox_Tagok;
    }
}

