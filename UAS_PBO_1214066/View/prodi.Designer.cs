namespace UAS_PBO_1214066
{
    partial class prodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_singkatan = new System.Windows.Forms.TextBox();
            this.tb_biaya = new System.Windows.Forms.TextBox();
            this.dataprodi = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataprodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Program Studi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Singkatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biaya Kuliah";
            // 
            // tb_kode
            // 
            this.tb_kode.Location = new System.Drawing.Point(102, 76);
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(379, 20);
            this.tb_kode.TabIndex = 5;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(102, 102);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(379, 20);
            this.tb_nama.TabIndex = 6;
            // 
            // tb_singkatan
            // 
            this.tb_singkatan.Location = new System.Drawing.Point(102, 128);
            this.tb_singkatan.Name = "tb_singkatan";
            this.tb_singkatan.Size = new System.Drawing.Size(379, 20);
            this.tb_singkatan.TabIndex = 7;
            // 
            // tb_biaya
            // 
            this.tb_biaya.Location = new System.Drawing.Point(102, 154);
            this.tb_biaya.Name = "tb_biaya";
            this.tb_biaya.Size = new System.Drawing.Size(379, 20);
            this.tb_biaya.TabIndex = 8;
            // 
            // dataprodi
            // 
            this.dataprodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataprodi.Location = new System.Drawing.Point(12, 227);
            this.dataprodi.Name = "dataprodi";
            this.dataprodi.Size = new System.Drawing.Size(469, 159);
            this.dataprodi.TabIndex = 9;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(14, 186);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(67, 27);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(195, 186);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(70, 27);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(385, 186);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 27);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 395);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataprodi);
            this.Controls.Add(this.tb_biaya);
            this.Controls.Add(this.tb_singkatan);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_kode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "prodi";
            this.Text = "Prodi";
            ((System.ComponentModel.ISupportInitialize)(this.dataprodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_kode;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_singkatan;
        private System.Windows.Forms.TextBox tb_biaya;
        private System.Windows.Forms.DataGridView dataprodi;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}