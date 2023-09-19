using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ABeautyShop beautyShop = null;
        AHairCut hairCut;
        AStyling styling;
        AHairCare hairCare;

        void InitProducts(object sender)
        {
            if(beautyShop != null)
            {
                hairCut = beautyShop.CreateHairCut();
                styling = beautyShop.CreateStyling();
                hairCare = beautyShop.CreateHairCare();
                hairCut.listBox = listBox1;
                styling.listBox = listBox1;
                hairCare.listBox = listBox1;

                //set label to current shop
                lCurrent.Text = $"Current shop - {((Button)sender).Text}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //init all vars
            beautyShop = new barberShop();
            InitProducts(sender);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //init all vars
            beautyShop = new barberShop();
            InitProducts(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //init all vars
            beautyShop = new barberShop();
            InitProducts(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (beautyShop != null)
            {          
                if (tLenght.Text != "")
                {
                    hairCut.show();
                    hairCut.MakeService(Convert.ToInt32(tLenght.Text));
                }
                else
                    listBox1.Items.Add("Enter the value");
                }
            else
            {
                listBox1.Items.Add("Choose concrete shop!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (beautyShop != null)
            {
                if (tStyle.Text != "")
                {
                    styling.show();
                    styling.MakeService(tStyle.Text);
                }
                else
                    listBox1.Items.Add("Enter the value");
            }
            else
            {
                listBox1.Items.Add("Choose concrete shop!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (beautyShop != null)
            {
                if (tProcedure.Text != "")
                {
                    hairCare.show();
                    hairCare.MakeService(tProcedure.Text);
                }
                else
                    listBox1.Items.Add("Enter the value");
            }
            else
            {
                listBox1.Items.Add("Choose concrete shop!");
            }
        }

        private void tLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(((TextBox)sender).Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

    }
}
