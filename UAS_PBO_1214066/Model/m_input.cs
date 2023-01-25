using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO_1214066.Model
{
    internal class m_input
    {
        int nisn;
        string nama_ᮙᮠmhs, kode_prodi;
        float potongan_biaya, total_biaya;

        public m_input()
        {

        }

        public m_input(int nisn, string nama_ᮙᮠmhs, string kode_prodi, float potongan_biaya, float total_biaya)
        {
            this.Nisn = nisn;
            this.Nama_ᮙᮠmhs = nama_ᮙᮠmhs;
            this.Kode_prodi = kode_prodi;
            this.Potongan_biaya = potongan_biaya;
            this.Total_biaya = total_biaya;
        }

        public int Nisn { get => nisn; set => nisn = value; }
        public string Nama_ᮙᮠmhs { get => nama_ᮙᮠmhs; set => nama_ᮙᮠmhs = value; }
        public string Kode_prodi { get => kode_prodi; set => kode_prodi = value; }
        public float Potongan_biaya { get => potongan_biaya; set => potongan_biaya = value; }
        public float Total_biaya { get => total_biaya; set => total_biaya = value; }
    }
}
