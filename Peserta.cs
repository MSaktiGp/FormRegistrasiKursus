using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrasi
{
    internal class Peserta
    {
        //property
        int id;
        string nama;
        string bahasaPemrograman;
        string hariKursus;
        string jenisKelamin;
        string waktu;
        List<string> skill = new List<string>();

        //Konstruktor
        public Peserta()
        {

        }
        public Peserta(int id, string nama, string bahasaPemrograman,
            string hariKursus, string jenisKelamin, List<string> skill, string waktu)
        {
            this.id = id;
            this.nama = nama;
            this.bahasaPemrograman = bahasaPemrograman;
            this.hariKursus = hariKursus;
            this.jenisKelamin = jenisKelamin;
            this.skill = skill;
            this.waktu = waktu;
        }

        //method insert data ke database di mysql server
        protected const String conString = "server=localhost;database=db_regis;uid=root;pwd=;";
        public int insert()
        {
            string listSkill = "";
            foreach (string valSkill in this.skill)
            {
                if (listSkill == "")
                {
                    listSkill = valSkill;
                }
                else
                {
                    listSkill += ", " + valSkill;
                }
            }

            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO peserta (id,nama,bahasa,hari,jk,skill,waktu) VALUES(@id,@nama,@bahasaPemrograman,@hariKursus,@jenisKelamin,@skill,@waktu)");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@bahasaPemrograman", bahasaPemrograman);
            cmd.Parameters.AddWithValue("@hariKursus", hariKursus);
            cmd.Parameters.AddWithValue("@jenisKelamin", jenisKelamin);
            cmd.Parameters.AddWithValue("@skill", listSkill);
            cmd.Parameters.AddWithValue("@waktu", waktu);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;


            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }
        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            //cara 1
            MySqlConnection connect = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM peserta", connect))
            {
                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);

                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;
        }
    }
}
