using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double kilosPerPound = 0.4535;
            double metresPerInch = 0.0254;

            double height = double.Parse(txtHeight.Text);
            double weight = double.Parse(txtWeight.Text);

            if (rdioImp.Checked)
            {
                

                double bmi = weight * kilosPerPound / ((height * metresPerInch) * (height * metresPerInch));

                if (bmi < 16)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are very underweight :(";

                }
                else if (bmi < 23)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are bit underweight :(";
                }
                else if (bmi < 26)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are the right weight!!";
                }
                else if (bmi < 30)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are overweight :(";
                }
                else if (bmi < 35)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are really overweight :((";
                }
                else
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "Are you sure you're not dead? Death will be soon :((";
                }

            }
            else if(rdioMetric.Checked)
            {

              
                double bmi = weight / (height * height);

                if (bmi < 16)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are very underweight :(";

                }
                else if (bmi < 23)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are bit underweight :(";
                }
                else if (bmi < 26)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are the right weight!!";
                }
                else if (bmi < 30)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are overweight :(";
                }
                else if (bmi < 35)
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "You are really overweight :((";
                }
                else
                {
                    lblDisplyBmi.Text = bmi.ToString();
                    lblRemarks.Text = "Are you sure you're not dead? Death will be soon :((";
                }
            }

        }
    }
}
