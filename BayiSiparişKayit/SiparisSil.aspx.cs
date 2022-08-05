using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class SiparisSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
         EntitySiparis ent = new EntitySiparis();
        try
        {
            int bayi_id = ent.S_bayi_id = int.Parse(TextBox2.Text);
            int sip_id = ent.Siparis_id = int.Parse(TextBox3.Text);
            BLLSiparis.BllSiparisSilBLL(bayi_id, sip_id);
            Response.Redirect("SiparisListesi.Aspx");
        }
        catch
        {
            Response.Write("<b><font color=\"red\">Lütfen Verileri Doğru Şekilde Giriniz!</font></b> <br/>");
        }
        finally
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            Response.Write("<b><font color=\"green\">Lütfen Siparişlerinizi Listeden Kontrol Ediniz!</font></b>");
        }
         
        
       
            




    }
}