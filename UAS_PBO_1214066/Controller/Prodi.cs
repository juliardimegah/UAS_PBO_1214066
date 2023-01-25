using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_PBO_1214066.Model;

namespace UAS_PBO_1214066.Controller
{
    internal class Prodi
    {
        koneksi kon = new koneksi();

        public bool Insert(m_prodi prodi)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("INSERT INTO ms_prodi(kode_prodi, nama_prodi, singkatan, biaya_kuliah) VALUES('PRD" + prodi.Kode_prodi+ "', '" + prodi.Nama_prodi + "','" + prodi.Singkatan + "','" + prodi.Biaya_kuliah + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(m_prodi prodi, string Kode_prodi)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("UPDATE prodi SET kode_prodi ='" + prodi.Kode_prodi+ "nama.prodi='" + prodi.Nama_prodi + "'," +
                "singkatan='" + prodi.Singkatan + "'," + "biaya_kuliah='" + prodi.Biaya_kuliah+ "',"
                + "'," + "WHERE kode_prodi='" + Kode_prodi + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string kode_prodi)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("DELETE FROM prodi WHERE kode_prodi= '" + kode_prodi+ "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
