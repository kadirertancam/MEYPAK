using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.ADONET
{
    public class AdoConnect
    {
        public SqlConnection con;
        public SqlDataReader sreader;
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public DataTable dt;

        public AdoConnect()
        {
            string aaa = "Server=213.238.167.117;Database=MEYPAK;User Id=sa;Password=sapass_1;";
            con = new SqlConnection(aaa);
        }
 
        public void Ac()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }



        public SqlConnection baglanti(string adres)
        {
            return con = new SqlConnection(ConfigurationManager.ConnectionStrings[adres].ConnectionString);
        }

        public void Kapa()
        {
            con.Close();
        }

        public void komutgonder(string deger)
        {
            Ac();
            cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = deger;
            cmd.ExecuteNonQuery();
            Kapa();
        }
        public DataTable komutoku(string deger)
        {
            Ac();
            ////adapter = new MySqlDataAdapter(deger, con);
            ////dt = new DataTable();


            ////adapter.Fill(dt);
            ////Kapa();
            ////return dt;


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(deger, con);
            adapter.SelectCommand.CommandTimeout = 9999;
            dt = new DataTable();
            adapter.Fill(dt);
            Kapa();
            return dt;

        }
    }
}
