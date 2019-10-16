using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        Refrigerator refg = new Refrigerator();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (refg.MaxWeight == 0)
            {
                refg.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
                maxWeightTakeTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("MaxWeight can be set only once");
                maxWeightTakeTextBox.Text = "";
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int item = int.Parse(itemTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);
            double amount = item * weight;

            if (amount <= refg.RemainingWeight )
            {
                refg.CalculateWeight(item, weight);

                currentWeightTextBox.Text = refg.CurrentWeight.ToString();
                remainingWeightTextBox.Text = refg.RemainingWeight.ToString();
                itemTextBox.Text = "";
                weightTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Your Given Amount Cannot be Entered. It will be Overflown.");
            }
        }
    }
}
