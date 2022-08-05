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
    public class DALUrun
    {
        public static List<EntityUrun> UrunListesi()
        {
            List<EntityUrun> entities = new List<EntityUrun>();

            SqlCommand cmd = new SqlCommand("Select * from TBL_URUNLER", Connection.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urun_id = Convert.ToInt32(dr["URUNID"].ToString());
                ent.Urun_adi = dr["URUNADI"].ToString();
                ent.Urun_stok = Convert.ToInt32(dr["URUNSTOK"].ToString()); 
                entities.Add(ent);
            }
            dr.Close();
            return entities;
        }


        public static int SiparisTalep(EntitySiparis parametre)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_SIPARISLER (SURUNID,SBAYIID)" +
                "values (@P1,@P2)", Connection.con);
            cmd.Parameters.AddWithValue("@P1", parametre.S_urun_id);
            cmd.Parameters.AddWithValue("@P2", parametre.S_bayi_id);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
