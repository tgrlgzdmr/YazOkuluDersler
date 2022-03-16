using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDersler
    {
        public static List<EntityDersler> DersListele()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand cmd = new SqlCommand("select * from TblDersler",Baglanti.bgl);
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.DERSID=Convert.ToInt32(dr["Dersid"].ToString());
                ent.DERSAD = dr["DersAd"].ToString();
                ent.MAX = Convert.ToInt32(dr["DersMaxKontenjan"].ToString());
                ent.MIN = Convert.ToInt32(dr["DersMinKontenjan"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuru basvuru)
        {
            SqlCommand cmd1 = new SqlCommand("insert into TblBasvuru (Ogrid,Dersid) values (@p1,@p2)", Baglanti.bgl);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            cmd1.Parameters.AddWithValue("@p1", basvuru.BASOGRID);
            cmd1.Parameters.AddWithValue("@p2", basvuru.BASDERSID);
            return cmd1.ExecuteNonQuery();
        }
    }
}
