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
    public partial class Form4 : Form
    {
        public static List<test> testList = new List<test>();

        public Form4()
        {
            InitializeComponent();
            if (testList.Count > 0)
            {
                for (int i = 0; i < testList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem("");

                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems[0].Text = testList[i].subject;
                    item1.SubItems[2].Text = testList[i].content;
                    item1.SubItems[1].Text = testList[i].deadline.ToString("yyyy-MM-dd");
                    listView1.Items.Add(item1);

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.isChanged = true;

            test test = new test();
            test.subject = textBox1.Text;
            test.content = textBox2.Text;
            test.deadline = dateTimePicker1.Value;
            ListViewItem item1 = new ListViewItem("");

        testList.Add(test);
            item1.SubItems.Add("");

            item1.SubItems.Add("");
            item1.SubItems.Add("");
            item1.SubItems[0].Text = test.subject;
            item1.SubItems[2].Text = test.content;
            item1.SubItems[1].Text = test.deadline.ToString("yyyy-MM-dd");
            testList.Sort();
            listView1.Items.Add(item1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1 || listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 요소를 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                testList.Sort();
            }
            else
            {
                Form1.isChanged = true;
                ListViewItem lvi = listView1.SelectedItems[0];
                testList.RemoveAt(lvi.Index);
                listView1.Items.Remove(lvi);
                testList.Sort();
            }

        }
    }

    [Serializable()]
    public class test : IComparable<test>
    {
        public string subject;
        public string content;
        public DateTime deadline;
        public int CompareTo(test otherTest)
        {
            return (this.deadline.CompareTo(otherTest.deadline));
        }
    }

}
