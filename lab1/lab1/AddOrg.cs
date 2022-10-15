using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{
    public partial class AddOrg : Form
    {
        MsDatabaseConn msDatabaseConn = new MsDatabaseConn();
        public AddOrg()
        {
            InitializeComponent();
        }

        private void AddOrg_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msDatabaseConn.MakeConnection();
            var login = textBox1.Text;
            var password = textBox2.Text;
            string sqlquerry = $"[INSERT INTO Table_2(login, password) VALUES('{login}','{password}']";
            SqlCommand command = new SqlCommand(sqlquerry, msDatabaseConn.getConnection());
            msDatabaseConn.CloseConnection();
            this.Close();
        }
    }
}
