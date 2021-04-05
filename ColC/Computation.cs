using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColC
{
	public partial class Computation : Form
	{
		public Computation(double commision, double scommission, double vat, double svat, double fee, double sfee, double sccp, double ssccp, double salesTax, double bgross, double sgross)
		{
			InitializeComponent();
			
			double bCharges = commision + vat + fee + sccp;
			double sCharges = scommission + svat + sfee + ssccp + salesTax;
			double bnet = bgross + bCharges;
			double snet = sgross - sCharges;
			
			
			bCom.Text = Convert.ToString(commision);
			bVat.Text = Convert.ToString(vat);
			bFee.Text = Convert.ToString(fee);
			bSC.Text = Convert.ToString(sccp);
			bGA.Text = Convert.ToString(bgross);
			
			sCom.Text = Convert.ToString(scommission);
			sVat.Text = Convert.ToString(svat);
			sFee.Text = Convert.ToString(sfee);
			sSC.Text = Convert.ToString(ssccp);
			sST.Text = Convert.ToString(salesTax);
			sGA.Text = Convert.ToString(sgross);
			
			bTC.Text = Convert.ToString(bCharges);
			sTC.Text = Convert.ToString(sCharges);
			
			bNA.Text = Convert.ToString(bnet);
			sNA.Text = Convert.ToString(snet);
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
	}
}
