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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();  ////กำหนดให้ฟอร์ม 5 เท่ากับ เริ่มฟอร์ม 5 
            f5.Show();               //กำหนดให้แสดงหน้าฟอร์ม 5
            this.Hide();             //คำสั่งปิดบังฟอร์มนี้
        }
    }
}
