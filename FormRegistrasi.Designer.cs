namespace Registrasi
{
    partial class FormRegistrasi
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
            labelNama = new Label();
            labelPilih = new Label();
            labelHari = new Label();
            labelSkill = new Label();
            labelWaktu = new Label();
            textBoxNama = new TextBox();
            comboBoxBahasaPemrograman = new ComboBox();
            checkBoxWeb = new CheckBox();
            checkBoxMobile = new CheckBox();
            checkBoxDesktop = new CheckBox();
            listBoxWaktu = new ListBox();
            labelJudul = new Label();
            labelJK = new Label();
            radioButtonH1 = new RadioButton();
            radioButtonH2 = new RadioButton();
            radioButtonH3 = new RadioButton();
            radioButtonLk = new RadioButton();
            radioButtonP = new RadioButton();
            richTextBoxHasil = new RichTextBox();
            buttonDaftar = new Button();
            groupBoxHari = new GroupBox();
            groupBoxJK = new GroupBox();
            dataGridViewPeserta = new DataGridView();
            groupBoxHari.SuspendLayout();
            groupBoxJK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeserta).BeginInit();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(12, 60);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            // 
            // labelPilih
            // 
            labelPilih.AutoSize = true;
            labelPilih.Location = new Point(12, 92);
            labelPilih.Name = "labelPilih";
            labelPilih.Size = new Size(109, 15);
            labelPilih.TabIndex = 1;
            labelPilih.Text = "Pilih Pemrograman";
            // 
            // labelHari
            // 
            labelHari.AutoSize = true;
            labelHari.Location = new Point(12, 133);
            labelHari.Name = "labelHari";
            labelHari.Size = new Size(93, 15);
            labelHari.TabIndex = 2;
            labelHari.Text = "Pilih Hari Kursus";
            // 
            // labelSkill
            // 
            labelSkill.AutoSize = true;
            labelSkill.Location = new Point(12, 295);
            labelSkill.Name = "labelSkill";
            labelSkill.Size = new Size(107, 15);
            labelSkill.TabIndex = 3;
            labelSkill.Text = "Skill Pemrograman";
            // 
            // labelWaktu
            // 
            labelWaktu.AutoSize = true;
            labelWaktu.Location = new Point(12, 372);
            labelWaktu.Name = "labelWaktu";
            labelWaktu.Size = new Size(67, 15);
            labelWaktu.TabIndex = 4;
            labelWaktu.Text = "Pilih Waktu";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(170, 57);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(247, 23);
            textBoxNama.TabIndex = 5;
            // 
            // comboBoxBahasaPemrograman
            // 
            comboBoxBahasaPemrograman.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBahasaPemrograman.FormattingEnabled = true;
            comboBoxBahasaPemrograman.Items.AddRange(new object[] { "C#", "Java", "Python", "C++", "C" });
            comboBoxBahasaPemrograman.Location = new Point(170, 89);
            comboBoxBahasaPemrograman.Name = "comboBoxBahasaPemrograman";
            comboBoxBahasaPemrograman.Size = new Size(247, 23);
            comboBoxBahasaPemrograman.TabIndex = 6;
            comboBoxBahasaPemrograman.SelectedValueChanged += comboBoxBahasaPemrograman_SelectedValueChanged;
            // 
            // checkBoxWeb
            // 
            checkBoxWeb.AutoSize = true;
            checkBoxWeb.Location = new Point(170, 291);
            checkBoxWeb.Name = "checkBoxWeb";
            checkBoxWeb.Size = new Size(129, 19);
            checkBoxWeb.TabIndex = 7;
            checkBoxWeb.Text = "Pemrograman Web";
            checkBoxWeb.UseVisualStyleBackColor = true;
            checkBoxWeb.CheckedChanged += checkBoxWeb_CheckedChanged;
            // 
            // checkBoxMobile
            // 
            checkBoxMobile.AutoSize = true;
            checkBoxMobile.Location = new Point(170, 316);
            checkBoxMobile.Name = "checkBoxMobile";
            checkBoxMobile.Size = new Size(142, 19);
            checkBoxMobile.TabIndex = 8;
            checkBoxMobile.Text = "Pemrograman Mobile";
            checkBoxMobile.UseVisualStyleBackColor = true;
            checkBoxMobile.CheckedChanged += checkBoxMobile_CheckedChanged;
            // 
            // checkBoxDesktop
            // 
            checkBoxDesktop.AutoSize = true;
            checkBoxDesktop.Location = new Point(170, 341);
            checkBoxDesktop.Name = "checkBoxDesktop";
            checkBoxDesktop.Size = new Size(148, 19);
            checkBoxDesktop.TabIndex = 9;
            checkBoxDesktop.Text = "Pemrograman Desktop";
            checkBoxDesktop.UseVisualStyleBackColor = true;
            checkBoxDesktop.CheckedChanged += checkBoxDesktop_CheckedChanged;
            // 
            // listBoxWaktu
            // 
            listBoxWaktu.FormattingEnabled = true;
            listBoxWaktu.ItemHeight = 15;
            listBoxWaktu.Items.AddRange(new object[] { "Jam 09:00 - 11:00", "Jam 11:00 - 13:00", "Jam 13:00 - 15:00", "Jam 15:00 - 17:00" });
            listBoxWaktu.Location = new Point(170, 372);
            listBoxWaktu.Name = "listBoxWaktu";
            listBoxWaktu.Size = new Size(120, 64);
            listBoxWaktu.TabIndex = 11;
            listBoxWaktu.SelectedIndexChanged += listBoxWaktu_SelectedIndexChanged;
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudul.Location = new Point(131, 9);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(139, 21);
            labelJudul.TabIndex = 12;
            labelJudul.Text = "Form Pendaftaran";
            // 
            // labelJK
            // 
            labelJK.AutoSize = true;
            labelJK.Location = new Point(12, 214);
            labelJK.Name = "labelJK";
            labelJK.Size = new Size(78, 15);
            labelJK.TabIndex = 13;
            labelJK.Text = "Jenis Kelamin";
            // 
            // radioButtonH1
            // 
            radioButtonH1.AutoSize = true;
            radioButtonH1.Location = new Point(0, 13);
            radioButtonH1.Name = "radioButtonH1";
            radioButtonH1.Size = new Size(92, 19);
            radioButtonH1.TabIndex = 14;
            radioButtonH1.TabStop = true;
            radioButtonH1.Text = "Senin - Rabu";
            radioButtonH1.UseVisualStyleBackColor = true;
            radioButtonH1.CheckedChanged += radioButtonH1_CheckedChanged;
            // 
            // radioButtonH2
            // 
            radioButtonH2.AutoSize = true;
            radioButtonH2.Location = new Point(0, 38);
            radioButtonH2.Name = "radioButtonH2";
            radioButtonH2.Size = new Size(100, 19);
            radioButtonH2.TabIndex = 15;
            radioButtonH2.TabStop = true;
            radioButtonH2.Text = "Selasa - Kamis";
            radioButtonH2.UseVisualStyleBackColor = true;
            radioButtonH2.CheckedChanged += radioButtonH2_CheckedChanged;
            // 
            // radioButtonH3
            // 
            radioButtonH3.AutoSize = true;
            radioButtonH3.Location = new Point(0, 63);
            radioButtonH3.Name = "radioButtonH3";
            radioButtonH3.Size = new Size(108, 19);
            radioButtonH3.TabIndex = 16;
            radioButtonH3.TabStop = true;
            radioButtonH3.Text = "Sabtu - Minggu";
            radioButtonH3.UseVisualStyleBackColor = true;
            radioButtonH3.CheckedChanged += radioButtonH3_CheckedChanged;
            // 
            // radioButtonLk
            // 
            radioButtonLk.AutoSize = true;
            radioButtonLk.Location = new Point(0, 12);
            radioButtonLk.Name = "radioButtonLk";
            radioButtonLk.Size = new Size(69, 19);
            radioButtonLk.TabIndex = 17;
            radioButtonLk.TabStop = true;
            radioButtonLk.Text = "Laki-laki";
            radioButtonLk.UseVisualStyleBackColor = true;
            radioButtonLk.CheckedChanged += radioButtonLk_CheckedChanged;
            // 
            // radioButtonP
            // 
            radioButtonP.AutoSize = true;
            radioButtonP.Location = new Point(0, 37);
            radioButtonP.Name = "radioButtonP";
            radioButtonP.Size = new Size(86, 19);
            radioButtonP.TabIndex = 18;
            radioButtonP.TabStop = true;
            radioButtonP.Text = "Perempuan";
            radioButtonP.UseVisualStyleBackColor = true;
            radioButtonP.CheckedChanged += radioButtonP_CheckedChanged;
            // 
            // richTextBoxHasil
            // 
            richTextBoxHasil.Location = new Point(473, 12);
            richTextBoxHasil.Name = "richTextBoxHasil";
            richTextBoxHasil.Size = new Size(798, 206);
            richTextBoxHasil.TabIndex = 19;
            richTextBoxHasil.Text = "";
            richTextBoxHasil.TextChanged += richTextBox1_TextChanged;
            // 
            // buttonDaftar
            // 
            buttonDaftar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDaftar.Location = new Point(217, 483);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(92, 36);
            buttonDaftar.TabIndex = 20;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = true;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // groupBoxHari
            // 
            groupBoxHari.Controls.Add(radioButtonH1);
            groupBoxHari.Controls.Add(radioButtonH2);
            groupBoxHari.Controls.Add(radioButtonH3);
            groupBoxHari.Location = new Point(170, 118);
            groupBoxHari.Name = "groupBoxHari";
            groupBoxHari.Size = new Size(139, 88);
            groupBoxHari.TabIndex = 21;
            groupBoxHari.TabStop = false;
            // 
            // groupBoxJK
            // 
            groupBoxJK.Controls.Add(radioButtonLk);
            groupBoxJK.Controls.Add(radioButtonP);
            groupBoxJK.Location = new Point(170, 214);
            groupBoxJK.Name = "groupBoxJK";
            groupBoxJK.Size = new Size(139, 61);
            groupBoxJK.TabIndex = 22;
            groupBoxJK.TabStop = false;
            // 
            // dataGridViewPeserta
            // 
            dataGridViewPeserta.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewPeserta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeserta.Location = new Point(473, 226);
            dataGridViewPeserta.Name = "dataGridViewPeserta";
            dataGridViewPeserta.Size = new Size(798, 275);
            dataGridViewPeserta.TabIndex = 23;
            // 
            // FormRegistrasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 583);
            Controls.Add(dataGridViewPeserta);
            Controls.Add(groupBoxJK);
            Controls.Add(groupBoxHari);
            Controls.Add(buttonDaftar);
            Controls.Add(richTextBoxHasil);
            Controls.Add(labelJK);
            Controls.Add(labelJudul);
            Controls.Add(listBoxWaktu);
            Controls.Add(checkBoxDesktop);
            Controls.Add(checkBoxMobile);
            Controls.Add(checkBoxWeb);
            Controls.Add(comboBoxBahasaPemrograman);
            Controls.Add(textBoxNama);
            Controls.Add(labelWaktu);
            Controls.Add(labelSkill);
            Controls.Add(labelHari);
            Controls.Add(labelPilih);
            Controls.Add(labelNama);
            Name = "FormRegistrasi";
            Text = "Form Registrasi";
            groupBoxHari.ResumeLayout(false);
            groupBoxHari.PerformLayout();
            groupBoxJK.ResumeLayout(false);
            groupBoxJK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeserta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelPilih;
        private Label labelHari;
        private Label labelSkill;
        private Label labelWaktu;
        private TextBox textBoxNama;
        private ComboBox comboBoxBahasaPemrograman;
        private CheckBox checkBoxWeb;
        private CheckBox checkBoxMobile;
        private CheckBox checkBoxDesktop;
        private ListBox listBoxWaktu;
        private Label labelJudul;
        private Label labelJK;
        private RadioButton radioButtonH1;
        private RadioButton radioButtonH2;
        private RadioButton radioButtonH3;
        private RadioButton radioButtonLk;
        private RadioButton radioButtonP;
        private RichTextBox richTextBoxHasil;
        private Button buttonDaftar;
        private GroupBox groupBoxHari;
        private GroupBox groupBoxJK;
        private DataGridView dataGridViewPeserta;
    }
}