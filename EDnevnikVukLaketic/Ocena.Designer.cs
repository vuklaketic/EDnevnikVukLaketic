
namespace EDnevnikVukLaketic
{
    partial class Ocena
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
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_profesor = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_ocena = new System.Windows.Forms.ComboBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(12, 31);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(121, 21);
            this.cmb_godina.TabIndex = 0;
            this.cmb_godina.SelectedIndexChanged += new System.EventHandler(this.cmb_godina_SelectedIndexChanged);
            // 
            // cmb_profesor
            // 
            this.cmb_profesor.FormattingEnabled = true;
            this.cmb_profesor.Location = new System.Drawing.Point(139, 31);
            this.cmb_profesor.Name = "cmb_profesor";
            this.cmb_profesor.Size = new System.Drawing.Size(121, 21);
            this.cmb_profesor.TabIndex = 1;
            this.cmb_profesor.SelectedIndexChanged += new System.EventHandler(this.cmb_profesor_SelectedIndexChanged);
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(266, 31);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_predmet.TabIndex = 2;
            this.cmb_predmet.SelectedIndexChanged += new System.EventHandler(this.cmb_predmet_SelectedIndexChanged);
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(393, 31);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(121, 21);
            this.cmb_odeljenje.TabIndex = 3;
            this.cmb_odeljenje.SelectedIndexChanged += new System.EventHandler(this.cmb_odeljenje_SelectedIndexChanged);
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(12, 89);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(121, 21);
            this.cmb_ucenik.TabIndex = 4;
            this.cmb_ucenik.SelectedIndexChanged += new System.EventHandler(this.cmb_ucenik_SelectedIndexChanged);
            // 
            // cmb_ocena
            // 
            this.cmb_ocena.FormattingEnabled = true;
            this.cmb_ocena.Location = new System.Drawing.Point(139, 89);
            this.cmb_ocena.Name = "cmb_ocena";
            this.cmb_ocena.Size = new System.Drawing.Size(121, 21);
            this.cmb_ocena.TabIndex = 5;
            this.cmb_ocena.SelectedIndexChanged += new System.EventHandler(this.cmb_ocena_SelectedIndexChanged);
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum.Location = new System.Drawing.Point(393, 89);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(121, 20);
            this.datum.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(266, 89);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(542, 29);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 8;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Izmeni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(542, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Brisi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 185);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Godina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profesor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ucenik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ocena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Datum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 20);
            this.textBox1.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.cmb_ocena);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_profesor);
            this.Controls.Add(this.cmb_godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_profesor;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.ComboBox cmb_ocena;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}