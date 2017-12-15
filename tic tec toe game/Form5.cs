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
    public partial class Form5 : Form
    {
        bool turn = true; // true = X turn; false = Y turn   //กำหนดให้ ture เท่ากับ X จริง; เท็จ เท่ากับ Y turn
        int turn_count = 0;                      //กำหนดตัวแปรที่เรากำหนด เท่ากับ 0
        bool there_is_a_winner = false;          //กำหนดค่าคำสั่งให้ bool กำหนดตัวแปลที่เรากำหนด เท่ากับ เท็จ

        public Form5()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;           //กำหนดบัททอน b เท่ากับ บัททอน sender
            if (turn)                            
            
                b.Text = "X";                    //กำหนดบัททอน b ใส่ข้อความ เท่า "X"
  
            else
           
                b.Text = "O";                    //กำหนดบัททอน b ใส่ข้อความ เท่า "O"

            turn = !turn;                        //กำหนดให้จริง เท่ากับ ไม่จริง
            b.Enabled = true;                    //กำหนดให้บัททอน b สามารถเป็นจริงได้
            turn_count++;                        //กำหนดให้ตัวแปรที่เรากำหนด 
            checkForWinner();                    //กำหนดให้ตรวจสอบสำหรับผู้ชนะ
        }
        private void checkForWinner()
        {
            
            //Check ตามแนวนอน
            if ((k1.Text == k2.Text) && (k2.Text == k3.Text) && (k1.Text != ""))        //กำหนดให้((k1 เท่ากับ k2 ) และ (k2 เท่ากับ k3) และ (k1 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
            else if ((t1.Text == t2.Text) && (t2.Text == t3.Text) && (t1.Text != ""))   //กำหนดให้((t1 เท่ากับ t2)  และ (t2 เท่ากับ t3) และ (t1 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
            else if ((u1.Text == u2.Text) && (u2.Text == u3.Text) && (u1.Text != ""))   //กำหนดให้((u1 เท่ากับ u2)  และ (u2 เท่ากับ u3) และ (u1 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง

            //Check ตามแนวตั้ง
            else if ((k1.Text == t1.Text) && (t1.Text == u1.Text) && (k1.Text != ""))   //กำหนดให้((k1 เท่ากับ t1) และ (t1 เท่ากับ u1) และ (k1 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
            else if ((k2.Text == t2.Text) && (t2.Text == u2.Text) && (k2.Text != ""))   //กำหนดให้((k2 เท่ากับ t2) และ (t2 เท่ากับ u2) และ (k2 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
            else if ((k3.Text == t3.Text) && (t3.Text == u3.Text) && (k3.Text != ""))   //กำหนดให้((k3 เท่ากับ t3) และ (t3 เท่ากับ u3) และ (k3 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง

            //Check ตามแนวทะแยงมุม
            else if ((k1.Text == t2.Text) && (t2.Text == u3.Text) && (k1.Text != ""))   //กำหนดให้((k1 เท่ากับ t2) และ (t2 เท่ากับ u3) และ (k1 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
            else if ((k3.Text == t2.Text) && (t2.Text == u1.Text) && (k3.Text != ""))   //กำหนดให้((k3 เท่ากับ t2) และ (t2 เท่ากับ u1) และ (k3 ไม่เท่ากับ ""))
                there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
 
            if (there_is_a_winner)               //กำหนดตัวแปรที่เรากำหนด
            {
                disableButton();                 //ปิดการใช้งานบัททอน

                string winner = "";              //กำหนดให้ผู้ชนะ เท่ากับ ""
                if (turn)
                {
                    winner = "O";                //กำหนดให้ชนะ เท่ากับ O
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();  //กำหนดตัวแปรที่เรากำหนด เท่ากับตัวแปร int อ่านค่าตัวแปลที่เรากำหนด
                }
                else
                {
                    winner = "X";                //กำหนดให้ชนะ เท่ากับ O
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();  //กำหนดตัวแปรที่เรากำหนด เท่ากับตัวแปร int อ่านค่าตัวแปลที่เรากำหนด
                }
                MessageBox.Show(winner + "Wins!","Yay!");                               //กำหนดให้ MessageBox แสดงข้อความผู้ชนะ
            }//endif
        else
        {
                if (turn_count == 9)             //กำหนดให้turn_count เท่ากับ 9
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();    //กำหนดตัวแปรที่เรากำหนด เท่ากับตัวแปร int อ่านค่าตัวแปลที่เรากำหนด
                    MessageBox.Show("Draw!", "Bummer!");                                //กำหนดให้ MessageBox แสดงข้อความเสมอ
                }
        }

        }//end checkForWinner


        private void disableButton()
        {
            foreach (Control c in Controls)    //กำหนดให้ foreach ใช้งาน c ในการใช้งาน
            {
                Button b = c as Button;        //กำหนดบัททอน b เท่ากับ c as บัททอน  
                if (b != null)                 // กำหนด b ไม่เท่ากับ null
                {
                    b.Enabled = false;         //กำหนดให้บัททอน b สามารถเป็นเท็จได้
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;                           //กำหนดจริง เท่า จริง
            turn_count = 0;                        //กำหนดให้จริงนับ เท่า 0 
            disableButton();                       //ปิดการใช้งานบัททอน
            foreach (Control c in Controls)        //กำหนดให้ foreach ใช้งาน c ในการใช้งาน
            {
               Button b = c as Button;             //กำหนดบัททอน b เท่ากับ c as บัททอน
                if (b != null)                     //กำหนดบัททอน b ไม่เท่ากับ null
                {
                    b.Enabled = true;              //กำหนดให้บัททอน b ใช้งาน เท่ากับ จริง
                    b.Text = "";                   //กำหนดให้บัททอน b ใส่ข้อความ""
                }
            }
            there_is_a_winner = false;             //กำหนดตัวแปลที่เรากำหนด เท่ากับ เท็จ


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();                           //กำหนดให้ออกจากการใช้งาน
        }

        private void button_leave(object sender, EventArgs e)
        {
         
        }

        private void button_enter(object sender, DragEventArgs e)
        {
            Button b = (Button)sender;                     //กำหนดบัททอน b เท่ากับ บัททอน sender
            if (b.Enabled)                                 //กำหนดให้บัททอน b เปิดใช้งาน
            {
                if (turn)
                    b.Text = "X";                          // กำหนดบัททอน b ใส่ข้อความ เท่า "X"

                else
                    b.Text = "O";                          //กำหนดบัททอน b ใส่ข้อความ เท่า "O"

            }//end if
        }

        private void button_leave(object sender, DragEventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By kik" ," Tic Tec Toe game About");    //กำหนดให้ MessageBox แสดงข้อความ("By kik" ," Tic Tec Toe game About")
        }

        private void button1_Click_1(object sender, EventArgs e)
        {                                            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
