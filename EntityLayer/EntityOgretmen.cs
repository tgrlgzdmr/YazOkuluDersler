using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrtid;
        public int OOGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        private string ogrtadsoyad;
        public string OGRTADSOYAD
        {
            get { return ogrtadsoyad; }
            set { ogrtadsoyad = value; }
        }

        private int ogrtbrans;
        public int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }
    }
}
