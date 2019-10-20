using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grape
{
    public partial class Form1 : Form
    {
        CNNartical cn;
        public Form1()
        {
            InitializeComponent();
            cn = new CNNartical();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void websiteEnter_Click(object sender, EventArgs e)
        {
            int index = website.SelectedIndex;
            textOutput.Text = cn.ar[index].content;
            edgeDepen eD = new edgeDepen(textOutput.Text);
            List<custSent> tempList = eD.makeCustSents();
            //BingImageSearch bing = new BingImageSearch();
            //pictureBox1.Image = bing.rtnImagies("lion");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {                                                      
            foreach (var item in cn.getTitleList())
            {
                website.Items.Add(item);
            }
        }

        /*private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }*/
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        Point mouseDownPoint = Point.Empty;
        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }
        bool isMove = false;
        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDownPoint.IsEmpty)
            {
                isMove = false;
                return;
            }
            else if (e.Y < 30)
            {
                isMove = true;
            }
            if (isMove)
            {
                Form f = sender as Form;
                f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
            }
        }
        Image temp = new Bitmap("Photos/-22.png");
        Image temp3 = new Bitmap("Photos/-.png");
        Image temp2 = new Bitmap("Photos/x22.png");
        Image temp1 = new Bitmap("Photos/x2.png");
        private void LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = temp;
        }
       
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = temp3;
        }
        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = temp2;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = temp1;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
