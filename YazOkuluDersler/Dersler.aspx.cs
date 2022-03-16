using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(Page.IsPostBack==false)
        { 
            //List<EntityDersler> derslist = BLLDersler.DersListeleBll();
            DropDownList1.DataSource = BLLDersler.DersListeleBll();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "DERSID";
            DropDownList1.DataBind();
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvuru ent = new EntityBasvuru();
        ent.BASDERSID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
        ent.BASOGRID= Convert.ToInt32(TxtOgrID.Text);
        BLLDersler.BasvuruEkleBll(ent);
    }
}