using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            othersLabel.Visible = false;
            othersLabel.Visible = false;
            //othersLabel.MultiLine = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void survey_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //JAPAN
            String str = " ";

            if (japan.Checked == true)
            {
                str = str + japan.Text;
                str += " ";
            }
            //PHILIPPINES
            if (philippines.Checked == true)
            {
                str = str + philippines.Text;
                str += " ";
            }
            //RUSSIA
            if (russia.Checked == true)
            {
                str = str + russia.Text;
                str += " ";
            }
            //KOREA
            if (korea.Checked == true)
            {
                str = str + korea.Text;
                str += " ";
            }
            //OTHERSLABEL
            if (othersLabel.Checked == true)
            {
                str = str + othersBox.Text;
                str += " ";
            }

            if (str != null)
            {
                MessageBox.Show("You selected: \n" + str + "\nThank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void othersLabel_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            othersBox.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersBox_TextChanged(object sender, EventArgs e)
        {
            if (othersLabel.Checked)
            {
                othersBox.Visible = true;
                othersLabel.Visible = true;
            }
            else
            {
                othersBox.Visible = false;
                othersLabel.Visible = false;
            }
        }
    }
}