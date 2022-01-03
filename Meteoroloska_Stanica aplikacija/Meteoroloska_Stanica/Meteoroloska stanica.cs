using Meteoroloska_Stanica.StanicaKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteoroloska_Stanica
{
    public partial class Meteoroloska_stanica : Form
    {
        public Meteoroloska_stanica()
        {
            InitializeComponent();
        }
        Merenje m = new Merenje();
        private void txtDatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m.DatumMerenja = txtDatum.Text;
            m.Temperatura = Convert.ToInt32(txtTemperatura.Text);
            m.Pritisak = (float)Convert.ToDouble(txtPritisak.Text);
            m.PravacVetra = txtPravac.Text;
            m.BrzinaVetra = txtBrzina.Text;
            m.Vlaznost = Convert.ToInt32(txtVlaznost.Text);

            bool success = m.Insert(m);
            if(success = true)
            {
                MessageBox.Show("Merenje je uspesno uneseno u bazu.");
                Clear();
            }
            else
            {
                MessageBox.Show("Doslo je do greske pri unosenju merenja u bazu, pokusajte ponovo.");
            }

            DataTable dt = m.Select();
            dgvListaMerenja.DataSource = dt;
        }

        private void Meteoroloska_stanica_Load(object sender, EventArgs e)
        {
            DataTable dt = m.Select();
            dgvListaMerenja.DataSource = dt;
        }

        public void Clear()
        {
            txtID.Text = "";
            txtDatum.Text = "";
            txtTemperatura.Text = "";
            txtPritisak.Text = "";
            txtPravac.Text = "";
            txtBrzina.Text = "";
            txtVlaznost.Text = "";
        }

        private void dgvListaMerenja_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvListaMerenja.Rows[rowIndex].Cells[0].Value.ToString();
            txtDatum.Text = dgvListaMerenja.Rows[rowIndex].Cells[1].Value.ToString();
            txtTemperatura.Text = dgvListaMerenja.Rows[rowIndex].Cells[2].Value.ToString();
            txtPritisak.Text = dgvListaMerenja.Rows[rowIndex].Cells[3].Value.ToString();
            txtPravac.Text = dgvListaMerenja.Rows[rowIndex].Cells[4].Value.ToString();
            txtBrzina.Text = dgvListaMerenja.Rows[rowIndex].Cells[5].Value.ToString();
            txtVlaznost.Text = dgvListaMerenja.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            m.ID_Merenja = int.Parse(txtID.Text);
            m.DatumMerenja = txtDatum.Text;
            m.Temperatura = Convert.ToInt32(txtTemperatura.Text);
            m.Pritisak = (float)Convert.ToDouble(txtPritisak.Text);
            m.PravacVetra = txtPravac.Text;
            m.BrzinaVetra = txtBrzina.Text;
            m.Vlaznost = Convert.ToInt32(txtVlaznost.Text);

            bool success = m.Update(m);
            if (success = true)
            {
                MessageBox.Show("Merenje je uspesno azurirano.");
                DataTable dt = m.Select();
                dgvListaMerenja.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Doslo je do greske pri azuriranju merenja, pokusajte ponovo.");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            m.ID_Merenja = Convert.ToInt32(txtID.Text);

            bool success = m.Delete(m);
            if (success = true)
            {
                MessageBox.Show("Merenje je uspesno obrisano iz baze.");
                DataTable dt = m.Select();
                dgvListaMerenja.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Doslo je do greske pri brisanju merenja, pokusajte ponovo.");
            }
        }
        static string povezi = ConfigurationManager.ConnectionStrings["BazaKonekcija"].ConnectionString;
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPretraga.Text;
            SqlConnection conn = new SqlConnection(povezi);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_merenja WHERE DatumMerenja like '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvListaMerenja.DataSource = dt;
        }
    }
}
