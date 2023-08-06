using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Microsoft.Win32;


namespace WindowsFormsApp2
{
    [Serializable]
    public partial class Form1 : Form
    {
        public static bool isChanged = false;
        public Form1()
        {
            InitializeComponent();

            bool fileExist1 = File.Exists(Application.StartupPath + @"\\listTT.dat");
            bool fileExist2 = File.Exists(Application.StartupPath + @"\\homeworkList.dat");
            bool fileExist3 = File.Exists(Application.StartupPath + @"\\testList.dat");
            if (fileExist1)
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\\listTT.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Form2.listTT = (List<timeTable>)formatter.Deserialize(fs);
                fs.Close();
            }
            if (fileExist2)
            {
                FileStream fs2 = new FileStream(Application.StartupPath + @"\\homeworkList.dat", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();
                Form3.homeworkList = (List<homework>)formatter2.Deserialize(fs2);
                fs2.Close();
            }
            if (fileExist3)
            {
                FileStream fs3 = new FileStream(Application.StartupPath + @"\\testList.dat", FileMode.Open);
                BinaryFormatter formatter3 = new BinaryFormatter();
                Form4.testList = (List<test>)formatter3.Deserialize(fs3);
                fs3.Close();
            }

            DateTime today = DateTime.Now;

            if (Form3.homeworkList.Count > 0)
            {
                for (int i = 0; i < Form3.homeworkList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem("");
                    TimeSpan t1 = Form3.homeworkList[i].deadline - today;
                    if (t1.Days < 0)
                    {
                        continue;
                    }
                    if (t1.Days == 4)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 3)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 2)
                    {
                        item1.BackColor = Color.IndianRed;
                    }
                    else if (t1.Days < 2)
                    {
                        item1.BackColor = Color.DarkRed;
                        item1.ForeColor = Color.White;
                    }
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems[0].Text = Form3.homeworkList[i].subject;
                    item1.SubItems[1].Text = t1.ToString("'D-'d");
                    item1.SubItems[2].Text = "과제";
                    item1.SubItems[3].Text = Form3.homeworkList[i].content;
                    listView1.Items.Add(item1);
                    
                }
            }

