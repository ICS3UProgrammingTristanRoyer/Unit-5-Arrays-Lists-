﻿namespace IntroToArraysTristanR
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
			this.Numbers = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblAverage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Numbers
			// 
			this.Numbers.FormattingEnabled = true;
			this.Numbers.Location = new System.Drawing.Point(74, 53);
			this.Numbers.Name = "Numbers";
			this.Numbers.Size = new System.Drawing.Size(135, 121);
			this.Numbers.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Average";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblAverage
			// 
			this.lblAverage.AutoSize = true;
			this.lblAverage.Location = new System.Drawing.Point(74, 236);
			this.lblAverage.Name = "lblAverage";
			this.lblAverage.Size = new System.Drawing.Size(50, 13);
			this.lblAverage.TabIndex = 3;
			this.lblAverage.Text = "Average:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblAverage);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Numbers);
			this.Name = "Form1";
			this.Text = "IntroToArrays";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox Numbers;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblAverage;
	}
}

