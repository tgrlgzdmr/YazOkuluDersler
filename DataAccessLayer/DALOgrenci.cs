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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand cmd = new SqlCommand("insert into TblOgrenci (OgrAd,OgrSoyad,OgrNo,OgrMail,OgrSifre,OgrFoto) values (@p1,@p2,@p3,@p4,@p5,@p6)",Baglanti.bgl);
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", parametre.AD);
            cmd.Parameters.AddWithValue("@p2", parametre.SOYAD);
            cmd.Parameters.AddWithValue("@p3", parametre.NO);
            cmd.Parameters.AddWithValue("@p4", parametre.MAIL);
            cmd.Parameters.AddWithValue("@p5", parametre.SIFRE);
            cmd.Parameters.AddWithValue("@p6", parametre.FOTOGRAF);

            return cmd.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd1 = new SqlCommand("select * from TblOgrenci", Baglanti.bgl);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["Ogrid"].ToString());
                ent.AD= dr["OgrAd"].ToString();
                ent.SOYAD= dr["OgrSoyad"].ToString();
                ent.NO= dr["OgrNo"].ToString();
                ent.MAIL= dr["OgrMail"].ToString();
                ent.SIFRE= dr["OgrSifre"].ToString();
                ent.BAKIYE=Convert.ToDouble(dr["OgrBakiye"].ToString());
                ent.FOTOGRAF= dr["OgrFoto"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int par)
        {
            SqlCommand cmd2=new SqlCommand("delete from TblOgrenci where Ogrid=@s1",Baglanti.bgl);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@s1", par);
            return cmd2.ExecuteNonQuery()>0;
        }
    }
}
