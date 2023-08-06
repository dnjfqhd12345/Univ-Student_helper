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
    [Serializable]
    public partial class Form6 : Form
    {
        public Form6()
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            label1.Text = Form2.listTT[0].getTest();
            for(int i=0; i<60; i++)
            {
                if(Form2.listTT[0].checkArr[i] == true)
                {
                    label1.Text += i+", ";
                }
            }
            label2.Text = Form2.listTT[1].getTest();
            label3.Text = Form2.listTT[2].getTest();
            label4.Text = Form2.listTT[3].getTest();
            */
            ListViewItem lvi = listView1.SelectedItems[0];
            Form2.listTT.RemoveAt(lvi.Index);
            listView1.Items.Remove(lvi);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
