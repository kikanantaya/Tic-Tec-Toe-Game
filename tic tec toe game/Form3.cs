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
    public partial class Form3 : Form
    {
        bool turn = true; // true = X turn; false = Y turn    //กำหนดให้ ture เท่ากับ X จริง; เท็จ เท่ากับ Y turn
        int turn_count = 0;                                   //กำหนดตัวแปรที่เรากำหนด เท่ากับ 0
        bool there_is_a_winner = false;                       //กำหนดค่าคำสั่งให้ bool กำหนดตัวแปลที่เรากำหนด เท่ากับ เท็จ
        Random r = new Random(); // ให้ r แทนคำสั่ง Random

        Timer t = new Timer();//ให้ t แทนคำสั่ง Timer

        public Form3()
        {
            InitializeComponent();
        }
        Button[] bn;
        private void Form3_Load(object sender, EventArgs e)
        {
            
            bn =new Button[] { k1, k2,k3,t1,t2,t3,u1,u2,u3}; // สร้างอาเรย์ button ชื่อ bn เป็น button ในเกม
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void bot_com()
        {
            int num = r.Next(0, bn.Length - 1);  //ทำการสุ่ม 0 -8                           
            if (bn[num].Text != "X" && bn[num].Text != "O")   // ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล              
            {
                bn[num].Text = "O";   // ให้ข้อมูล O ลงปุ่มที่ num                                      
                bn[num].Enabled = false; // ปิดการใช้งาน                           
            }
            else//กรณีไม่เข้าเงื่อนไขข้างบน
            {
                num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                {
                    bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                    bn[num].Enabled = false;// ปิดการใช้งาน 
                }
                else//กรณีไม่เข้าเงื่อนไขข้างบน
                {
                    num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                    if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                    {
                        bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                        bn[num].Enabled = false;// ปิดการใช้งาน 
                    }

                    else//กรณีไม่เข้าเงื่อนไขข้างบน
                    {
                        num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                        if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                        {
                            bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                            bn[num].Enabled = false;// ปิดการใช้งาน 
                        }
                        else//กรณีไม่เข้าเงื่อนไขข้างบน
                        {
                            num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                            if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                            {
                                bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                                bn[num].Enabled = false;
                            }
                            else//กรณีไม่เข้าเงื่อนไขข้างบน
                            {
                                num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                                if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                                {
                                    bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                                    bn[num].Enabled = false;// ปิดการใช้งาน 
                                }
                                else//กรณีไม่เข้าเงื่อนไขข้างบน
                                {
                                    num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                                    if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                                    {
                                        bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                                        bn[num].Enabled = false;// ปิดการใช้งาน 
                                    }
                                    else//กรณีไม่เข้าเงื่อนไขข้างบน
                                    {
                                        num = r.Next(0, bn.Length - 1);
                                        if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                                        {
                                            bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                                            bn[num].Enabled = false;// ปิดการใช้งาน 
                                        }
                                        else//กรณีไม่เข้าเงื่อนไขข้างบน
                                        {
                                            num = r.Next(0, bn.Length - 1);//ทำการสุ่ม 0 -8 
                                            if (bn[num].Text != "X" && bn[num].Text != "O")// ถ้าปุ่มที่ num ใน bn ยังไม่มีการกรอกข้อมูล
                                            {
                                                bn[num].Text = "O"; // ให้ข้อมูล O ลงปุ่มที่ num  
                                                bn[num].Enabled = false;// ปิดการใช้งาน 
                                            }
                                            else//กรณีไม่เข้าเงื่อนไขข้างบน
                                            {
                                                bot_com(); // เรียกใช้ฟังก์ชันนี้ใหม่อีกครั้ง
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            turn = true;
        }

        private void button_click(object sender, EventArgs e)
        {
            if (there_is_a_winner == false)                     //กำหนดตัวแปรที่เรากำหนด เท่ากับ เท็จ
            {
                Button b = (Button)sender;                      //กำหนดบัททอน b เท่ากับ บัททอน sender
                b.Text = "X";                                   //กำหนดบัททอน b ใส่ข้อความ เท่า "X"

                b.Enabled = false;                              //กำหนดให้บัททอน b สามารถเป็นเท็จได้

                turn_count++;                                   //กำหนดให้ตัวแปรที่เรากำหนด
                checkForWinner();                               //กำหนดให้ตรวจสอบสำหรับผู้ชนะ
            }
        }
        private void checkForWinner()
        {
            string t = "";
            //Check ตามแนวนอน
            if ((k1.Text == k2.Text) && (k2.Text == k3.Text) && (k1.Text != ""))      //กำหนดให้((k1 เท่ากับ k2 ) และ (k2 เท่ากับ k3) และ (k1 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = k2.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ k2
            }
            else if ((t1.Text == t2.Text) && (t2.Text == t3.Text) && (t1.Text != "")) //กำหนดให้((t1 เท่ากับ t2)  และ (t2 เท่ากับ t3) และ (t1 ไม่เท่ากับ "")
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = t1.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ t1
            }
            else if ((u1.Text == u2.Text) && (u2.Text == u3.Text) && (u1.Text != "")) //กำหนดให้((u1 เท่ากับ u2)  และ (u2 เท่ากับ u3) และ (u1 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = u2.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ u2
            }

            //Check ตามแนวตั้ง
            else if ((k1.Text == t1.Text) && (t1.Text == u1.Text) && (k1.Text != "")) //กำหนดให้((k1 เท่ากับ t1) และ (t1 เท่ากับ u1) และ (k1 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = k1.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ k1
            }
            else if ((k2.Text == t2.Text) && (t2.Text == u2.Text) && (k2.Text != "")) //กำหนดให้((k2 เท่ากับ t2) และ (t2 เท่ากับ u2) และ (k2 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = k2.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ k2
            }
            else if ((k3.Text == t3.Text) && (t3.Text == u3.Text) && (k3.Text != "")) //กำหนดให้((k3 เท่ากับ t3) และ (t3 เท่ากับ u3) และ (k3 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = k3.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ k3
            }

            //Check ตามแนวทะแยงมุม
            else if ((k1.Text == t2.Text) && (t2.Text == u3.Text) && (k1.Text != "")) //กำหนดให้((k1 เท่ากับ t2) และ (t2 เท่ากับ u3) และ (k1 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = k1.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ k1
            }
            else if ((k3.Text == t2.Text) && (t2.Text == u1.Text) && (k3.Text != "")) //กำหนดให้((k3 เท่ากับ t2) และ (t2 เท่ากับ u1) และ (k3 ไม่เท่ากับ ""))
            {
                there_is_a_winner = true;                                             //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                t = k3.Text;                                                          //กำหนดให้ตัวแปร t เท่ากับ k3
            }
            if (there_is_a_winner)
            {
                disableButton();

                string winner = t;
                MessageBox.Show(winner + "Wins!", "Yay!");                                 //กำหนดให้ MessageBox แสดงข้อความผู้ชนะ
                You_win_count.Text = (Int32.Parse(You_win_count.Text) + 1).ToString();     //กำหนดตัวแปรที่เรากำหนด เท่ากับตัวแปร int อ่านค่าตัวแปลที่เรากำหนด
            }//endif

            else//กรณีไม่เข้าเงื่อนไขข้างบน
            {
                if (turn_count == 9)
                {
                    Draw_count.Text = (Int32.Parse(Draw_count.Text) + 1).ToString();       //กำหนดตัวแปรที่เรากำหนด เท่ากับตัวแปร int อ่านค่าตัวแปลที่เรากำหนด
                    MessageBox.Show("Draw!", "Bummer!");                                   //กำหนดให้ MessageBox แสดงข้อความเสมอ
                }
                else//กรณีไม่เข้าเงื่อนไขข้างบน
                {
                    turn = !turn;
                    bot_com();

                    t = "";
                    //Check ตามแนวนอน
                    if ((k1.Text == k2.Text) && (k2.Text == k3.Text) && (k1.Text != ""))        //กำหนดให้((k1 เท่ากับ k2 ) และ (k2 เท่ากับ k3) และ (k1 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = k2.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ k2
                    }
                    else if ((t1.Text == t2.Text) && (t2.Text == t3.Text) && (t1.Text != ""))   //กำหนดให้((t1 เท่ากับ t2)  และ (t2 เท่ากับ t3) และ (t1 ไม่เท่ากับ "")
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = t1.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ t1
                    }
                    else if ((u1.Text == u2.Text) && (u2.Text == u3.Text) && (u1.Text != ""))   //กำหนดให้((u1 เท่ากับ u2)  และ (u2 เท่ากับ u3) และ (u1 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = u2.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ u2
                    }

                    //Check ตามแนวตั้ง
                    else if ((k1.Text == t1.Text) && (t1.Text == u1.Text) && (k1.Text != ""))   //กำหนดให้((k1 เท่ากับ t1) และ (t1 เท่ากับ u1) และ (k1 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = k1.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ k1
                    }
                    else if ((k2.Text == t2.Text) && (t2.Text == u2.Text) && (k2.Text != ""))   // กำหนดให้((k2 เท่ากับ t2) และ(t2 เท่ากับ u2) และ(k2 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = k2.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ k2
                    }
                    else if ((k3.Text == t3.Text) && (t3.Text == u3.Text) && (k3.Text != ""))   //กำหนดให้((k3 เท่ากับ t3) และ (t3 เท่ากับ u3) และ (k3 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = k3.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ k3
                    }

                    //Check ตามแนวทะแยงมุม
                    else if ((k1.Text == t2.Text) && (t2.Text == u3.Text) && (k1.Text != ""))   //กำหนดให้((k1 เท่ากับ t2) และ (t2 เท่ากับ u3) และ (k1 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = k1.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ k1
                    }
                    else if ((k3.Text == t2.Text) && (t2.Text == u1.Text) && (k3.Text != ""))   //กำหนดให้((k3 เท่ากับ t2) และ (t2 เท่ากับ u1) และ (k3 ไม่เท่ากับ ""))
                    {
                        there_is_a_winner = true;                                               //กำหนดตัวแปรที่เรากำหนด เท่ากับ จริง
                        t = k3.Text;                                                            //กำหนดให้ตัวแปร t เท่ากับ k3
                    }
                    if (there_is_a_winner)                                                      //กำหนดตัวแปลที่เรากำหนด เท่ากับ เท็จ
                    {
                        disableButton();                                                        //ปิดการใช้งานบัททอน

                        string winner = t;                                                    //กำหนดให้ winner เท่ากับ t
                        MessageBox.Show(winner + "Wins!", "Yay!");                            //กำหนดให้ MessageBox แสดงข้อความผู้ชนะ
                        o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();    //กำหนดตัวแปรที่เรากำหนด เท่ากับตัวแปร int อ่านค่าตัวแปลที่เรากำหนด
                    }//endif
                }
            }

        }
        //end checkForWinner

        private void disableButton()
        {
            foreach (Control c in Controls)       //กำหนดให้ foreach ใช้งาน c ในการใช้งาน
            {
                Button b = c as Button;           //กำหนดบัททอน b เท่ากับ c as บัททอน
                if (b != null)                    //กำหนดบัททอน b ไม่เท่ากับ null
                {
                    b.Enabled = false;            //กำหนดให้บัททอน b ใช้งาน เท่ากับ จริง
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;                           //กำหนดจริง เท่า จริง
            turn_count = 0;                        //กำหนดให้จริงนับ เท่า 0
            disableButton();                       //ปิดการใช้งานบัททอน
            foreach (Control c in Controls)        //กำหนดให้ foreach ใช้งาน c ในการใช้งาน
            {
                Button b = c as Button;            //กำหนดบัททอน b เท่ากับ c as บัททอน
                if (b != null)                     //กำหนดบัททอน b ไม่เท่ากับ null
                {
                    b.Enabled = true;              //กำหนดให้บัททอน b ใช้งาน เท่ากับ จริง
                    b.Text = "";                   //กำหนดให้บัททอน b ใส่ข้อความ""
                }
            }
            there_is_a_winner = false;             //กำหนดตัวแปรที่เรากำหนด เท่ากับ เท็จ

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();                    //กำหนดให้ออกจากการใช้งาน
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By kik", " Tic Tec Toe game About");   //กำหนดให้ MessageBox แสดงข้อความ("By kik" ," Tic Tec Toe game About")
        }
    }
}
