using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Red")
            {
                this.BackColor = System.Drawing.Color.Red;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
                checkBox4.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                button1.BackColor = Color.Red;
                
                button1.ForeColor = Color.White;

                label1.Font = new Font("Segoe UI", 10);
                label2.Font = new Font("Segoe UI", 10);
                label3.Font = new Font("Segoe UI", 10);
                label4.Font = new Font("Segoe UI", 10);
                label5.Font = new Font("Segoe UI", 10);

                checkBox1.Font = new Font("Segoe UI", 10);
                checkBox2.Font = new Font("Segoe UI", 10);
                checkBox3.Font = new Font("Segoe UI", 10);
                checkBox4.Font = new Font("Segoe UI", 10);

                radioButton1.Font = new Font("Segoe UI", 10);
                radioButton2.Font = new Font("Segoe UI", 10);

                button1.Font = new Font("Segoe UI", 10);
                button1.Font = new Font("Segoe UI", 10);
            }
            if (comboBox2.Text == "Blue")
            {
                this.BackColor = System.Drawing.Color.Blue;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
                checkBox4.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                button1.BackColor = Color.Blue;

                button1.ForeColor = Color.White;

                label1.Font = new Font("Segoe UI", 10);
                label2.Font = new Font("Segoe UI", 10);
                label3.Font = new Font("Segoe UI", 10);
                label4.Font = new Font("Segoe UI", 10);
                label5.Font = new Font("Segoe UI", 10);

                checkBox1.Font = new Font("Segoe UI", 10);
                checkBox2.Font = new Font("Segoe UI", 10);
                checkBox3.Font = new Font("Segoe UI", 10);
                checkBox4.Font = new Font("Segoe UI", 10);

                radioButton1.Font = new Font("Segoe UI", 10);
                radioButton2.Font = new Font("Segoe UI", 10);

                button1.Font = new Font("Segoe UI", 10);
                button1.Font = new Font("Segoe UI", 10);
            }
            if (comboBox2.Text == "Black")
            {

                this.BackColor = System.Drawing.Color.Black;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
                checkBox4.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;

                label1.Font = new Font("Segoe UI", 10);
                label2.Font = new Font("Segoe UI", 10);
                label3.Font = new Font("Segoe UI", 10);
                label4.Font = new Font("Segoe UI", 10);
                label5.Font = new Font("Segoe UI", 10);

                checkBox1.Font = new Font("Segoe UI", 10);
                checkBox2.Font = new Font("Segoe UI", 10);
                checkBox3.Font = new Font("Segoe UI", 10);
                checkBox4.Font = new Font("Segoe UI", 10);

                radioButton1.Font = new Font("Segoe UI", 10);
                radioButton2.Font = new Font("Segoe UI", 10);

                button1.Font = new Font("Segoe UI", 10);
                button1.Font = new Font("Segoe UI", 10);


            }
            if (comboBox2.Text == "Green")
            {
                this.BackColor = System.Drawing.Color.Green;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
                checkBox4.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;

                label1.Font = new Font("Segoe UI", 10);
                label2.Font = new Font("Segoe UI", 10);
                label3.Font = new Font("Segoe UI", 10);
                label4.Font = new Font("Segoe UI", 10);
                label5.Font = new Font("Segoe UI", 10);

                checkBox1.Font = new Font("Segoe UI", 10);
                checkBox2.Font = new Font("Segoe UI", 10);
                checkBox3.Font = new Font("Segoe UI", 10);
                checkBox4.Font = new Font("Segoe UI", 10);

                radioButton1.Font = new Font("Segoe UI", 10);
                radioButton2.Font = new Font("Segoe UI", 10);

                button1.Font = new Font("Segoe UI", 10);
                button1.Font = new Font("Segoe UI", 10);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name " + textBox1);
        }
    }
}
