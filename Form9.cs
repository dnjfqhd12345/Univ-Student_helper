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
    public partial class Form9 : Form
    {
        double creditNum = 0;
        double totalGpaSum = 0;
        double totalGpaCountForCal = 0;
        double totalGpaCounter = 0;
        double totalGpaScore = 0;
        double majorGpaSum = 0;
        double majorGpaCountForCal = 0;
        double majorGpaCounter = 0;
        double majorGpaScore = 0;
        public static Grade savedGrade = new Grade();
        public static Grade myGrade = new Grade();
        public static List<Grade> myGradeList = new List<Grade>();


        public Form9()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            TextBox[] textBoxArr = { textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8,textBox9,textBox10
                    ,textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20
                    ,textBox21,textBox22,textBox23,textBox24,textBox25,textBox26,textBox27,textBox28,textBox29,textBox30
                    ,textBox31,textBox32,textBox33,textBox34,textBox35,textBox36,textBox37,textBox38,textBox39,textBox40
                    ,textBox41,textBox42,textBox43,textBox44,textBox45,textBox46,textBox47,textBox48,textBox49,textBox50
                    ,textBox51,textBox52,textBox53,textBox54,textBox55,textBox56,textBox57,textBox58,textBox59,textBox60
                    ,textBox61,textBox62,textBox63,textBox64,textBox65,textBox66,textBox67,textBox68,textBox69,textBox70
                    ,textBox71,textBox72,textBox73,textBox74,textBox75,textBox76,textBox77,textBox78,textBox79,textBox80
                    ,textBox81,textBox82,textBox83,textBox84,textBox85,textBox86,textBox87,textBox88,textBox89,textBox90
                    ,textBox91,textBox92,textBox93,textBox94,textBox95,textBox96,textBox97,textBox98,textBox99,textBox100
                    ,textBox101,textBox102,textBox103,textBox104,textBox105,textBox106,textBox107,textBox108,textBox109,textBox110
                    ,textBox111,textBox112,textBox113,textBox114,textBox115,textBox116,textBox117,textBox118,textBox119,textBox120
            };
            /*
        NumericUpDown[] credit = {numericUpDown1,numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10
            ,numericUpDown11,numericUpDown12,numericUpDown13,numericUpDown14,numericUpDown15,numericUpDown16,numericUpDown17,numericUpDown18,numericUpDown19,numericUpDown20
            ,numericUpDown21,numericUpDown22,numericUpDown23,numericUpDown24,numericUpDown25,numericUpDown26,numericUpDown27,numericUpDown28,numericUpDown29,numericUpDown30
            ,numericUpDown31,numericUpDown32,numericUpDown33,numericUpDown34,numericUpDown35,numericUpDown36,numericUpDown37,numericUpDown38,numericUpDown39,numericUpDown40
            ,numericUpDown41,numericUpDown42,numericUpDown43,numericUpDown44,numericUpDown45,numericUpDown46,numericUpDown47,numericUpDown48,numericUpDown49,numericUpDown50
            ,numericUpDown51,numericUpDown52,numericUpDown53,numericUpDown54,numericUpDown55,numericUpDown56,numericUpDown57,numericUpDown58,numericUpDown59,numericUpDown60
            ,numericUpDown61,numericUpDown62,numericUpDown63,numericUpDown64,numericUpDown65,numericUpDown66,numericUpDown67,numericUpDown68,numericUpDown69,numericUpDown70
            ,numericUpDown71,numericUpDown72,numericUpDown73,numericUpDown74,numericUpDown75,numericUpDown76,numericUpDown77,numericUpDown78,numericUpDown79,numericUpDown80
            ,numericUpDown81,numericUpDown82,numericUpDown83,numericUpDown84,numericUpDown85,numericUpDown86,numericUpDown87,numericUpDown88,numericUpDown89,numericUpDown90
            ,numericUpDown91,numericUpDown92,numericUpDown93,numericUpDown94,numericUpDown95,numericUpDown96,numericUpDown97,numericUpDown98,numericUpDown99,numericUpDown100
            ,numericUpDown101,numericUpDown102,numericUpDown103,numericUpDown104,numericUpDown105,numericUpDown106,numericUpDown107,numericUpDown108,numericUpDown109,numericUpDown110
            ,numericUpDown111,numericUpDown112,numericUpDown113,numericUpDown114,numericUpDown115,numericUpDown116,numericUpDown117,numericUpDown118,numericUpDown119,numericUpDown120};
            */
            CheckBox[] checkArr = {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10
            ,checkBox11,checkBox12,checkBox13,checkBox14,checkBox15,checkBox16,checkBox17,checkBox18,checkBox19,checkBox20
            ,checkBox21,checkBox22,checkBox23,checkBox24,checkBox25,checkBox26,checkBox27,checkBox28,checkBox29,checkBox30
            ,checkBox31,checkBox32,checkBox33,checkBox34,checkBox35,checkBox36,checkBox37,checkBox38,checkBox39,checkBox40
            ,checkBox41,checkBox42,checkBox43,checkBox44,checkBox45,checkBox46,checkBox47,checkBox48,checkBox49,checkBox50
            ,checkBox51,checkBox52,checkBox53,checkBox54,checkBox55,checkBox56,checkBox57,checkBox58,checkBox59,checkBox60
                ,checkBox61,checkBox62,checkBox63,checkBox64,checkBox65,checkBox66,checkBox67,checkBox68,checkBox69,checkBox70,
                checkBox71,checkBox72,checkBox73,checkBox74,checkBox75
            ,checkBox76,checkBox77,checkBox78,checkBox79,checkBox80,checkBox81,checkBox82,checkBox83,checkBox84,checkBox85
            ,checkBox86,checkBox87,checkBox88,checkBox89,checkBox90,checkBox91,checkBox92,checkBox93,checkBox94,checkBox95
            ,checkBox96,checkBox97,checkBox98,checkBox99,checkBox100,checkBox101,checkBox102,checkBox103,checkBox104,checkBox105
            ,checkBox106,checkBox107,checkBox108,checkBox109,checkBox110,checkBox111,checkBox112,checkBox113,checkBox114,checkBox115
            ,checkBox116,checkBox117,checkBox118,checkBox119,checkBox120};

            NumericUpDown[] numericUpDownArr = {numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10
            ,numericUpDown11,numericUpDown12,numericUpDown13,numericUpDown14,numericUpDown15,numericUpDown16,numericUpDown17,numericUpDown18,numericUpDown19,numericUpDown20
            ,numericUpDown21,numericUpDown22,numericUpDown23,numericUpDown24,numericUpDown25,numericUpDown26,numericUpDown27,numericUpDown28,numericUpDown29,numericUpDown30
            ,numericUpDown31,numericUpDown32,numericUpDown33,numericUpDown34,numericUpDown35,numericUpDown36,numericUpDown37,numericUpDown38,numericUpDown39,numericUpDown40
            ,numericUpDown41,numericUpDown42,numericUpDown43,numericUpDown44,numericUpDown45,numericUpDown46,numericUpDown47,numericUpDown48,numericUpDown49,numericUpDown50
            ,numericUpDown51,numericUpDown52,numericUpDown53,numericUpDown54,numericUpDown55,numericUpDown56,numericUpDown57,numericUpDown58,numericUpDown59,numericUpDown60
                ,numericUpDown61,numericUpDown62,numericUpDown63,numericUpDown64,numericUpDown65,numericUpDown66,numericUpDown67,numericUpDown68,numericUpDown69,numericUpDown70,
                numericUpDown71,numericUpDown72,numericUpDown73,numericUpDown74,numericUpDown75
            ,numericUpDown76,numericUpDown77,numericUpDown78,numericUpDown79,numericUpDown80,numericUpDown81,numericUpDown82,numericUpDown83,numericUpDown84,numericUpDown85
            ,numericUpDown86,numericUpDown87,numericUpDown88,numericUpDown89,numericUpDown90,numericUpDown91,numericUpDown92,numericUpDown93,numericUpDown94,numericUpDown95
            ,numericUpDown96,numericUpDown97,numericUpDown98,numericUpDown99,numericUpDown100,numericUpDown101,numericUpDown102,numericUpDown103,numericUpDown104,numericUpDown105
            ,numericUpDown106,numericUpDown107,numericUpDown108,numericUpDown109,numericUpDown110,numericUpDown111,numericUpDown112,numericUpDown113,numericUpDown114,numericUpDown115
            ,numericUpDown116,numericUpDown117,numericUpDown118,numericUpDown119,numericUpDown120};

            ComboBox[] comboBoxArr = {comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10
            ,comboBox11,comboBox12,comboBox13,comboBox14,comboBox15,comboBox16,comboBox17,comboBox18,comboBox19,comboBox20
            ,comboBox21,comboBox22,comboBox23,comboBox24,comboBox25,comboBox26,comboBox27,comboBox28,comboBox29,comboBox30
            ,comboBox31,comboBox32,comboBox33,comboBox34,comboBox35,comboBox36,comboBox37,comboBox38,comboBox39,comboBox40
            ,comboBox41,comboBox42,comboBox43,comboBox44,comboBox45,comboBox46,comboBox47,comboBox48,comboBox49,comboBox50
            ,comboBox51,comboBox52,comboBox53,comboBox54,comboBox55,comboBox56,comboBox57,comboBox58,comboBox59,comboBox60
                ,comboBox61,comboBox62,comboBox63,comboBox64,comboBox65,comboBox66,comboBox67,comboBox68,comboBox69,comboBox70,
                comboBox71,comboBox72,comboBox73,comboBox74,comboBox75
            ,comboBox76,comboBox77,comboBox78,comboBox79,comboBox80,comboBox81,comboBox82,comboBox83,comboBox84,comboBox85
            ,comboBox86,comboBox87,comboBox88,comboBox89,comboBox90,comboBox91,comboBox92,comboBox93,comboBox94,comboBox95
            ,comboBox96,comboBox97,comboBox98,comboBox99,comboBox100,comboBox101,comboBox102,comboBox103,comboBox104,comboBox105
            ,comboBox106,comboBox107,comboBox108,comboBox109,comboBox110,comboBox111,comboBox112,comboBox113,comboBox114,comboBox115
            ,comboBox116,comboBox117,comboBox118,comboBox119,comboBox120};
            for (int i=1; i<=120; i++)
            {
                textBoxArr[i - 1].Text = savedGrade.textBoxes[i - 1];
                checkArr[i - 1].Checked = savedGrade.checkArr[i - 1];
                if (savedGrade.credit[i - 1] == null)
                {
                    numericUpDownArr[i - 1].Value = 0;
                } else
                {
                    numericUpDownArr[i - 1].Value = decimal.Parse(savedGrade.credit[i - 1]);
                }
                comboBoxArr[i - 1].Text = savedGrade.comboBoxArr[i - 1];
                creditNum = savedGrade.creditNum;
                totalGpaSum = savedGrade.totalGpaNum;
                majorGpaSum = savedGrade.majorGpaNum;
            }
            if (totalGpaSum == 0)
            {
                // 취득 학점
                label49.Text = "취득 학점: " + "0";

                // 전체 평점
                label50.Text = "전체 평점: " + "0";

                // 전공 평점
                label51.Text = "전공 평점: " + "0";

            }
            else
            {
                // 취득 학점
                label49.Text = "취득 학점: " + (creditNum).ToString();

                // 전체 평점
                label50.Text = "전체 평점: " + totalGpaSum.ToString();

                // 전공 평점
                label51.Text = "전공 평점: " + majorGpaSum.ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             creditNum = 0;
             totalGpaSum = 0;
             totalGpaCountForCal = 0;
             totalGpaCounter = 0;
             totalGpaScore = 0;
             majorGpaSum = 0;
             majorGpaCountForCal = 0;
             majorGpaCounter = 0;
             majorGpaScore = 0;
            TextBox[] textBoxArr = { textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8,textBox9,textBox10
                    ,textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20
                    ,textBox21,textBox22,textBox23,textBox24,textBox25,textBox26,textBox27,textBox28,textBox29,textBox30
                    ,textBox31,textBox32,textBox33,textBox34,textBox35,textBox36,textBox37,textBox38,textBox39,textBox40
                    ,textBox41,textBox42,textBox43,textBox44,textBox45,textBox46,textBox47,textBox48,textBox49,textBox50
                    ,textBox51,textBox52,textBox53,textBox54,textBox55,textBox56,textBox57,textBox58,textBox59,textBox60
                    ,textBox61,textBox62,textBox63,textBox64,textBox65,textBox66,textBox67,textBox68,textBox69,textBox70
                    ,textBox71,textBox72,textBox73,textBox74,textBox75,textBox76,textBox77,textBox78,textBox79,textBox80
                    ,textBox81,textBox82,textBox83,textBox84,textBox85,textBox86,textBox87,textBox88,textBox89,textBox90
                    ,textBox91,textBox92,textBox93,textBox94,textBox95,textBox96,textBox97,textBox98,textBox99,textBox100
                    ,textBox101,textBox102,textBox103,textBox104,textBox105,textBox106,textBox107,textBox108,textBox109,textBox110
                    ,textBox111,textBox112,textBox113,textBox114,textBox115,textBox116,textBox117,textBox118,textBox119,textBox120
            };
            /*
        NumericUpDown[] credit = {numericUpDown1,numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10
            ,numericUpDown11,numericUpDown12,numericUpDown13,numericUpDown14,numericUpDown15,numericUpDown16,numericUpDown17,numericUpDown18,numericUpDown19,numericUpDown20
            ,numericUpDown21,numericUpDown22,numericUpDown23,numericUpDown24,numericUpDown25,numericUpDown26,numericUpDown27,numericUpDown28,numericUpDown29,numericUpDown30
            ,numericUpDown31,numericUpDown32,numericUpDown33,numericUpDown34,numericUpDown35,numericUpDown36,numericUpDown37,numericUpDown38,numericUpDown39,numericUpDown40
            ,numericUpDown41,numericUpDown42,numericUpDown43,numericUpDown44,numericUpDown45,numericUpDown46,numericUpDown47,numericUpDown48,numericUpDown49,numericUpDown50
            ,numericUpDown51,numericUpDown52,numericUpDown53,numericUpDown54,numericUpDown55,numericUpDown56,numericUpDown57,numericUpDown58,numericUpDown59,numericUpDown60
            ,numericUpDown61,numericUpDown62,numericUpDown63,numericUpDown64,numericUpDown65,numericUpDown66,numericUpDown67,numericUpDown68,numericUpDown69,numericUpDown70
            ,numericUpDown71,numericUpDown72,numericUpDown73,numericUpDown74,numericUpDown75,numericUpDown76,numericUpDown77,numericUpDown78,numericUpDown79,numericUpDown80
            ,numericUpDown81,numericUpDown82,numericUpDown83,numericUpDown84,numericUpDown85,numericUpDown86,numericUpDown87,numericUpDown88,numericUpDown89,numericUpDown90
            ,numericUpDown91,numericUpDown92,numericUpDown93,numericUpDown94,numericUpDown95,numericUpDown96,numericUpDown97,numericUpDown98,numericUpDown99,numericUpDown100
            ,numericUpDown101,numericUpDown102,numericUpDown103,numericUpDown104,numericUpDown105,numericUpDown106,numericUpDown107,numericUpDown108,numericUpDown109,numericUpDown110
            ,numericUpDown111,numericUpDown112,numericUpDown113,numericUpDown114,numericUpDown115,numericUpDown116,numericUpDown117,numericUpDown118,numericUpDown119,numericUpDown120};
            */
            CheckBox[] checkArr = {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10
            ,checkBox11,checkBox12,checkBox13,checkBox14,checkBox15,checkBox16,checkBox17,checkBox18,checkBox19,checkBox20
            ,checkBox21,checkBox22,checkBox23,checkBox24,checkBox25,checkBox26,checkBox27,checkBox28,checkBox29,checkBox30
            ,checkBox31,checkBox32,checkBox33,checkBox34,checkBox35,checkBox36,checkBox37,checkBox38,checkBox39,checkBox40
            ,checkBox41,checkBox42,checkBox43,checkBox44,checkBox45,checkBox46,checkBox47,checkBox48,checkBox49,checkBox50
            ,checkBox51,checkBox52,checkBox53,checkBox54,checkBox55,checkBox56,checkBox57,checkBox58,checkBox59,checkBox60
                ,checkBox61,checkBox62,checkBox63,checkBox64,checkBox65,checkBox66,checkBox67,checkBox68,checkBox69,checkBox70,
                checkBox71,checkBox72,checkBox73,checkBox74,checkBox75
            ,checkBox76,checkBox77,checkBox78,checkBox79,checkBox80,checkBox81,checkBox82,checkBox83,checkBox84,checkBox85
            ,checkBox86,checkBox87,checkBox88,checkBox89,checkBox90,checkBox91,checkBox92,checkBox93,checkBox94,checkBox95
            ,checkBox96,checkBox97,checkBox98,checkBox99,checkBox100,checkBox101,checkBox102,checkBox103,checkBox104,checkBox105
            ,checkBox106,checkBox107,checkBox108,checkBox109,checkBox110,checkBox111,checkBox112,checkBox113,checkBox114,checkBox115
            ,checkBox116,checkBox117,checkBox118,checkBox119,checkBox120};

            NumericUpDown[] numericUpDownArr = {numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10
            ,numericUpDown11,numericUpDown12,numericUpDown13,numericUpDown14,numericUpDown15,numericUpDown16,numericUpDown17,numericUpDown18,numericUpDown19,numericUpDown20
            ,numericUpDown21,numericUpDown22,numericUpDown23,numericUpDown24,numericUpDown25,numericUpDown26,numericUpDown27,numericUpDown28,numericUpDown29,numericUpDown30
            ,numericUpDown31,numericUpDown32,numericUpDown33,numericUpDown34,numericUpDown35,numericUpDown36,numericUpDown37,numericUpDown38,numericUpDown39,numericUpDown40
            ,numericUpDown41,numericUpDown42,numericUpDown43,numericUpDown44,numericUpDown45,numericUpDown46,numericUpDown47,numericUpDown48,numericUpDown49,numericUpDown50
            ,numericUpDown51,numericUpDown52,numericUpDown53,numericUpDown54,numericUpDown55,numericUpDown56,numericUpDown57,numericUpDown58,numericUpDown59,numericUpDown60
                ,numericUpDown61,numericUpDown62,numericUpDown63,numericUpDown64,numericUpDown65,numericUpDown66,numericUpDown67,numericUpDown68,numericUpDown69,numericUpDown70,
                numericUpDown71,numericUpDown72,numericUpDown73,numericUpDown74,numericUpDown75
            ,numericUpDown76,numericUpDown77,numericUpDown78,numericUpDown79,numericUpDown80,numericUpDown81,numericUpDown82,numericUpDown83,numericUpDown84,numericUpDown85
            ,numericUpDown86,numericUpDown87,numericUpDown88,numericUpDown89,numericUpDown90,numericUpDown91,numericUpDown92,numericUpDown93,numericUpDown94,numericUpDown95
            ,numericUpDown96,numericUpDown97,numericUpDown98,numericUpDown99,numericUpDown100,numericUpDown101,numericUpDown102,numericUpDown103,numericUpDown104,numericUpDown105
            ,numericUpDown106,numericUpDown107,numericUpDown108,numericUpDown109,numericUpDown110,numericUpDown111,numericUpDown112,numericUpDown113,numericUpDown114,numericUpDown115
            ,numericUpDown116,numericUpDown117,numericUpDown118,numericUpDown119,numericUpDown120};

            ComboBox[] comboBoxArr = {comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10
            ,comboBox11,comboBox12,comboBox13,comboBox14,comboBox15,comboBox16,comboBox17,comboBox18,comboBox19,comboBox20
            ,comboBox21,comboBox22,comboBox23,comboBox24,comboBox25,comboBox26,comboBox27,comboBox28,comboBox29,comboBox30
            ,comboBox31,comboBox32,comboBox33,comboBox34,comboBox35,comboBox36,comboBox37,comboBox38,comboBox39,comboBox40
            ,comboBox41,comboBox42,comboBox43,comboBox44,comboBox45,comboBox46,comboBox47,comboBox48,comboBox49,comboBox50
            ,comboBox51,comboBox52,comboBox53,comboBox54,comboBox55,comboBox56,comboBox57,comboBox58,comboBox59,comboBox60
                ,comboBox61,comboBox62,comboBox63,comboBox64,comboBox65,comboBox66,comboBox67,comboBox68,comboBox69,comboBox70,
                comboBox71,comboBox72,comboBox73,comboBox74,comboBox75
            ,comboBox76,comboBox77,comboBox78,comboBox79,comboBox80,comboBox81,comboBox82,comboBox83,comboBox84,comboBox85
            ,comboBox86,comboBox87,comboBox88,comboBox89,comboBox90,comboBox91,comboBox92,comboBox93,comboBox94,comboBox95
            ,comboBox96,comboBox97,comboBox98,comboBox99,comboBox100,comboBox101,comboBox102,comboBox103,comboBox104,comboBox105
            ,comboBox106,comboBox107,comboBox108,comboBox109,comboBox110,comboBox111,comboBox112,comboBox113,comboBox114,comboBox115
            ,comboBox116,comboBox117,comboBox118,comboBox119,comboBox120};
            
            for (int i = 1; i <= 120; i++)
            {
                if (numericUpDownArr[i - 1].Value != 0)
                {
                    String GPA = comboBoxArr[i - 1].Text;
                    myGrade.textBoxes[i - 1] = textBoxArr[i - 1].Text;
                    myGrade.checkArr[i-1] = checkArr[i - 1].Checked;
                    myGrade.comboBoxArr[i - 1] = comboBoxArr[i - 1].Text;
                    myGrade.credit[i - 1] = numericUpDownArr[i - 1].Value.ToString();
                    if (checkArr[i-1].Checked)
                    {
                        // 전공 취득 학점 수
                        if (GPA.Equals("A+"))
                        {
                            majorGpaCountForCal += (double)4.5 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)4.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("A0"))
                        {
                            majorGpaCountForCal += (double)4.0 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)4.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if(GPA.Equals("B+"))
                        {
                            majorGpaCountForCal += (double)3.5 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)3.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("B0"))
                        {
                            majorGpaCountForCal += (double)3.0 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)3.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("C+"))
                        {
                            majorGpaCountForCal += (double)2.5 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)2.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("C0"))
                        {
                            majorGpaCountForCal += (double)2.0 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)2.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }

                        else if (GPA.Equals("D+"))
                        {
                            majorGpaCountForCal += (double)1.5 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)1.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("D0"))
                        {
                            majorGpaCountForCal += (double)1.0 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)1.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("F"))
                        {
                            majorGpaCountForCal += (double)0 * ((double)numericUpDownArr[i - 1].Value);
                            majorGpaSum += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCountForCal += (double)0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("NP"))
                        {
                        }
                        else if (GPA.Equals("P"))
                        {
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                        }
                    } else
                    {
                        // 전체 취득 학점 수
                        if (GPA.Equals("A+"))
                        {
                            totalGpaCountForCal += (double)4.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("A0"))
                        {
                            totalGpaCountForCal += (double)4.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("B+"))
                        {
                            totalGpaCountForCal += (double)3.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("B0"))
                        {
                            totalGpaCountForCal += (double)3.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("C+"))
                        {
                            totalGpaCountForCal += (double)2.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("C0"))
                        {
                            totalGpaCountForCal += (double)2.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }

                        else if (GPA.Equals("D+"))
                        {
                            totalGpaCountForCal += (double)1.5 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("D0"))
                        {
                            totalGpaCountForCal += (double)1.0 * ((double)numericUpDownArr[i - 1].Value);
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("F"))
                        {
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                            totalGpaSum += ((double)numericUpDownArr[i - 1].Value);
                        }
                        else if (GPA.Equals("NP"))
                        {
                        }
                        else if (GPA.Equals("P"))
                        {
                            totalGpaCounter += ((double)numericUpDownArr[i - 1].Value);
                        }
                    }
                }
            }

            // 취득 학점
            label49.Text = "취득 학점: " + (totalGpaCounter).ToString();

            // 전체 평점
            label50.Text =  "전체 평점: " + Math.Round((totalGpaCountForCal / totalGpaSum),2).ToString();

            // 전공 평점
            label51.Text = "전공 평점: " + Math.Round((majorGpaCountForCal / majorGpaSum), 2).ToString();
            myGrade.creditNum = totalGpaCounter;
            myGrade.totalGpaNum = Math.Round((totalGpaCountForCal / totalGpaSum), 2);
            myGrade.majorGpaNum = Math.Round((majorGpaCountForCal / majorGpaSum), 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savedGrade = myGrade;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox101_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox104_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    [Serializable]
    public class Grade
    {
        public double creditNum = 0;
        public double totalGpaNum = 0;
        public double majorGpaNum = 0;
        public string[] textBoxes = new string[120];
        public string[] credit = new string[120];
        public string[] comboBoxArr = new string[120];
        public bool[] checkArr = new bool[120];
    }
}
