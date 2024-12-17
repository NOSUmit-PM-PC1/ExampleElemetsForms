using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleElemetsForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                listBox1.Items.Add("Выбран radioButton1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                listBox1.Items.Add("Выбран radioButton2");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            //MessageBox.Show(button.Text);
            if (button.Checked)
                listBox1.Items.Add("Выбран " + button.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countSous = 0;
            foreach (var component in groupBox2.Controls)
            {
                CheckBox box = (CheckBox) component;
                if (box.Checked)
                {
                    MessageBox.Show(box.Text);
                    countSous++;
                }
                label1.Text = countSous.ToString();
            }
        }
        string[] pictureNames = { "bigmac.png", "doublemac.jpg", "cheesburger.png" };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            pictureBox1.Load("images/" + pictureNames[comboBox1.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = textBox1.Text;
            textBox2.AppendText("\r\n" + textBox1.Text);
        }
    }
}
