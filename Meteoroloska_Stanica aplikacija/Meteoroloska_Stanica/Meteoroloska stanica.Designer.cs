
namespace Meteoroloska_Stanica
{
    partial class Meteoroloska_stanica
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtPritisak = new System.Windows.Forms.TextBox();
            this.lblPritisak = new System.Windows.Forms.Label();
            this.txtPravac = new System.Windows.Forms.TextBox();
            this.lblPravac = new System.Windows.Forms.Label();
            this.txtBrzina = new System.Windows.Forms.TextBox();
            this.lblBrzina = new System.Windows.Forms.Label();
            this.txtVlaznost = new System.Windows.Forms.TextBox();
            this.lblVlaznost = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvListaMerenja = new System.Windows.Forms.DataGridView();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMerenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(33, 208);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(122, 20);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum merenja:";
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(170, 205);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(152, 26);
            this.txtDatum.TabIndex = 1;
            this.txtDatum.TextChanged += new System.EventHandler(this.txtDatum_TextChanged);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(170, 242);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(152, 26);
            this.txtTemperatura.TabIndex = 3;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(33, 245);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(134, 20);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "Temperatura (°C):";
            // 
            // txtPritisak
            // 
            this.txtPritisak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPritisak.Location = new System.Drawing.Point(170, 280);
            this.txtPritisak.Name = "txtPritisak";
            this.txtPritisak.Size = new System.Drawing.Size(152, 26);
            this.txtPritisak.TabIndex = 5;
            // 
            // lblPritisak
            // 
            this.lblPritisak.AutoSize = true;
            this.lblPritisak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPritisak.Location = new System.Drawing.Point(33, 283);
            this.lblPritisak.Name = "lblPritisak";
            this.lblPritisak.Size = new System.Drawing.Size(106, 20);
            this.lblPritisak.TabIndex = 4;
            this.lblPritisak.Text = "Pritisak (hPa):";
            // 
            // txtPravac
            // 
            this.txtPravac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPravac.Location = new System.Drawing.Point(170, 319);
            this.txtPravac.Name = "txtPravac";
            this.txtPravac.Size = new System.Drawing.Size(152, 26);
            this.txtPravac.TabIndex = 7;
            // 
            // lblPravac
            // 
            this.lblPravac.AutoSize = true;
            this.lblPravac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPravac.Location = new System.Drawing.Point(33, 322);
            this.lblPravac.Name = "lblPravac";
            this.lblPravac.Size = new System.Drawing.Size(100, 20);
            this.lblPravac.TabIndex = 6;
            this.lblPravac.Text = "Pravac vetra:";
            // 
            // txtBrzina
            // 
            this.txtBrzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrzina.Location = new System.Drawing.Point(170, 358);
            this.txtBrzina.Name = "txtBrzina";
            this.txtBrzina.Size = new System.Drawing.Size(152, 26);
            this.txtBrzina.TabIndex = 9;
            // 
            // lblBrzina
            // 
            this.lblBrzina.AutoSize = true;
            this.lblBrzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrzina.Location = new System.Drawing.Point(33, 361);
            this.lblBrzina.Name = "lblBrzina";
            this.lblBrzina.Size = new System.Drawing.Size(136, 20);
            this.lblBrzina.TabIndex = 8;
            this.lblBrzina.Text = "Brzina vetra (m/s):";
            // 
            // txtVlaznost
            // 
            this.txtVlaznost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlaznost.Location = new System.Drawing.Point(170, 397);
            this.txtVlaznost.Name = "txtVlaznost";
            this.txtVlaznost.Size = new System.Drawing.Size(152, 26);
            this.txtVlaznost.TabIndex = 11;
            // 
            // lblVlaznost
            // 
            this.lblVlaznost.AutoSize = true;
            this.lblVlaznost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlaznost.Location = new System.Drawing.Point(33, 400);
            this.lblVlaznost.Name = "lblVlaznost";
            this.lblVlaznost.Size = new System.Drawing.Size(103, 20);
            this.lblVlaznost.TabIndex = 10;
            this.lblVlaznost.Text = "Vlaznost (%):";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(358, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Dodaj merenje";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(633, 444);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Azuriraj merenje";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(906, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Obrisi merenje";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(96, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Ocisti polja za unos";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvListaMerenja
            // 
            this.dgvListaMerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMerenja.Location = new System.Drawing.Point(358, 93);
            this.dgvListaMerenja.Name = "dgvListaMerenja";
            this.dgvListaMerenja.Size = new System.Drawing.Size(745, 330);
            this.dgvListaMerenja.TabIndex = 16;
            this.dgvListaMerenja.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaMerenja_RowHeaderMouseClick);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretrazi.Location = new System.Drawing.Point(509, 33);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(193, 25);
            this.lblPretrazi.TabIndex = 17;
            this.lblPretrazi.Text = "Pretrazi po datumu";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(708, 33);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(226, 26);
            this.txtPretraga.TabIndex = 18;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Meteoroloska_Stanica.Properties.Resources.rhmz;
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(170, 169);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 26);
            this.txtID.TabIndex = 21;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(33, 172);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 20);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID merenja:";
            // 
            // Meteoroloska_stanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 503);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.dgvListaMerenja);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtVlaznost);
            this.Controls.Add(this.lblVlaznost);
            this.Controls.Add(this.txtBrzina);
            this.Controls.Add(this.lblBrzina);
            this.Controls.Add(this.txtPravac);
            this.Controls.Add(this.lblPravac);
            this.Controls.Add(this.txtPritisak);
            this.Controls.Add(this.lblPritisak);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblDatum);
            this.Name = "Meteoroloska_stanica";
            this.Text = "Meteoroloska Stanica";
            this.Load += new System.EventHandler(this.Meteoroloska_stanica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMerenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtPritisak;
        private System.Windows.Forms.Label lblPritisak;
        private System.Windows.Forms.TextBox txtPravac;
        private System.Windows.Forms.Label lblPravac;
        private System.Windows.Forms.TextBox txtBrzina;
        private System.Windows.Forms.Label lblBrzina;
        private System.Windows.Forms.TextBox txtVlaznost;
        private System.Windows.Forms.Label lblVlaznost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvListaMerenja;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}

