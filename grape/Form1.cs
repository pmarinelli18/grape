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
    }
}
