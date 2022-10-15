using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{
    public partial class Delete_User : Form
    {
        MsDatabaseConn msDatabaseConn = new MsDatabaseConn();
        public Delete_User()
        {
            InitializeComponent();
        }

        private void Delete_User_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msDatabaseConn.MakeConnection();
            var login = textBox1.Text;
            var password = textBox2.Text;
            string sqlquerry = $"[DELETE * from Table_1 where login = '{login}' AND password = '{password}'";
            SqlCommand command = new SqlCommand(sqlquerry, msDatabaseConn.getConnection());
            msDatabaseConn.CloseConnection();
            this.Close();
        }
    }
}
