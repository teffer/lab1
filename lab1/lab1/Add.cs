using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{
    public partial class Add : Form

    {
        MsDatabaseConn msDatabaseConn = new MsDatabaseConn();
        public Add()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            maskedTextBox2.PasswordChar = '*';
            msDatabaseConn.MakeConnection();
            button1.Text = Convert.ToString(msDatabaseConn.getConnectionState());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var login = maskedTextBox1.Text;
            var password = maskedTextBox2.Text;
            string sqlquerry = $"[INSERT INTO Table_1(login, password) VALUES('{login}','{password}']";
            SqlCommand command = new SqlCommand(sqlquerry, msDatabaseConn.getConnection());
            msDatabaseConn.CloseConnection();
            this.Close();
        }
    }
}
