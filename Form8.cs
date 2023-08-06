using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            for (int i = 0; i < Form2.listTT.Count; i++)
            {
                ListViewItem item1 = new ListViewItem("");
                item1.SubItems.Add("");
                item1.SubItems.Add("");
                item1.SubItems.Add("");
                item1.SubItems[0].Text = Form2.listTT[i].subject;
                item1.SubItems[1].Text = Form2.listTT[i].professor;
                item1.SubItems[2].Text = Form2.listTT[i].location;
                listView1.Items.Add(item1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
