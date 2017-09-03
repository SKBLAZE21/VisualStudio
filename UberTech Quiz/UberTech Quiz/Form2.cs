using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberTech_Quiz.Properties;

namespace UberTech_Quiz
{
    public partial class Form2 : Form
    {
        int ans;
        public Form2(int a)
        {
            InitializeComponent();
            ans = a;
            label2.Text = (a).ToString();
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "12345677")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
              this.BackColor = Color.Red;                        
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Khaki;
        }
    }
}
