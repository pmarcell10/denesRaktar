using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenesRaktar
{
    public partial class AddItemForm : Form
    {
        System.Windows.Forms.Label lbl_Cikkszam;
        System.Windows.Forms.Label lbl_Nev;
        System.Windows.Forms.Label lbl_Mennyiseg;
        System.Windows.Forms.Label lbl_NettoAr;
        System.Windows.Forms.Label lbl_NettoOsszeg;
        System.Windows.Forms.Label lbl_Afa;
        System.Windows.Forms.Label lbl_Ertek;
        System.Windows.Forms.Label lbl_Szamla;
        System.Windows.Forms.TextBox tb_Cikkszam;
        System.Windows.Forms.TextBox tb_Nev;
        System.Windows.Forms.TextBox tb_Mennyiseg;
        System.Windows.Forms.TextBox tb_NettoAr;
        System.Windows.Forms.TextBox tb_NettoOsszeg;
        System.Windows.Forms.TextBox tb_AFA;
        System.Windows.Forms.TextBox tb_Ertek;
        System.Windows.Forms.TextBox tb_Szamla;
        System.Windows.Forms.Button button1;
        ListViewHelper lvh;
        public AddItemForm()
        {
            InitializeComponent();
            BuildForm();
        }
        private MainForm mainForm = null;
        public AddItemForm(Form parentForm)
        {
            lvh = new ListViewHelper();
            mainForm = parentForm as MainForm;
            InitializeComponent();
            BuildForm();
        }
        public void BuildForm()
        {     
            lbl_Cikkszam = new System.Windows.Forms.Label();
            lbl_Nev = new System.Windows.Forms.Label();
            lbl_Mennyiseg = new System.Windows.Forms.Label();
            lbl_NettoAr = new System.Windows.Forms.Label();
            lbl_NettoOsszeg = new System.Windows.Forms.Label();
            lbl_Afa = new System.Windows.Forms.Label();
            lbl_Ertek = new System.Windows.Forms.Label();
            lbl_Szamla = new System.Windows.Forms.Label();
            tb_Cikkszam = new System.Windows.Forms.TextBox();
            tb_Nev = new System.Windows.Forms.TextBox();
            tb_Mennyiseg = new System.Windows.Forms.TextBox();
            tb_NettoAr = new System.Windows.Forms.TextBox();
            tb_NettoOsszeg = new System.Windows.Forms.TextBox();
            tb_AFA = new System.Windows.Forms.TextBox();
            tb_Ertek = new System.Windows.Forms.TextBox();
            tb_Szamla = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            // 
            // lbl_Cikkszam
            // 
            /*lbl_Cikkszam.AutoSize = true;
            lbl_Cikkszam.Location = new System.Drawing.Point(22, 27);
            lbl_Cikkszam.Name = "lbl_Cikkszam";
            lbl_Cikkszam.Size = new System.Drawing.Size(52, 13);
            lbl_Cikkszam.TabIndex = 0;
            lbl_Cikkszam.Text = "Cikkszám";*/
            // 
            // lbl_Nev
            // 
            lbl_Nev.AutoSize = true;
            lbl_Nev.Location = new System.Drawing.Point(22, 50);
            lbl_Nev.Name = "lbl_Nev";
            lbl_Nev.Size = new System.Drawing.Size(27, 13);
            lbl_Nev.TabIndex = 1;
            lbl_Nev.Text = "Név";
            // 
            // lbl_Mennyiseg
            // 
            lbl_Mennyiseg.AutoSize = true;
            lbl_Mennyiseg.Location = new System.Drawing.Point(22, 76);
            lbl_Mennyiseg.Name = "lbl_Mennyiseg";
            lbl_Mennyiseg.Size = new System.Drawing.Size(58, 13);
            lbl_Mennyiseg.TabIndex = 2;
            lbl_Mennyiseg.Text = "Mennyiség";
            // 
            // lbl_NettoAr
            // 
            lbl_NettoAr.AutoSize = true;
            lbl_NettoAr.Location = new System.Drawing.Point(22, 102);
            lbl_NettoAr.Name = "lbl_NettoAr";
            lbl_NettoAr.Size = new System.Drawing.Size(45, 13);
            lbl_NettoAr.TabIndex = 3;
            lbl_NettoAr.Text = "Nettó ár";
            // 
            // lbl_NettoOsszeg
            // 
            lbl_NettoOsszeg.AutoSize = true;
            lbl_NettoOsszeg.Location = new System.Drawing.Point(22, 128);
            lbl_NettoOsszeg.Name = "lbl_NettoOsszeg";
            lbl_NettoOsszeg.Size = new System.Drawing.Size(69, 13);
            lbl_NettoOsszeg.TabIndex = 4;
            lbl_NettoOsszeg.Text = "Nettó összeg";
            // 
            // lbl_Afa
            // 
            lbl_Afa.AutoSize = true;
            lbl_Afa.Location = new System.Drawing.Point(22, 154);
            lbl_Afa.Name = "lbl_Afa";
            lbl_Afa.Size = new System.Drawing.Size(27, 13);
            lbl_Afa.TabIndex = 5;
            lbl_Afa.Text = "ÁFA";
            // 
            // lbl_Ertek
            // 
            lbl_Ertek.AutoSize = true;
            lbl_Ertek.Location = new System.Drawing.Point(22, 180);
            lbl_Ertek.Name = "lbl_Ertek";
            lbl_Ertek.Size = new System.Drawing.Size(32, 13);
            lbl_Ertek.TabIndex = 6;
            lbl_Ertek.Text = "Érték";
            //
            // lbl_Szamla
            //
            lbl_Szamla.AutoSize = true;
            lbl_Szamla.Location = new System.Drawing.Point(22, 206);
            lbl_Szamla.Name = "lbl_Szamla";
            lbl_Szamla.Size = new System.Drawing.Size(32, 13);
            lbl_Szamla.TabIndex = 7;
            lbl_Szamla.Text = "Számla";
            // 
            // tb_Cikkszam
            // 
            /*tb_Cikkszam.Location = new System.Drawing.Point(181, 24);
            tb_Cikkszam.Name = "tb_Cikkszam";
            tb_Cikkszam.Size = new System.Drawing.Size(100, 20);
            tb_Cikkszam.TabIndex = 7;*/
            // 
            // tb_Nev
            // 
            tb_Nev.Location = new System.Drawing.Point(181, 50);
            tb_Nev.Name = "tb_Nev";
            tb_Nev.Size = new System.Drawing.Size(100, 20);
            tb_Nev.TabIndex = 8;

            // 
            // tb_Mennyiseg
            // 
            tb_Mennyiseg.Location = new System.Drawing.Point(181, 76);
            tb_Mennyiseg.Name = "tb_Mennyiseg";
            tb_Mennyiseg.Size = new System.Drawing.Size(100, 20);
            tb_Mennyiseg.TabIndex = 9;
            // 
            // tb_NettoAr
            // 
            tb_NettoAr.Location = new System.Drawing.Point(181, 102);
            tb_NettoAr.Name = "tb_NettoAr";
            tb_NettoAr.Size = new System.Drawing.Size(100, 20);
            tb_NettoAr.TabIndex = 10;
            tb_NettoAr.Leave += new System.EventHandler(tb_NettoAr_Leave);
            // 
            // tb_NettoOsszeg
            // 
            tb_NettoOsszeg.Location = new System.Drawing.Point(181, 128);
            tb_NettoOsszeg.Name = "tb_NettoOsszeg";
            tb_NettoOsszeg.Size = new System.Drawing.Size(100, 20);
            tb_NettoOsszeg.TabIndex = 11;
            // 
            // tb_AFA
            // 
            tb_AFA.Location = new System.Drawing.Point(181, 154);
            tb_AFA.Name = "tb_AFA";
            tb_AFA.Size = new System.Drawing.Size(100, 20);
            tb_AFA.TabIndex = 12;
            tb_AFA.Text = "27";
            tb_AFA.Leave += new System.EventHandler(tb_AFA_Leave);
            // 
            // tb_Ertek
            // 
            tb_Ertek.Location = new System.Drawing.Point(181, 180);
            tb_Ertek.Name = "tb_Ertek";
            tb_Ertek.Size = new System.Drawing.Size(100, 20);
            tb_Ertek.TabIndex = 13;
            //
            // tb_Szamla
            //
            tb_Szamla.Location = new System.Drawing.Point(181, 206);
            tb_Szamla.Name = "tb_Szamla";
            tb_Szamla.Size = new System.Drawing.Size(100, 20);
            tb_Szamla.TabIndex = 14;
            tb_Szamla.Text = this.mainForm.Controls["tb_AktivSzamla"].Text;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(90, 247);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 30);
            button1.TabIndex = 15;
            button1.Text = "Hozzáadás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(btn_AddItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(button1);
            this.Controls.Add(tb_Ertek);
            this.Controls.Add(tb_AFA);
            this.Controls.Add(tb_NettoOsszeg);
            this.Controls.Add(tb_NettoAr);
            this.Controls.Add(tb_Mennyiseg);
            this.Controls.Add(tb_Nev);
            //this.Controls.Add(tb_Cikkszam);
            this.Controls.Add(tb_Szamla);
            this.Controls.Add(lbl_Ertek);
            this.Controls.Add(lbl_Afa);
            this.Controls.Add(lbl_NettoOsszeg);
            this.Controls.Add(lbl_NettoAr);
            this.Controls.Add(lbl_Mennyiseg);
            this.Controls.Add(lbl_Nev);
            //this.Controls.Add(lbl_Cikkszam);
            this.Controls.Add(lbl_Szamla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Elem hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            Elem elem = new Elem("",
                                this.Controls["tb_Nev"].Text.ToUpper(),
                                int.Parse(this.Controls["tb_Mennyiseg"].Text),
                                int.Parse(this.Controls["tb_NettoAr"].Text),
                                int.Parse(this.Controls["tb_NettoOsszeg"].Text),
                                int.Parse(this.Controls["tb_AFA"].Text),
                                int.Parse(this.Controls["tb_Ertek"].Text),
                                this.Controls["tb_Szamla"].Text);
            lvh.AddListViewItem(((ListView)this.mainForm.Controls[3]), elem);
            ClearInput();
            MessageBox.Show("Termék sikeresen hozzáadva", "Termék hozzáadása");

        }
        private void tb_NettoAr_Leave(object sender, EventArgs e)
        {
            tb_NettoOsszeg.Text = (int.Parse(tb_NettoAr.Text) * int.Parse(tb_Mennyiseg.Text)).ToString();
        }

        private void tb_AFA_Leave(object sender, EventArgs e)
        {
            tb_Ertek.Text = (int.Parse(tb_NettoOsszeg.Text) * (1 + ((double)int.Parse(tb_AFA.Text) / 100))).ToString();
        }
        private void ClearInput()
        {
            this.tb_Ertek.Text = "";
            this.tb_Cikkszam.Text = "";
            this.tb_NettoOsszeg.Text = "";
            this.tb_Mennyiseg.Text = "";
            this.tb_Nev.Text = "";
        }
    }
}
