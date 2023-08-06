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
    public partial class Form3 : Form
    {
        public static List<homework> homeworkList = new List<homework>();

        public Form3()
        {
            InitializeComponent();
            
            if (homeworkList.Count > 0)
            {
                for(int i=0; i<homeworkList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem("");

                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems[0].Text = homeworkList[i].subject;
                    item1.SubItems[2].Text = homeworkList[i].content;
                    item1.SubItems[1].Text = homeworkList[i].deadline.ToString("yyyy-MM-dd");
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
            homework hw1 = new homework();
            hw1.subject = textBox1.Text;
            hw1.content = textBox2.Text;
            hw1.deadline = dateTimePicker1.Value;
            homeworkList.Add(hw1);
            ListViewItem item1 = new ListViewItem("");

            item1.SubItems.Add("");
            item1.SubItems.Add("");
            item1.SubItems.Add("");
            item1.SubItems[0].Text = hw1.subject;
            item1.SubItems[2].Text = hw1.content;
            item1.SubItems[1].Text = hw1.deadline.ToString("yyyy-MM-dd");
            listView1.Items.Add(item1);
            homeworkList.Sort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1 || listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 요소를 선택해주세요.", "warn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1.isChanged = true;
                ListViewItem lvi = listView1.SelectedItems[0];
                homeworkList.RemoveAt(lvi.Index);
                listView1.Items.Remove(lvi);
                homeworkList.Sort();
            }
        }
    }

    [Serializable()]
    public class homework:IComparable<homework>
    {
        public string subject;
        public string content;
        public DateTime deadline;
        public int CompareTo(homework otherHomework)
        {
            return (this.deadline.CompareTo(otherHomework.deadline));
        }

    }
}
