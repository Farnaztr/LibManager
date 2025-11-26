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
    public partial class Form1 : Form
    {
        string[,] member = new string[6, 100];
        int Countm = 0;
        string[,] book = new string[7, 100];
        int countb = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "برنامه کتابخانه "+DateTime.Now.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtcode.Text = "";
            txtname1.Text = "";
            txtlast.Text = "";
            txtmeli.Text = "";
            txtphone.Text = "";
            txtaddr.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtauthor.Text = "";
            txtsub.Text = "";
            txtyear.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
         
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtcode.Text = "";
            txtname1.Text = "";
            txtlast.Text = "";
            txtmeli.Text = "";
            txtphone.Text = "";
            txtaddr.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbook.Text = "";
            txtauth.Text = "";
            txtwriter.Text = "";
            txtenteshar.Text = "";
            txtyr.Text = "";
            txtsubj.Text = "";
            txtsh.Text = "";
        }

        private void txtsh_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
                txtname.Enabled = true;
                txtauthor.Enabled = false;
                txtsub.Enabled = false;
                txtyear.Enabled = false;
                txtname.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
                txtname.Enabled = false;
                txtauthor.Enabled = true;
                txtsub.Enabled = false;
                txtyear.Enabled = false;
            txtauthor.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
                txtname.Enabled = false;
                txtauthor.Enabled = false;
                txtsub.Enabled = true;
                txtyear.Enabled = false;
            txtsub.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
                txtname.Enabled = false;
                txtauthor.Enabled = false;
                txtsub.Enabled = false;
                txtyear.Enabled = true;
            txtyear.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool f = false;

            if (txtname.Text == "" && txtauthor.Text == "" && txtsub.Text == "" && txtyear.Text == "")
            {
                MessageBox.Show("حداقل یکی از فیلد ها را پر کنید");
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("لطفا نوع جستجو را انتخاب کنید");
                return;
            }


            for (int i = 0; i < countb; i++)
            {
                if (radioButton1.Checked && txtname.Text == book[0, i])
                {
                    MessageBox.Show("نام کتاب: " + book[0, i] + "\n" + "نام مؤلف: " + book[1, i] + "\n" + "نام مترجم: " + book[2, i] + "\n" + "نام انتشارات: " + book[3, i] + "\n" + "سال چاپ: " + book[4, i] + "\n" + "موضوع: " + book[5, i] + "\n" + "شابک: " + book[6, i]);
                   f = true;
                }
                else if (radioButton2.Checked && txtauthor.Text == book[1, i])
                {
                    MessageBox.Show("نام کتاب: " + book[0, i] + "\n" + "نام مؤلف: " + book[1, i] + "\n" + "نام مترجم: " + book[2, i] + "\n" + "نام انتشارات: " + book[3, i] + "\n" + "سال چاپ: " + book[4, i] + "\n" + "موضوع: " + book[5, i] + "\n" + "شابک: " + book[6, i]);
                    f = true;
                }
                else if (radioButton3.Checked && txtsub.Text == book[5, i])
                {
                    MessageBox.Show("نام کتاب: " + book[0, i] + "\n" + "نام مؤلف: " + book[1, i] + "\n" + "نام مترجم: " + book[2, i] + "\n" + "نام انتشارات: " + book[3, i] + "\n" + "سال چاپ: " + book[4, i] + "\n" + "موضوع: " + book[5, i] + "\n" + "شابک: " + book[6, i]);
                    f = true;
                }
                else if (radioButton4.Checked && txtyear.Text == book[4, i])
                {
                    MessageBox.Show("نام کتاب: " + book[0, i] + "\n" + "نام مؤلف: " + book[1, i] + "\n" + "نام مترجم: " + book[2, i] + "\n" + "نام انتشارات: " + book[3, i] + "\n" + "سال چاپ: " + book[4, i] + "\n" + "موضوع: " + book[5, i] + "\n" + "شابک: " + book[6, i]);
                    f = true;
                }
            }

            if (f == false)
            {
                MessageBox.Show("کتاب پیدا نشد");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtbook.Text == "" || txtauth.Text == "" || txtwriter.Text == "" || txtenteshar.Text == "" || txtyr.Text == "" || txtsubj.Text == ""||txtsh.Text=="")
            {
                MessageBox.Show("همه ی فیلد ها را پر کنید");
            }
            else
            {
                book[0, countb] = txtbook.Text;
                book[1, countb] = txtauth.Text;
                book[2, countb] = txtwriter.Text;
                book[3, countb] = txtenteshar.Text;
                book[4, countb] = txtyr.Text;
                book[5, countb] = txtsubj.Text;
                book[6, countb] = txtsh.Text;
                countb++;
                MessageBox.Show("اطلاعات با موفقیت ثبت شد");


            }
        }
        
        private void savebtn_Click_1(object sender, EventArgs e)
        {
            if (txtcode.Text == "" || txtname1.Text == "" || txtlast.Text == "" || txtmeli.Text == "" || txtphone.Text == "" || txtaddr.Text == "")
            {
                MessageBox.Show("همه ی فیلد ها را پر کنید");
            }

            else
            {
                member[0, Countm] = txtcode.Text;
                member[1, Countm] = txtname1.Text;
                member[2, Countm] = txtlast.Text;
                member[3, Countm] = txtmeli.Text;
                member[4, Countm] = txtphone.Text;
                member[5, Countm] = txtaddr.Text;
                Countm++;
                MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            }
        }
    }
}