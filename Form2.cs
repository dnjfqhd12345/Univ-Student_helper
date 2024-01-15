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
    public partial class Form2 : Form
    {
        public static List<timeTable> listTT = new List<timeTable>();
        ListViewItem[] listArr;

        ListViewItem item1 = new ListViewItem("1교시​", 0);
        ListViewItem item2 = new ListViewItem("2교시", 1);
        ListViewItem item3 = new ListViewItem("3교시", 2);
        ListViewItem item4 = new ListViewItem("4교시", 3);
        ListViewItem item5 = new ListViewItem("5교시", 4);
        ListViewItem item6 = new ListViewItem("6교시", 5);
        ListViewItem item7 = new ListViewItem("7교시", 6);
        ListViewItem item8 = new ListViewItem("8교시", 7);
        ListViewItem item9 = new ListViewItem("9교시", 8);
        ListViewItem item10 = new ListViewItem("10교시", 9);
        ListViewItem item11 = new ListViewItem("11교시", 10);
        ListViewItem item12 = new ListViewItem("12교시", 11);


        public Form2()
        {
            InitializeComponent();

            ListViewItem[] listArr = { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12 };


            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12 });

            for(int i=0; i<listArr.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    listArr[i].SubItems.Add("");
                }
            }
            Color[] colors = {Color.Aqua, Color.LightPink, Color.LightCyan, Color.LightGoldenrodYellow, Color.MediumPurple, Color.LightGreen, Color.OrangeRed, Color.Ivory, Color.PowderBlue, Color.Sienna };

            for(int i=0; i<listTT.Count; i++)
            {
                string prof = listTT[i].professor;
                string subject = listTT[i].subject;
                Color a = colors[i];
                for(int j=0; j<listTT[i].checkArr.Length; j++)
                {
                    if(listTT[i].checkArr[j] == true)
                    {
                        int mok = j / 12;
                        int namogi = j % 12;

                        listArr[namogi].SubItems[mok + 1].BackColor = a;
                        listArr[namogi].UseItemStyleForSubItems = false;
                        listArr[namogi].SubItems[mok + 1].Text = subject;

                    }
                }
            }
            
            
        }


        public void addTimeTable(timeTable tt)
        {
            listTT.Add(tt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem[] listArr = { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12 };

            for (int i = 0; i < listArr.Length; i++)
            {

                listArr[i].SubItems.Clear();
                listArr[i].SubItems[0].Text = (i+1)+"교시";
            }

            for (int i = 0; i < listArr.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    listArr[i].SubItems.Add("");
                }
            }
            Color[] colors = {
            Color.Aqua, Color.LightPink, Color.LightCyan, Color.LightGoldenrodYellow,
            Color.MediumPurple, Color.LightGreen, Color.OrangeRed, Color.Ivory,
            Color.PowderBlue, Color.Sienna, Color.Blue, Color.Red, Color.Green,
            Color.Yellow, Color.Purple, Color.Orange, Color.Cyan, Color.Magenta,
            Color.Brown, Color.Gray
        };

            for (int i = 0; i < listTT.Count; i++)
            {
                string prof = listTT[i].professor;
                string subject = listTT[i].subject;
                Color a = colors[i];
                for (int j = 0; j < listTT[i].checkArr.Length; j++)
                {
                    if (listTT[i].checkArr[j] == true)
                    {
                        int mok = j / 12;
                        int namogi = j % 12;

                        listArr[namogi].SubItems[mok + 1].BackColor = a;
                        listArr[namogi].UseItemStyleForSubItems = false;
                        listArr[namogi].SubItems[mok + 1].Text = subject;

                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvitem = items[0];
                string a = lvitem.SubItems[1].Text;
                string b = lvitem.SubItems[1].Text;
                MessageBox.Show("선택한 행: " + a + " 그리고 " + b);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
    }
}
