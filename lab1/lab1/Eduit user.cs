using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{
    public partial class Eduit_user : Form
    {
        MsDatabaseConn msDatabaseConn = new MsDatabaseConn();
        public Eduit_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msDatabaseConn.MakeConnection();
            var login = textBox1.Text;
            var password = textBox2.Text;
            string sqlquerry = $"[UPDATE Table_1 SET login = '{login}' AND password = '{password}]";
            SqlCommand command = new SqlCommand(sqlquerry, msDatabaseConn.getConnection());
            msDatabaseConn.CloseConnection();
            this.Close();
        }

        private void Eduit_user_Load(object sender, EventArgs e)
        {

            textBox2.PasswordChar = '*';
        }
    }
}
