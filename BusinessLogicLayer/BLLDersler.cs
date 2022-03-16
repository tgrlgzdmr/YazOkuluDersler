using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDersler
    {
        public static List<EntityDersler> DersListeleBll()
        {
            return DALDersler.DersListele();
        }

        public static int BasvuruEkleBll(EntityBasvuru basvur)
        {
            if (basvur.BASOGRID != 0 && basvur.BASDERSID != 0)
            {
                return DALDersler.TalepEkle(basvur);
            }
            else
                return -1;
        }
    }
}
