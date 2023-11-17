using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRapor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNamaSiswa.Text) ||
                string.IsNullOrEmpty(tbNisn.Text) ||
                string.IsNullOrEmpty(cbJk.Text) ||
                string.IsNullOrEmpty(cbAgama.Text) ||
                string.IsNullOrEmpty(tbTtl.Text) ||
                string.IsNullOrEmpty(dtpTglLahir.Text) ||
                string.IsNullOrEmpty(tbAlamat.Text))
            {
                MessageBox.Show("Please fill informations");
            } else
            {
                dgvRapor.Rows.Add(
                    tbNisn.Text,
                    tbNamaSiswa.Text,
                    cbJk.Text,
                    cbAgama.Text,
                    tbTtl.Text+", "+dtpTglLahir.Text,
                    tbAlamat.Text,
                    "delete"
                );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> jk = new List<string>
            {
                "Laki-laki",
                "Perempuan",
            };
            List<string> agama = new List<string>
            {
                "Islam",
                "Kristen protestan",
                "Kristen katolik",
                "Buddha"
            };

            cbJk.DataSource = jk;
            cbAgama.DataSource = agama;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRapor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRapor.Columns[e.ColumnIndex].Name == "delete") 
            {
                if (dgvRapor.Rows.Count <= 1)
                {
                    MessageBox.Show("Data empty!");
                } else { 
                    dgvRapor.Rows.Remove(dgvRapor.Rows[e.RowIndex]);
                }
            }
        }
    }
}
