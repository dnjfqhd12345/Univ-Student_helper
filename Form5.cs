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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeTable tt = new timeTable();
            int count = 0;

            CheckBox[] cBox = {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10
            ,checkBox11,checkBox12,checkBox13,checkBox14,checkBox15,checkBox16,checkBox17,checkBox18,checkBox19,checkBox20
            ,checkBox21,checkBox22,checkBox23,checkBox24,checkBox25,checkBox26,checkBox27,checkBox28,checkBox29,checkBox30
            ,checkBox31,checkBox32,checkBox33,checkBox34,checkBox35,checkBox36,checkBox37,checkBox38,checkBox39,checkBox40
            ,checkBox41,checkBox42,checkBox43,checkBox44,checkBox45,checkBox46,checkBox47,checkBox48,checkBox49,checkBox50
            ,checkBox51,checkBox52,checkBox53,checkBox54,checkBox55,checkBox56,checkBox57,checkBox58,checkBox59,checkBox60};

            for(int i=0; i<60; i++)
            {
                if (cBox[i].Checked){
                    tt.checkArr[i] = true;
                    count++;
                }
            }
            tt.subject = textBox1.Text;
            tt.professor = textBox2.Text;
            tt.location = textBox3.Text;
            Form2.listTT.Add(tt);
            if (count == 0)
            {
                MessageBox.Show("강의 시간을 선택하지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("시간표가 추가되었습니다!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control ControlTextBoxClear in this.Controls)
                {
                    if (typeof(TextBox) == ControlTextBoxClear.GetType())
                    {
                        (ControlTextBoxClear as TextBox).Text = "";
                    }
                }
                for (int i = 0; i < 60; i++)
                {
                    if (cBox[i].Checked)
                    {
                        cBox[i].Checked = false;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    public class timeTable
    {
        public string subject;
        public string professor;
        public string location;
        public bool[] checkArr = new bool[60];
    }
}
