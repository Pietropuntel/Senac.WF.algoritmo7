using System.Windows.Forms;

namespace projeto_windows_forms_07
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
                textBox1.Text = string.Empty;
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {

                textBox1.Text = "Usuario";
            }
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
                textBox2.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
                textBox1.Text = string.Empty;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Usuario";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
                textBox2.Text = string.Empty;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {


            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "Senha";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
