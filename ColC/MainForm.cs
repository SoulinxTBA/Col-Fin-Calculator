using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColC
{
	public partial class MainForm : Form
	{
		Double bgross, bnet, snet, sgross, profit, commission, scommission, vat, svat, fee, sfee, sccp, ssccp, salesTax;
		
		
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void CompClick(object sender, EventArgs e)
		{
			
			try {
				
				double amt = Convert.ToDouble(sharesBox.Text);
				double buy = Convert.ToDouble(buyBox.Text);
				double sell = Convert.ToDouble(sellBox.Text);
				//Net Buy Price
				bgross = (buy*amt);
				
				commission = (amt * buy * .0025);
				if (commission <= 19) {
					commission = 20;
				}else{
					commission = (amt * buy * .0025);
				}
				
				vat = (commission * .12);
				fee = (bgross * .00005);
				sccp = (bgross * .0001);
				bnet = bgross + commission + vat + fee + sccp;
				
				//Net Sell Price
				sgross = (amt*sell);
				
				scommission = (amt * sell *.0025);
				if (scommission <= 19) {
					scommission = 20;
				}else{
					scommission = (amt * sell *.0025);
				}
				
				svat = (scommission * .12);
				sfee = (sgross * .00005);
				ssccp = (sgross * .0001);
				salesTax = sgross * .006;
				snet = sgross - (scommission + svat + sfee + ssccp + salesTax);
				
				//profit
				profit = snet-bnet;
				
			} catch (Exception ex) {
				
				MessageBox.Show("Incomplete Data \n" + ex.Message);
			} 
			
			pText.Text = Convert.ToString(profit);
			
		}
		
		void CalcButtonClick(object sender, EventArgs e)
		{
			var form  = new Computation(commission, scommission, vat, svat, fee, sfee, sccp, ssccp, salesTax, bgross, sgross);
			form.Show();
		}

		void Button2Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		void Button1Click(object sender, EventArgs e)
		{
			sharesBox.Text = "";
			buyBox.Text = "";
			sellBox.Text = "";
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void SharesBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			var ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8) {
				e.Handled = true;
			}
		}
		void BuyBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			var ch = e.KeyChar;
			if (ch == 46 && buyBox.Text.IndexOf(".") != -1) {
				e.Handled = true;
				return;
			}
			if (!Char.IsDigit(ch) && ch != 8 && ch != 46) {
				e.Handled = true;
			}
		}
		void SellBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			var ch = e.KeyChar;
			if (ch == 46 && sellBox.Text.IndexOf(".") != -1) {
				e.Handled = true;
				return;
			}
			if (!Char.IsDigit(ch) && ch != 8 && ch != 46) {
				e.Handled = true;
			}
		}
	}
}
