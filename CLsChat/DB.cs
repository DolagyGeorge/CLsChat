using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CLsChat
{
    internal static class DB
    {
        public static int UserID { get; set; }
        private static SqlConnection con = new SqlConnection();
       private static SqlCommand cmd = new SqlCommand();
       public static void begin()
       {
            con.ConnectionString = "server=sql1002.site4now.net; database=db_ab231e_chat  ;user id=db_ab231e_chat_admin ; password= 123dolagy;";
            con.Open(); 
            cmd.Connection = con;
       }
        public static void execute(string com)
        {
            cmd.CommandText = com;
            cmd.ExecuteNonQuery();
        
        }


        public static string Searchscaler(string select)
        {
            string result = null;
            cmd.CommandText = select;
            if (cmd.ExecuteScalar() != null)
            {
                result = cmd.ExecuteScalar().ToString();
            }
            return result;

        }
        public static DataTable SearchTable(string select)
        {

            cmd.CommandText = select;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);    
            dr.Close();
            return dt;
        }
        public static void FillList(string select, ListBox lst)
        {
            DataTable dt = new DataTable();
            dt = SearchTable(select);
            lst.DataSource = dt;
            lst.DisplayMember = dt.Columns[1].ColumnName;
            lst.ValueMember = dt.Columns[0].ColumnName;
        }
        public static void FillGrid(string select, DataGridView grid)
        {
            grid.DataSource = SearchTable(select);
            grid.Refresh();
        }


    }
}
