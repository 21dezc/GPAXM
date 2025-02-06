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
                    MessageBox.Show("GPA ไม่ถูกต้อง กรุณาใส่ค่าในช่วง 0 ถึง 4");
                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่ GPA ที่ถูกต้อง");
            }
        }

        private void UpdateGPAInfo()
        {
            // ล้างค่าทั้งหมดใน ListBox ก่อนเพิ่มข้อมูลใหม่
            lbGPAList.Items.Clear();

            // ดึงข้อมูล GPA ทั้งหมดจาก GPACalculator แล้วเพิ่มลง ListBox
            foreach (double gpa in gpaCalculator.GetGPAList())
            {
                lbGPAList.Items.Add(gpa.ToString("F2"));
            }

            // อัปเดตค่า GPA เฉลี่ย, สูงสุด และต่ำสุด
            tbGPAX.Text = gpaCalculator.GetGPAx().ToString("F2");
            tbGPAMax.Text = gpaCalculator.GetMaxGPA().ToString("F2");
            tbGPAMin.Text = gpaCalculator.GetMinGPA().ToString("F2");
        }

        private void btReset_Click(object sender, EventArgs e)
        {

            // รีเซ็ตค่าต่าง ๆ เป็นค่าว่าง
            lbGPAList.Items.Clear();  // ล้างข้อมูลใน ListBox
            tbinputGPA.Clear();        // ล้าง TextBox สำหรับการกรอก GPA
            tbGPAX.Clear();            // ล้างค่า GPA เฉลี่ย
            tbGPAMax.Clear();          // ล้างค่า GPA สูงสุด
            tbGPAMin.Clear();          // ล้างค่า GPA ต่ำสุด       
        }
    }
}