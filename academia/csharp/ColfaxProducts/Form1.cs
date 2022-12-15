using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColfaxProducts
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			double sales1 = 0.0;
			double sales2 = 0.0;
			double commissionRate = 0.0;
			double commission1 = 0.0;
			double commission2 = 0.0;

			//append variables to text
			sales1 = double.Parse(sales1TextBox.Text);
			sales2 = double.Parse(sales2TextBox.Text);
			commissionRate = double.Parse(commissionRateTextBox.Text);
			//do the calculations
			commission1 = sales1 * commissionRate;
			commission2 = sales2 * commissionRate;
			displayRichTextBox.AppendText(Environment.NewLine + "State 1 Sales: "+ sales1TextBox);
			displayRichTextBox.AppendText(Environment.NewLine + "State 2 Sales: " + sales2TextBox);
			displayRichTextBox.AppendText(Environment.NewLine + "State 1 commission: "+ commission1);
			displayRichTextBox.AppendText(Environment.NewLine + "State 2 commission: "+ commission2);
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			sales1TextBox.Text = " ";
			sales2TextBox.Text = " ";
			commissionRateTextBox.Text = " ";
			displayRichTextBox.Text = "The calculations will appear here.";
		}

		private void restartButton_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
