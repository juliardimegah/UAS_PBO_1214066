using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_PBO_1214066.Controller;
using UAS_PBO_1214066.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UAS_PBO_1214066
{
    public partial class prodi : Form
    {
        koneksi kon = new koneksi();
        m_prodi m_prd = new m_prodi();

        public void Tampil()
        {
            //QueryDB
            dataprodi.DataSource = kon.ShowData("select * from ms_prodi");

            //Mengubah Nama Kolom Table
            dataprodi.Columns[0].HeaderText = "Kode Prodi";
            dataprodi.Columns[1].HeaderText = "Nama Prodi";
            dataprodi.Columns[2].HeaderText = "Singkatan";
            dataprodi.Columns[3].HeaderText = "Biaya Kuliah";

        }
            public prodi()
        {
            InitializeComponent();
            Tampil();
        }

        private void prodi_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_biaya.Text == "" || tb_kode.Text == "" || tb_nama.Text == "" || tb_singkatan.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Prodi prd = new Prodi();
                m_prd.Kode_prodi = tb_kode.Text;
                m_prd.Biaya_kuliah = float.Parse(tb_biaya.Text);
                m_prd.Singkatan = tb_singkatan.Text;
                m_prd.Nama_prodi = tb_nama.Text;


                prd.Insert(m_prd);

                tb_biaya.Text = "";
                tb_nama.Text = "";
                tb_singkatan.Text = "";
                tb_kode.Text = "";

                Tampil();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_biaya.Text == "" || tb_kode.Text == "" || tb_nama.Text == "" || tb_singkatan.Text == "")
                {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Prodi prd = new Prodi();
                m_prd.Kode_prodi = tb_kode.Text;
                m_prd.Biaya_kuliah = float.Parse(tb_biaya.Text);
                m_prd.Singkatan = tb_singkatan.Text;
                m_prd.Nama_prodi = tb_nama.Text;

                prd.Update(m_prd,m_prd.Kode_prodi);

                tb_biaya.Text = "";
                tb_nama.Text = "";
                tb_singkatan.Text = "";
                tb_kode.Text = "";

                Tampil();
            }
        }
    }
}
