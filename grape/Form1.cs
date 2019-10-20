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
                    website.Text.Substring(8);
                }
                else if (website.Text.Substring(0,12) == "www.cnn.com/")
                {

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
    }
}
