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
    public class DALSiparis
    {

        public static List<EntitySiparis> SiparisListesi()
        {
            List<EntitySiparis> entities = new List<EntitySiparis>();

            SqlCommand cmd = new SqlCommand("Select TBL_BAYI.BAYIADI,TBL_URUNLER.URUNADI,TBL_SIPARISLER.SIPARISID from " +
                "TBL_BAYI join TBL_SIPARISLER on TBL_BAYI.BAYIID = TBL_SIPARISLER.SBAYIID join TBL_URUNLER on" +
                " TBL_URUNLER.URUNID = TBL_SIPARISLER.SURUNID", Connection.con);

            /*string sql = "Select TBL_BAYI.BAYIADI,TBL_URUNLER.URUNADI,TBL_SIPARISLER.SIPARISID from " +
                "TBL_BAYI join TBL_SIPARISLER on TBL_BAYI.BAYIID = TBL_SIPARISLER.SBAYIID join TBL_URUNLER on TBL_URUNLER.URUNID = TBL_SIPARISLER.SURUNID";*/

       
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EntitySiparis ent = new EntitySiparis();
                ent.Siparis_id = Convert.ToInt32(dr["SIPARISID"].ToString());
                ent.S_urun_adi = dr["URUNADI"].ToString();
                ent.S_bayi_adi = dr["BAYIADI"].ToString();
                entities.Add(ent);
            }
            dr.Close();
            return entities;
        }

        public static bool SiparisSil(int bayi_id_pr,int sip_id_pr)
        {
            SqlCommand cmd = new SqlCommand("Delete from TBL_SIPARISLER where SBAYIID=@P1 AND SIPARISID=@P2 ", Connection.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", bayi_id_pr);
            cmd.Parameters.AddWithValue("@P2", sip_id_pr);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool SiparisGuncelle(EntitySiparis siparis)
        {
            SqlCommand cmd = new SqlCommand("Update TBL_SIPARISLER Set SURUNID=@P1 where SBAYIID=@P2 AND SIPARISID=@P3 ", Connection.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", siparis.S_urun_id);
            cmd.Parameters.AddWithValue("@P2", siparis.S_bayi_id);
            cmd.Parameters.AddWithValue("@P3", siparis.Siparis_id);
            return cmd.ExecuteNonQuery() > 0;


        }


    }
       
}

