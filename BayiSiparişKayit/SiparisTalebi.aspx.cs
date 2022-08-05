using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class SiparisTalebi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack == false)
        {

            List<EntityUrun> UrunList = BLLUrun.BllUrunListele();
            DropDownList1.DataSource = BLLUrun.BllUrunListele();
            DropDownList1.DataTextField = "Urun_adi";
            DropDownList1.DataValueField = "Urun_id";
            DropDownList1.DataBind();
            

        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            EntitySiparis ent = new EntitySiparis();
            ent.S_urun_id = int.Parse(DropDownList1.SelectedValue.ToString());
            ent.S_bayi_id = int.Parse(TextBox1.Text);
            BLLUrun.TalepEkleBLL(ent);
            Response.Redirect("SiparisListesi.Aspx");
        }
        catch
        {
            Response.Write("<b><font color=\"red\">Lütfen Verileri Doğru Şekilde Giriniz!</font></b> <br/>");
        }
        finally
        {
            
            TextBox1.Text = "";
            Response.Write("<b><font color=\"green\">Lütfen Siparişlerinizi Listeden Kontrol Ediniz!</font></b>");
        }
        
    }
}