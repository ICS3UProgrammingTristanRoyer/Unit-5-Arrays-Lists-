namespace MinValueTristanR
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
			this.Values = new System.Windows.Forms.ListBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblMinValue = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Values
			// 
			this.Values.FormattingEnabled = true;
			this.Values.Location = new System.Drawing.Point(75, 67);
			this.Values.Name = "Values";
			this.Values.Size = new System.Drawing.Size(120, 95);
			this.Values.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(99, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "button1";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblMinValue
			// 
			this.lblMinValue.AutoSize = true;
			this.lblMinValue.Location = new System.Drawing.Point(117, 204);
			this.lblMinValue.Name = "lblMinValue";
			this.lblMinValue.Size = new System.Drawing.Size(17, 13);
			this.lblMinValue.TabIndex = 2;
			this.lblMinValue.Text = "\"\"";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblMinValue);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.Values);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox Values;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblMinValue;
	}
}

