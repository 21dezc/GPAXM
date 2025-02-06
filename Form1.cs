using System;
using System.Windows.Forms;

namespace GPAXM
{
    public partial class Form1 : Form
    {
        private GPACalculator gpaCalculator = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            double gpa;
            if (double.TryParse(tbinputGPA.Text, out gpa))
            {
                bool result = gpaCalculator.SetGPA(gpa);
                if (result)
                {
                    UpdateGPAInfo();
                    tbinputGPA.Clear();
                    tbinputGPA.Focus();
                }
                else
                {
                    MessageBox.Show("GPA ���١��ͧ ��س������㹪�ǧ 0 �֧ 4");
                }
            }
            else
            {
                MessageBox.Show("��س���� GPA ���١��ͧ");
            }
        }

        private void UpdateGPAInfo()
        {
            // ��ҧ��ҷ������ ListBox ��͹��������������
            lbGPAList.Items.Clear();

            // �֧������ GPA �������ҡ GPACalculator ��������ŧ ListBox
            foreach (double gpa in gpaCalculator.GetGPAList())
            {
                lbGPAList.Items.Add(gpa.ToString("F2"));
            }

            // �ѻവ��� GPA �����, �٧�ش ��е���ش
            tbGPAX.Text = gpaCalculator.GetGPAx().ToString("F2");
            tbGPAMax.Text = gpaCalculator.GetMaxGPA().ToString("F2");
            tbGPAMin.Text = gpaCalculator.GetMinGPA().ToString("F2");
        }

        private void btReset_Click(object sender, EventArgs e)
        {

            // ���絤�ҵ�ҧ � �繤����ҧ
            lbGPAList.Items.Clear();  // ��ҧ������� ListBox
            tbinputGPA.Clear();        // ��ҧ TextBox ����Ѻ��á�͡ GPA
            tbGPAX.Clear();            // ��ҧ��� GPA �����
            tbGPAMax.Clear();          // ��ҧ��� GPA �٧�ش
            tbGPAMin.Clear();          // ��ҧ��� GPA ����ش       
        }
    }
}