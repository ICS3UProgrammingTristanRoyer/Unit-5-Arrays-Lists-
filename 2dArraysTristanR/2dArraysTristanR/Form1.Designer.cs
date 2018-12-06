namespace _2dArraysTristanR
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
			this.btnStart = new System.Windows.Forms.Button();
			this.nudWidth = new System.Windows.Forms.NumericUpDown();
			this.nudHeight = new System.Windows.Forms.NumericUpDown();
			this.lblWidth = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblAnswer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// Numbers
			// 
			this.Numbers.FormattingEnabled = true;
			this.Numbers.Location = new System.Drawing.Point(76, 125);
			this.Numbers.Name = "Numbers";
			this.Numbers.Size = new System.Drawing.Size(120, 95);
			this.Numbers.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(93, 96);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// nudWidth
			// 
			this.nudWidth.Location = new System.Drawing.Point(152, 12);
			this.nudWidth.Name = "nudWidth";
			this.nudWidth.Size = new System.Drawing.Size(120, 20);
			this.nudWidth.TabIndex = 2;
			// 
			// nudHeight
			// 
			this.nudHeight.Location = new System.Drawing.Point(152, 38);
			this.nudHeight.Name = "nudHeight";
			this.nudHeight.Size = new System.Drawing.Size(120, 20);
			this.nudHeight.TabIndex = 3;
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(13, 18);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(38, 13);
			this.lblWidth.TabIndex = 4;
			this.lblWidth.Text = "Width:";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(12, 45);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(41, 13);
			this.lblHeight.TabIndex = 5;
			this.lblHeight.Text = "Height:";
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(15, 236);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(81, 13);
			this.lblAnswer.TabIndex = 6;
			this.lblAnswer.Text = "The average is:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.nudHeight);
			this.Controls.Add(this.nudWidth);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.Numbers);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox Numbers;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudWidth;
		private System.Windows.Forms.NumericUpDown nudHeight;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblAnswer;
	}
}

