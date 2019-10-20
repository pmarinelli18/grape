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
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void website_TextChanged(object sender, EventArgs e)
        {

        }

        private void websiteEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string check = website.Text;
                if (website.Text[0] == 'h')
                {
                    check = check.Substring(8);
                }
                if (check.Substring(0,12) == "www.cnn.com/")
                {
                    timer1.Enabled = true;
                    textOutput.Text = "As US President Donald Trump hailed the agreement his administration negotiated with the Turks for northern Syria as ";
                    BingImageSearch Bing = new BingImageSearch();
                    pictureBox1.Image = Bing.rtnImagies("");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    errorMessage.Text = "At the moment we only accept CNN Articles";

                }
            }
            catch(Exception ex)
            {
                errorMessage.Text = "At the moment we only accept CNN Articles";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
