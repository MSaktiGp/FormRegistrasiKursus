namespace Registrasi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPw.Clear();
            textBoxUsn.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsn.Text == "" && textBoxPw.Text == "")
            {
                MessageBox.Show("Login Berhasil!");
                this.Hide();
                FormRegistrasi newfrm = new FormRegistrasi();
                newfrm.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal!!");
                textBoxPw.Clear();
                textBoxUsn.Clear();
            }
        }
    }
}
