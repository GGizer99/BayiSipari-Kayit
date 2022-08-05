using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class SiparisListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntitySiparis> SiparisList = BLLSiparis.BllSiparisListele();
        Repeater1.DataSource = SiparisList;
        Repeater1.DataBind();
        Response.Write("<b><font color=\"green\">Lütfen Siparişlerinizi Listeden Kontrol Ediniz!</font></b>");
    }
}