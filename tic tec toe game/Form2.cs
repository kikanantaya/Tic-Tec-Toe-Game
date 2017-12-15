using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tec_toe_game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();  ////กำหนดให้ฟอร์ม 3 เท่ากับ เริ่มฟอร์ม 3 
            f3.Show();               //กำหนดให้แสดงหน้าฟอร์ม 3
            this.Hide();             //คำสั่งปิดบังฟอร์มนี้
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
