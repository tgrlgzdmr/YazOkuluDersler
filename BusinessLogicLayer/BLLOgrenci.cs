using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SIFRE != null && p.FOTOGRAF != null && p.MAIL != null && p.SOYAD != null && p.NO != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            else
                return -1;
        }

        public static List<EntityOgrenci> OgrenciListeleBll()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBll(int s)
        {
            if (s != null)
            {
                return DALOgrenci.OgrenciSil(s);
            }
            else
            {
                return false;
            }
        }
    }
}
