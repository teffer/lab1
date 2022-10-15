using System.Data.SqlClient;


namespace lab1
{
    class MsDatabaseConn
    {
        SqlConnection conn = new SqlConnection();

        public void MakeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.ConnectionString = "Data Source=DESKTOP-SFDM9J2;Initial Catalog=lab2;Integrated Security=True";
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
        public int getConnectionState()
        {
            switch (conn.State)
            {
                case System.Data.ConnectionState.Open:
                    return 1;
                case System.Data.ConnectionState.Closed:
                    return -1;
                default:
                    return -1;
            }
        }
    }
}
