using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALBayi
    {
        public static List<EntityBayi> BayiListesi()
        {
            List<EntityBayi> entities = new List<EntityBayi>();

            SqlCommand cmd = new SqlCommand("Select * from TBL_BAYI", Connection.con);
            if(cmd.Connection.State!= ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EntityBayi ent = new EntityBayi();
                ent.Bayi_ad = dr["BAYIADI"].ToString();
                ent.Bayi_adres = dr["BAYIADRES"].ToString();
                ent.Bayi_tel = dr["BAYITEL"].ToString();
                entities.Add(ent);
            }
            dr.Close();
            return entities;
        }
          
    }
}
