using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void centerlb(string newword)
        {
            if (outputLB.Text == "Your sentince is will go here, to get started click a button")
            {
                outputLB.Text = "";
            }
            outputLB.Text += newword;
            int heightbuffer = 50;
            int width = 300 - (outputLB.Width / 2);
            int height = 155 - (outputLB.Height / 2) + heightbuffer;
            outputLB.Location = new Point(width, height);
            outputLB.Visible = true;
        }

        private void aUBUT_Click(object sender, EventArgs e)
        {
            centerlb("A");
        }

        private void aBUT_Click(object sender, EventArgs e)
        {
            centerlb(" a");
        }

        private void anUBUT_Click(object sender, EventArgs e)
        {
            centerlb("An");
        }

        private void anBUT_Click(object sender, EventArgs e)
        {
            centerlb(" an");
        }

        private void theUBUT_Click(object sender, EventArgs e)
        {
            centerlb("The");
        }

        private void theBUT_Click(object sender, EventArgs e)
        {
            centerlb(" the");
        }

        private void manBUT_Click(object sender, EventArgs e)
        {
            centerlb(" man");
        }

        private void womanBUT_Click(object sender, EventArgs e)
        {
            centerlb(" woman");
        }

        private void dogBUT_Click(object sender, EventArgs e)
        {
            centerlb(" dog");
        }

        private void carBUT_Click(object sender, EventArgs e)
        {
            centerlb(" car");
        }

        private void catBUT_Click(object sender, EventArgs e)
        {
            centerlb(" cat");
        }

        private void bicyleBUT_Click(object sender, EventArgs e)
        {
            centerlb(" bicyle");
        }

        private void strangeBUT_Click(object sender, EventArgs e)
        {
            centerlb(" strange");
        }

        private void beautifulBUT_Click(object sender, EventArgs e)
        {
            centerlb(" beautiful");
        }

        private void bigBUT_Click(object sender, EventArgs e)
        {
            centerlb(" big");
        }

        private void smallBUT_Click(object sender, EventArgs e)
        {
            centerlb(" small");
        }

        private void lookedatBUT_Click(object sender, EventArgs e)
        {
            centerlb(" looked at");
        }

        private void rodeBUT_Click(object sender, EventArgs e)
        {
            centerlb(" rode");
        }

        private void spoketoBUT_Click(object sender, EventArgs e)
        {
            centerlb(" spoke to");
        }

        private void laughedatBUT_Click(object sender, EventArgs e)
        {
            centerlb(" laughed at");
        }

        private void droveBUT_Click(object sender, EventArgs e)
        {
            centerlb(" drove");
        }

        private void spaceBUT_Click(object sender, EventArgs e)
        {
            centerlb(" ");
        }

        private void cammaBUT_Click(object sender, EventArgs e)
        {
            centerlb(".");
        }

        private void EXBUT_Click(object sender, EventArgs e)
        {
            centerlb("!");
        }

        private void pirodBUT_Click(object sender, EventArgs e)
        {
            centerlb(",");
        }

        private void clearBUT_Click(object sender, EventArgs e)
        {
            centerlb("Your sentince is will go here, to get started click a button");
        }
    }
}
