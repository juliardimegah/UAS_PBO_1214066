using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO_1214066.Model
{
    internal class m_prodi
    {
        string kode_prodi, nama_prodi, singkatan;
        float biaya_kuliah;
        public m_prodi()
        {

        }

        public m_prodi(string kode_prodi, string nama_prodi, string singkatan, float biaya_kuliah)
        {
            this.Kode_prodi = kode_prodi;
            this.Nama_prodi = nama_prodi;
            this.Singkatan = singkatan;
            this.Biaya_kuliah = biaya_kuliah;
        }

        public string Kode_prodi { get => kode_prodi; set => kode_prodi = value; }
        public string Nama_prodi { get => nama_prodi; set => nama_prodi = value; }
        public string Singkatan { get => singkatan; set => singkatan = value; }
        public float Biaya_kuliah { get => biaya_kuliah; set => biaya_kuliah = value; }
    }
}
