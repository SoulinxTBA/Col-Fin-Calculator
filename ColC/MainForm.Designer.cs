/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 29/11/2020
 * Time: 5:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ColC
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox sharesBox;
		private System.Windows.Forms.TextBox buyBox;
		private System.Windows.Forms.TextBox sellBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label pText;
		private System.Windows.Forms.Button comp;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pText = new System.Windows.Forms.Label();
			this.sharesBox = new System.Windows.Forms.TextBox();
			this.buyBox = new System.Windows.Forms.TextBox();
			this.sellBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.calcButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comp = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(121, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Profit";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Controls.Add(this.pText);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 135);
			this.panel1.TabIndex = 1;
			// 
			// pText
			// 
			this.pText.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pText.Location = new System.Drawing.Point(12, 51);
			this.pText.Name = "pText";
			this.pText.Size = new System.Drawing.Size(286, 72);
			this.pText.TabIndex = 1;
			this.pText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sharesBox
			// 
			this.sharesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sharesBox.Location = new System.Drawing.Point(121, 177);
			this.sharesBox.Name = "sharesBox";
			this.sharesBox.Size = new System.Drawing.Size(177, 30);
			this.sharesBox.TabIndex = 2;
			this.sharesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.sharesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SharesBoxKeyPress);
			// 
			// buyBox
			// 
			this.buyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buyBox.Location = new System.Drawing.Point(121, 216);
			this.buyBox.Name = "buyBox";
			this.buyBox.Size = new System.Drawing.Size(177, 30);
			this.buyBox.TabIndex = 3;
			this.buyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.buyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuyBoxKeyPress);
			// 
			// sellBox
			// 
			this.sellBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sellBox.Location = new System.Drawing.Point(121, 252);
			this.sellBox.Name = "sellBox";
			this.sellBox.Size = new System.Drawing.Size(177, 30);
			this.sellBox.TabIndex = 4;
			this.sellBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.sellBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SellBoxKeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Shares";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Buy";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Sell";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// calcButton
			// 
			this.calcButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.calcButton.Location = new System.Drawing.Point(186, 354);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(112, 42);
			this.calcButton.TabIndex = 8;
			this.calcButton.Text = "Computation";
			this.calcButton.UseVisualStyleBackColor = false;
			this.calcButton.Click += new System.EventHandler(this.CalcButtonClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(258, 141);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 30);
			this.button1.TabIndex = 9;
			this.button1.Text = "AC";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(12, 357);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(43, 39);
			this.button2.TabIndex = 18;
			this.button2.Text = "E";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// comp
			// 
			this.comp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.comp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.comp.Location = new System.Drawing.Point(258, 288);
			this.comp.Name = "comp";
			this.comp.Size = new System.Drawing.Size(40, 30);
			this.comp.TabIndex = 19;
			this.comp.Text = "C";
			this.comp.UseVisualStyleBackColor = false;
			this.comp.Click += new System.EventHandler(this.CompClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(310, 408);
			this.Controls.Add(this.comp);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sellBox);
			this.Controls.Add(this.buyBox);
			this.Controls.Add(this.sharesBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ColC";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
