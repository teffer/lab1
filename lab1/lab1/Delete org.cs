using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{
    public partial class Delete_org : Form
    {
        MsDatabaseConn msDatabaseConn = new MsDatabaseConn();
        public Delete_org()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msDatabaseConn.MakeConnection();
            var login = textBox1.Text;
            var password = textBox2.Text;
            string sqlquerry = $"[DELETE * from Table_2 where login = '{login}', password = '{password}'";
            SqlCommand command = new SqlCommand(sqlquerry, msDatabaseConn.getConnection());
            msDatabaseConn.CloseConnection();
            this.Close();
        }
    }
}
