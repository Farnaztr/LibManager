using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarabi_149
{
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
        int count = 3, second = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox5.Text.ToLower()=="admin"&&textBox6.Text=="123")
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
                frm.panel1.Enabled = true;
                frm.panel4.Enabled = true;
                frm.label12.Text = "مدیر";
                frm.button1.Enabled = false;
            }
            else
            {
               
                if (textBox5.Text.ToLower() != "admin" || textBox6.Text != "123")
                {
                    if (textBox5.Text.ToLower() != "admin")
                    {
                        MessageBox.Show("نام کاربری اشتباه است", "هشدار");
                    }

                    if (textBox6.Text != "123")
                    {
                        MessageBox.Show("گذرواژه اشتباه است", "هشدار");
                    }

                    count--;
                    label2.Text = count.ToString();
                    if (count == 0)
                    {
                        MessageBox.Show("بیش از 3 بار تلاش کردید یک دقیقه صبر کنید", "هشدار");
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        button1.Enabled = false;
                        timer1.Start();
                     
                    }
                }
             
               
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            int r = 60 - second ;
            label4.Text = r.ToString();
            if (second==60)
            {
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                button1.Enabled = true;
                timer1.Stop();
                second = 0;
                label4.Text = "میتوانید دوباره امتحان کنید";
                count = 3;
                label2.Text = count.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox6.PasswordChar = '\0';
            }
            else
            {
                textBox6.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
