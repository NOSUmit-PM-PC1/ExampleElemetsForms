using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DinamicCreateComponent
{
    public partial class FormStory : Form
    {
        public FormStory()
        {
            InitializeComponent();
        }

        private void FormStory_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/products.data");
            int i = 0;
            while (!sr.EndOfStream)
            {
                int x = 10 + i * 300; 
                string[] temp = sr.ReadLine().Split('/');
                PictureBox picture1 = new PictureBox();
                picture1.Load("data/" + temp[2]);
                picture1.Width = 200;
                picture1.Height = 200;
                picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                picture1.Click += Picture_Click;
                picture1.Location = new Point(10, x);

                Label label1 = new Label();
                label1.Text = temp[0] + " " + temp[1];
                label1.Location = new Point(10, x + 210);

                CheckBox checkBox1 = new CheckBox();
                checkBox1.Location = new Point(10, x + 250);
                checkBox1.Text = "Добавить в избранное";

                panelAllProducts.Controls.Add(label1);
                panelAllProducts.Controls.Add(checkBox1);
                panelAllProducts.Controls.Add(picture1);
                i++;
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox tempPicture = sender as PictureBox;
            pictureBoxBig.Image = tempPicture.Image;
            //MessageBox.Show("!!!");
        }
    }
}
