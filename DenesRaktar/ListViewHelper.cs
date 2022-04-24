using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenesRaktar
{
    public class ListViewHelper
    {
        public ListViewHelper()
        {
            listView1 = new ListView();
        }
        public static ListView listView1;
        public void CreateListView(Form form)
        {
            // Create a new ListView control.          
            listView1.Bounds = new Rectangle(new Point(10, 50), new Size((int)Math.Round(form.Width * 0.8, MidpointRounding.AwayFromZero), (int)Math.Round(form.Height * 0.85, MidpointRounding.AwayFromZero)));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = false;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("SUPER 0,1L M.OLAJ", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("30");
            item1.SubItems.Add("484");
            item1.SubItems.Add("14514");
            item1.SubItems.Add("27");
            item1.SubItems.Add("3919");
            item1.SubItems.Add("18433");
            item1.SubItems.Add("F2206850");
            ListViewItem item2 = new ListViewItem("GÁZOSÍTÓ", 1);
            item2.SubItems.Add("1");
            item2.SubItems.Add("14293");
            item2.SubItems.Add("14293");
            item2.SubItems.Add("27");
            item2.SubItems.Add("3859");
            item2.SubItems.Add("18152");
            item2.SubItems.Add("F2206850");
            ListViewItem item3 = new ListViewItem("TENGELYTÖMÍTŐ GYŰRŰ FS74-120 (E:5)", 0);
            
            item3.SubItems.Add("4");
            item3.SubItems.Add("1005");
            item3.SubItems.Add("4018");
            item3.SubItems.Add("27");
            item3.SubItems.Add("1085");
            item3.SubItems.Add("5103");
            item3.SubItems.Add("F2206850");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Név", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Mennyiség DB", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("ÁFA n. egys. ár", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("ÁFA n. összeg", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("ÁFA kulcs", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("ÁFA összeg", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Érték", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Számla", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Add the ListView to the control collection.
            form.Controls.Add(listView1);
        }
        public void AddListViewItem(ListView lista, Elem elem)
        {
            ListViewItem listViewItem = new ListViewItem(elem.nev);

            listViewItem.SubItems.Add(elem.mennyiseg.ToString());
            listViewItem.SubItems.Add(elem.egysegar.ToString());
            listViewItem.SubItems.Add(elem.osszeg.ToString());
            listViewItem.SubItems.Add(elem.afa.ToString());
            listViewItem.SubItems.Add((elem.osszeg*((double)elem.afa/100)).ToString());
            listViewItem.SubItems.Add(elem.ertek.ToString());
            listViewItem.SubItems.Add(elem.szamla.ToString());
            lista.Items.Add(listViewItem);
        }
    }
}
