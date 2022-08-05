using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class BayiListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityBayi> BayiList = BLLBayi.BllBayiListele();
        Repeater1.DataSource = BayiList;
        Repeater1.DataBind();
    }
}