            if (Form4.testList.Count > 0)
            {
                for (int i = 0; i < Form4.testList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem("");
                    TimeSpan t1 = Form4.testList[i].deadline - today;
                    if (t1.Days < 0)
                    {
                        continue;
                    }
                    if (t1.Days == 4)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 3)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 2)
                    {
                        item1.BackColor = Color.IndianRed;
                    }
                    else if (t1.Days < 2)
                    {
                        item1.BackColor = Color.DarkRed;
                        item1.ForeColor = Color.White;
                    }
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems[0].Text = Form4.testList[i].subject;
                    item1.SubItems[1].Text = t1.ToString("'D-'d");
                    item1.SubItems[2].Text = "시험";
                    item1.SubItems[3].Text = Form4.testList[i].content;
                    listView2.Items.Add(item1);

                }
            }




        }

        private void Form1_Shown()
        {
            string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey);
            if (strUpKey.GetValue("StartupTimeTable") == null)
            {
                label5.Text = "OFF";
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.Text = "ON";
                label5.ForeColor = Color.Blue;
            }

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중입니다!","info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void updateData()
        {
            DateTime today = DateTime.Now;

            if (Form3.homeworkList.Count > 0)
            {
                for (int i = 0; i < Form3.homeworkList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem("");
                    TimeSpan t1 = Form3.homeworkList[i].deadline.Subtract(today);
                    if (t1.Days < 0)
                    {
                        continue;
                    }
                    if (t1.Days == 4)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 3)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 2)
                    {
                        item1.BackColor = Color.IndianRed;
                    }
                    else if (t1.Days < 2)
                    {
                        item1.BackColor = Color.DarkRed;
                    }

                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems[0].Text = Form3.homeworkList[i].subject;
                    item1.SubItems[1].Text = t1.ToString("'D-'dd");
                    item1.SubItems[2].Text = "과제";
                    item1.SubItems[3].Text = Form3.homeworkList[i].content;
                    listView1.Items.Add(item1);

                }
            }

            if (Form4.testList.Count > 0)
            {
                for (int i = 0; i < Form4.testList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem("");
                    TimeSpan t1 = Form4.testList[i].deadline.Subtract(today);
                    if (t1.Days < 0)
                    {
                        continue;
                    }
                    if (t1.Days == 4)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 3)
                    {
                        item1.BackColor = Color.PaleVioletRed;
                    }
                    else if (t1.Days == 2)
                    {
                        item1.BackColor = Color.IndianRed;
                    }
                    else if (t1.Days < 2)
                    {
                        item1.BackColor = Color.DarkRed;
                    }

                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems[0].Text = Form4.testList[i].subject;
                    item1.SubItems[1].Text = t1.ToString("'D-'dd");
                    item1.SubItems[2].Text = "시험";
                    item1.SubItems[3].Text = Form4.testList[i].content;
                    listView2.Items.Add(item1);

                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램 제작자: 전남대 컴공 전산쟁이 \n프로그램 버전: ver 1.0 \n프로그램 업데이트 소식은 https://blog.naver.com/zzzz7037 \n에서 확인하실 수 있습니다.", "프로그램 제작자", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isChanged == true)
            {
                listView1.Items.Clear();
                listView2.Items.Clear();

                DateTime today = DateTime.Now;

                if (Form3.homeworkList.Count > 0)
                {
                    for (int i = 0; i < Form3.homeworkList.Count; i++)
                    {
                        ListViewItem item1 = new ListViewItem("");
                        TimeSpan t1 = Form3.homeworkList[i].deadline.Subtract(today);
                        if (t1.Days < 0)
                        {
                            continue;
                        }
                        if (t1.Days == 4)
                        {
                            item1.BackColor = Color.PaleVioletRed;
                        }
                        else if (t1.Days == 3)
                        {
                            item1.BackColor = Color.PaleVioletRed;
                        }
                        else if (t1.Days == 2)
                        {
                            item1.BackColor = Color.IndianRed;
                        }
                        else if (t1.Days < 2)
                        {
                            item1.BackColor = Color.DarkRed;
                            item1.ForeColor = Color.White;
                        }
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems[0].Text = Form3.homeworkList[i].subject;
                        item1.SubItems[1].Text = t1.ToString("'D-'d");
                        item1.SubItems[2].Text = "과제";
                        item1.SubItems[3].Text = Form3.homeworkList[i].content;
                        listView1.Items.Add(item1);

                    }
                }

                if (Form4.testList.Count > 0)
                {
                    for (int i = 0; i < Form4.testList.Count; i++)
                    {
                        ListViewItem item1 = new ListViewItem("");
                        TimeSpan t1 = Form4.testList[i].deadline.Subtract(today);
                        if (t1.Days < 0)
                        {
                            continue;
                        }
                        if (t1.Days == 4)
                        {
                            item1.BackColor = Color.PaleVioletRed;
                        }
                        else if (t1.Days == 3)
                        {
                            item1.BackColor = Color.PaleVioletRed;
                        }
                        else if (t1.Days == 2)
                        {
                            item1.BackColor = Color.IndianRed;
                        }
                        else if (t1.Days < 2)
                        {
                            item1.BackColor = Color.DarkRed;
                            item1.ForeColor = Color.White;
                        }
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems[0].Text = Form4.testList[i].subject;
                        item1.SubItems[1].Text = t1.ToString("'D-'d");
                        item1.SubItems[2].Text = "시험";
                        item1.SubItems[3].Text = Form4.testList[i].content;
                        listView2.Items.Add(item1);

                    }
                }
                MessageBox.Show("일정 업데이트가 완료되었습니다.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isChanged = false;
            } else
            {
                MessageBox.Show("일정 추가/삭제 후 업데이트가 가능합니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs1;
                FileStream fs2;
                FileStream fs3;


                fs1 = new FileStream(Application.StartupPath + @"\\listTT.dat", FileMode.Create);
                fs2 = new FileStream(Application.StartupPath + @"\\homeworkList.dat", FileMode.Create);
                fs3 = new FileStream(Application.StartupPath + @"\\testList.dat", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs1, Form2.listTT);
                formatter.Serialize(fs2, Form3.homeworkList);
                formatter.Serialize(fs3, Form4.testList);
                fs1.Close();
                fs2.Close();
                fs3.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("저장에 실패하였습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(a.Message);
            }
                MessageBox.Show("저장에 성공하였습니다.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                // 시작프로그램 등록하는 레지스트리
                string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey);
                if (strUpKey.GetValue("StartupTimeTable") == null)
                {
                    strUpKey.Close();
                    strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                    // 시작프로그램 등록명과 exe경로를 레지스트리에 등록
                    strUpKey.SetValue("StartupTimeTable", Application.ExecutablePath);
                }
                MessageBox.Show("시작프로그램 등록에 성공하였습니다.","info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Text = "ON";
                label5.ForeColor = Color.Blue;
            }
            catch(Exception z)
            {
                MessageBox.Show("시작프로그램 등록에 실패하였습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label5.Text = "OFF";
                label5.ForeColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                // 레지스트리값 제거
                strUpKey.DeleteValue("StartupTimeTable");
                MessageBox.Show("시작프로그램 제거에 성공하였습니다.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Text = "OFF";
                label5.ForeColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("시작프로그램 제거에 실패하였습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1_Shown();
        }
    }

}
