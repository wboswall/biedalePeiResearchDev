
namespace ColfaxProducts
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.sales1Label = new System.Windows.Forms.Label();
			this.sales2Label = new System.Windows.Forms.Label();
			this.CommissionRateLabel = new System.Windows.Forms.Label();
			this.sales1TextBox = new System.Windows.Forms.TextBox();
			this.sales2TextBox = new System.Windows.Forms.TextBox();
			this.commissionRateTextBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.restartButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.displayRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// sales1Label
			// 
			this.sales1Label.AutoSize = true;
			this.sales1Label.Location = new System.Drawing.Point(30, 52);
			this.sales1Label.Name = "sales1Label";
			this.sales1Label.Size = new System.Drawing.Size(70, 13);
			this.sales1Label.TabIndex = 0;
			this.sales1Label.Text = "Enter Sales 1";
			// 
			// sales2Label
			// 
			this.sales2Label.AutoSize = true;
			this.sales2Label.Location = new System.Drawing.Point(30, 87);
			this.sales2Label.Name = "sales2Label";
			this.sales2Label.Size = new System.Drawing.Size(70, 13);
			this.sales2Label.TabIndex = 1;
			this.sales2Label.Text = "Enter Sales 2";
			// 
			// CommissionRateLabel
			// 
			this.CommissionRateLabel.AutoSize = true;
			this.CommissionRateLabel.Location = new System.Drawing.Point(30, 117);
			this.CommissionRateLabel.Name = "CommissionRateLabel";
			this.CommissionRateLabel.Size = new System.Drawing.Size(119, 13);
			this.CommissionRateLabel.TabIndex = 2;
			this.CommissionRateLabel.Text = "Enter Commission Rate:";
			// 
			// sales1TextBox
			// 
			this.sales1TextBox.Location = new System.Drawing.Point(106, 49);
			this.sales1TextBox.Name = "sales1TextBox";
			this.sales1TextBox.Size = new System.Drawing.Size(100, 20);
			this.sales1TextBox.TabIndex = 3;
			// 
			// sales2TextBox
			// 
			this.sales2TextBox.Location = new System.Drawing.Point(106, 87);
			this.sales2TextBox.Name = "sales2TextBox";
			this.sales2TextBox.Size = new System.Drawing.Size(100, 20);
			this.sales2TextBox.TabIndex = 4;
			// 
			// commissionRateTextBox
			// 
			this.commissionRateTextBox.Location = new System.Drawing.Point(155, 117);
			this.commissionRateTextBox.Name = "commissionRateTextBox";
			this.commissionRateTextBox.Size = new System.Drawing.Size(100, 20);
			this.commissionRateTextBox.TabIndex = 5;
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(33, 162);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(83, 26);
			this.calcButton.TabIndex = 6;
			this.calcButton.Text = "&Calculate";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(143, 164);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(84, 23);
			this.clearButton.TabIndex = 7;
			this.clearButton.Text = "&Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// restartButton
			// 
			this.restartButton.Location = new System.Drawing.Point(248, 162);
			this.restartButton.Name = "restartButton";
			this.restartButton.Size = new System.Drawing.Size(105, 28);
			this.restartButton.TabIndex = 8;
			this.restartButton.Text = "&Restart";
			this.restartButton.UseVisualStyleBackColor = true;
			this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(32, 212);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(83, 23);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// displayRichTextBox
			// 
			this.displayRichTextBox.Location = new System.Drawing.Point(37, 256);
			this.displayRichTextBox.Name = "displayRichTextBox";
			this.displayRichTextBox.Size = new System.Drawing.Size(230, 118);
			this.displayRichTextBox.TabIndex = 10;
			this.displayRichTextBox.Text = "The calculations will appear here.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 417);
			this.Controls.Add(this.displayRichTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.restartButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.commissionRateTextBox);
			this.Controls.Add(this.sales2TextBox);
			this.Controls.Add(this.sales1TextBox);
			this.Controls.Add(this.CommissionRateLabel);
			this.Controls.Add(this.sales2Label);
			this.Controls.Add(this.sales1Label);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Colfax Products Inc.";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label sales1Label;
		private System.Windows.Forms.Label sales2Label;
		private System.Windows.Forms.Label CommissionRateLabel;
		private System.Windows.Forms.TextBox sales1TextBox;
		private System.Windows.Forms.TextBox sales2TextBox;
		private System.Windows.Forms.TextBox commissionRateTextBox;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button restartButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.RichTextBox displayRichTextBox;
	}
}

