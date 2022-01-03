using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoroloska_Stanica.StanicaKlase
{
    class Merenje
    {
        public int ID_Merenja { get; set; }
        public string DatumMerenja { get; set; }
        public int Temperatura { get; set; }
        public float Pritisak { get; set; }
        public string PravacVetra { get; set; }
        public string BrzinaVetra { get; set; }
        public int Vlaznost { get; set; }

        static string konekcija = ConfigurationManager.ConnectionStrings["BazaKonekcija"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(konekcija);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_merenja";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally{
                conn.Close();
            }
            return dt;
        }

        public bool Insert(Merenje m)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(konekcija);

            try
            {
                string sql = "INSERT INTO tbl_merenja (DatumMerenja, Temperatura, Pritisak, PravacVetra, BrzinaVetra, Vlaznost) VALUES (@DatumMerenja, @Temperatura, @Pritisak, @PravacVetra, @BrzinaVetra, @Vlaznost)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DatumMerenja", m.DatumMerenja);
                cmd.Parameters.AddWithValue("@Temperatura", m.Temperatura);
                cmd.Parameters.AddWithValue("@Pritisak", m.Pritisak);
                cmd.Parameters.AddWithValue("@PravacVetra", m.PravacVetra);
                cmd.Parameters.AddWithValue("@BrzinaVetra", m.BrzinaVetra);
                cmd.Parameters.AddWithValue("@Vlaznost", m.Vlaznost);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Update(Merenje m)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(konekcija);
            try
            {
                string sql = "UPDATE tbl_merenja SET DatumMerenja = @DatumMerenja, Temperatura = @Temperatura, Pritisak = @Pritisak, PravacVetra = @PravacVetra, BrzinaVetra = @BrzinaVetra, Vlaznost = @Vlaznost WHERE ID_Merenja = @ID_Merenja";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DatumMerenja", m.DatumMerenja);
                cmd.Parameters.AddWithValue("@Temperatura", m.Temperatura);
                cmd.Parameters.AddWithValue("@Pritisak", m.Pritisak);
                cmd.Parameters.AddWithValue("@PravacVetra", m.PravacVetra);
                cmd.Parameters.AddWithValue("@BrzinaVetra", m.BrzinaVetra);
                cmd.Parameters.AddWithValue("@Vlaznost", m.Vlaznost);
                cmd.Parameters.AddWithValue("@ID_Merenja", m.ID_Merenja);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(Merenje m)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(konekcija);
            try
            {
                string sql = "DELETE FROM tbl_merenja WHERE ID_Merenja = @ID_Merenja";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_Merenja", m.ID_Merenja);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
