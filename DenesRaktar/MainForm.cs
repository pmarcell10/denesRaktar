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
    public partial class MainForm : Form
    {
        ListViewHelper lvh;
        public MainForm()
        {
            InitializeComponent();
            lvh = new ListViewHelper();
            lvh.CreateListView(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            AddItemForm frm = new AddItemForm(this);
            frm.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
