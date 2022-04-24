using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenesRaktar
{
    public class FormBuilder
    {
        ListViewHelper lvh = new ListViewHelper();
        private int setPosition(double value)
        {
            return (int)Math.Round(value, MidpointRounding.AwayFromZero);
        }
        public void BuildMainForm(Form form)
        {
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(1156, 686);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.Name = "Form1";
            form.Text = "Raktár";   
            form.ResumeLayout(false);

            lvh.CreateListView(form);

            Button addButton = new Button();
            addButton.Bounds = new Rectangle(new Point(setPosition(form.Width * 0.85), setPosition(form.Height * 0.015)), new Size(100, 30));
            addButton.Text = "Hozzáadás";
            addButton.Click += new System.EventHandler(addButton_Click);
            form.Controls.Add(addButton);
        }
        private void addButton_Click(Object sender, EventArgs e)
        {
            AddItemForm frm = new AddItemForm();
            frm.Show();
            MessageBox.Show("Elem sikeresen hozzáadva!", "Elem hozzáadása");
        }
        private void addItem_Click(Object sender, EventArgs e)
        {
           
        }
        private Elem CreateItemFromData(Form form)
        {
            Elem elem = new Elem(form.Controls["tb_Cikkszam"].Text,
                                 form.Controls["tb_Nev"].Text,
                                 int.Parse(form.Controls["tb_Mennyiseg"].Text),
                                 int.Parse(form.Controls["tb_NettoAr"].Text),
                                 int.Parse(form.Controls["tb_NettoOsszeg"].Text),
                                 int.Parse(form.Controls["tb_AFA"].Text),
                                 int.Parse(form.Controls["tb.Ertek"].Text),
                                 form.Controls["tb.Szamla"].Text);
            return elem;
        }
    }
}
