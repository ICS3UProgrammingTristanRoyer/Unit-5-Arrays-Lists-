namespace ListAverageTristanR
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.Numbers = new System.Windows.Forms.ListBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.txtMark = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter a mark  between 0 and 100:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(205, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(77, 20);
			this.textBox1.TabIndex = 1;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(205, 33);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 23);
			this.btnEnter.TabIndex = 2;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// Numbers
			// 
			this.Numbers.FormattingEnabled = true;
			this.Numbers.Location = new System.Drawing.Point(81, 74);
			this.Numbers.Name = "Numbers";
			this.Numbers.Size = new System.Drawing.Size(120, 95);
			this.Numbers.TabIndex = 3;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(81, 175);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(120, 23);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "Calculate average";
			this.btnCalculate.UseVisualStyleBackColor = true;
			// 
			// txtMark
			// 
			this.txtMark.AutoSize = true;
			this.txtMark.Location = new System.Drawing.Point(124, 229);
			this.txtMark.Name = "txtMark";
			this.txtMark.Size = new System.Drawing.Size(13, 13);
			this.txtMark.TabIndex = 5;
			this.txtMark.Text = "--";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txtMark);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.Numbers);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.ListBox Numbers;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label txtMark;
	}
}

