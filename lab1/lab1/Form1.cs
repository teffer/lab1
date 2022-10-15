using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{

    public partial class Form1 : Form
    {
        MsDatabaseConn Msdb = new MsDatabaseConn();
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Table_1 ORDER BY id";
            SqlCommand comm = new SqlCommand(querry, Msdb.getConnection());
            Msdb.MakeConnection();
            button10.Text = Convert.ToString(Msdb.getConnectionState());
            if (Msdb.getConnectionState() == 1)
            {
                button10.Text = "asdasdsa";
                SqlDataReader reader = comm.ExecuteReader();
                List<string[]> content1 = new List<string[]>();

                while (reader.Read())
                {
                    content1.Add(new string[3]);
                    content1[content1.Count - 1][0] = reader[0].ToString();
                    content1[content1.Count - 1][1] = reader[1].ToString();
                    content1[content1.Count - 1][2] = reader[2].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddOrg add = new AddOrg();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_User delete_User = new Delete_User();
            delete_User.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete_org delete_Org = new Delete_org();
            delete_Org.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Eduit_user eduit_User = new Eduit_user();
            eduit_User.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
