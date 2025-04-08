using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrasi
{
    public partial class FormRegistrasi : Form
    {
        String bahasaPemrograman;
        String hariKursus;
        String jenisKelamin;
        List<String> skill = new List<string>();
        String waktu;
        int id;
        string nama;
        List<Peserta> listPeserta = new List<Peserta>();
        public FormRegistrasi()
        {
            InitializeComponent();
            bahasaPemrograman = "";
            hariKursus = "";
            jenisKelamin = "";
            waktu = "";
            id = 0;
            nama = "";
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            //membuat objek peserta
            id++;
            nama = textBoxNama.Text;
            Peserta peserta = new Peserta(id, nama, bahasaPemrograman, hariKursus, jenisKelamin, skill, waktu);
            //menambahkan objek peserta ke dalam listPeserta
            listPeserta.Add(peserta);
            //menampilkan hasil isian form ke richtextbox
            richTextBoxHasil.AppendText("Anda sudah melakukan registrasi dengan rincian sebagai berikut:\n");
            richTextBoxHasil.AppendText("Nama :" + nama + "\n");
            richTextBoxHasil.AppendText("Jenis Kelamin :" + jenisKelamin + "\n");
            richTextBoxHasil.AppendText("Bahasa Pemrograman :" + bahasaPemrograman + "\n");
            richTextBoxHasil.AppendText("Hari Kursus :" + hariKursus + "\n");
            richTextBoxHasil.AppendText("Pilihan Skill:\n");
            foreach (String valSkill in skill)
            {
                richTextBoxHasil.AppendText(valSkill.ToString() + "\n");
            }
            richTextBoxHasil.AppendText("Waktu kursus: " +  waktu + "\n");
            //menyimpan data ke db
            if (peserta.insert() != 0)
            {
                MessageBox.Show("Insert data Sukses");
            }
            else
            {
                MessageBox.Show("Insert data gagal");
            }
            loadData();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBahasaPemrograman_SelectedValueChanged(object sender, EventArgs e)
        {
            bahasaPemrograman = comboBoxBahasaPemrograman.SelectedItem.ToString();
        }

        private void checkBoxWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeb.Checked)
            {
                //tambahkan skill web pada list skill
                skill.Add(checkBoxWeb.Text);
            }
            else
            {
                //menghapus skill web pada list skill
                skill.Remove(checkBoxWeb.Text);
            }
        }

        private void checkBoxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMobile.Checked)
            {
                skill.Add(checkBoxMobile.Text);
            }
            else
            {
                skill.Remove(checkBoxMobile.Text);
            }
        }

        private void checkBoxDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesktop.Checked)
            {
                skill.Add(checkBoxDesktop.Text);
            }
            else
            {
                skill.Remove(checkBoxDesktop.Text);
            }
        }

        private void radioButtonH1_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonH1.Text;
        }

        private void radioButtonH2_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonH2.Text;
        }

        private void radioButtonH3_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonH3.Text;
        }

        private void radioButtonLk_CheckedChanged(object sender, EventArgs e)
        {
            jenisKelamin = radioButtonLk.Text;
        }

        private void radioButtonP_CheckedChanged(object sender, EventArgs e)
        {
            jenisKelamin = radioButtonP.Text;
        }

        private void listBoxWaktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            waktu = listBoxWaktu.Text;
        }
        private void Regis_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable dt = new DataTable();
            dt = Peserta.SelectAll();
            dataGridViewPeserta.DataSource = dt;
            dataGridViewPeserta.Show();
        }
    }
}
