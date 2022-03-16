using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"]);
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;
        List<EntityOgrenci> OgrDetay = BLLOgrenci.OgrenciDetayBll(x);
        TxtAd.Text=OgrDetay[0].AD.ToString();
        TxtSoyad.Text=OgrDetay[0].SOYAD.ToString();
        TxtMail.Text=OgrDetay[0].MAIL.ToString();
        TxtNo.Text=OgrDetay[0].NO.ToString();
        TxtSifre.Text=OgrDetay[0].SIFRE.ToString();
        //FupFoto.FileName = OgrDetay[0].FOTOGRAF.ToString();
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD=TxtAd.Text;
        ent.FOTOGRAF=FupFoto.FileName;
        ent.SOYAD=TxtSoyad.Text;
        ent.MAIL=TxtMail.Text;
        ent.NO=TxtNo.Text;
        ent.SIFRE = TxtSifre.Text;
        ent.ID = Convert.ToInt32(TxtID.Text);
        BLLOgrenci.OgrenciGuncelleBll(ent);
        Response.Redirect("OgrenciListesi.aspx");

    }
}