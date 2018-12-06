using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2dArraysTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double GetAverage (int [,] the2DArray , double total)
		{
			total = total / the2DArray.Length;

			return total;


		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			// declare variables
			int width;
			int height;
			Random randomNumberGenerator = new Random();
			int aRandomNumber;
			int userTotal = 0;
			string aPieceOfText = null;


			// get the desired width and height from the user.
			width = Convert.ToInt16(this.nudWidth.Value);
			height = Convert.ToInt16(this.nudHeight.Value);

			// declare the 2d array with the desired width and height
			int[,] a2DArray = new int[width, height];

			// loop though each element within the width
			for (int widthCounter = 0; widthCounter < width; widthCounter++)
			{
				// loop through each element in the hieght
				for (int heightCounter = 0; heightCounter < height; heightCounter++)
				{   // get a random number between 0 and 9
					aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);
					// insert the random Number into the array and the current width and height
					a2DArray[widthCounter, heightCounter] = aRandomNumber;

					// add the randomumber to the string of array numbers
					aPieceOfText = aPieceOfText + " " + aRandomNumber;

					// get the user total
					userTotal = userTotal +  widthCounter + heightCounter;



				}
				// add a line break to the end of the line to show a new row in the string
				aPieceOfText = aPieceOfText + "\r" + "\n";

			}
			// insert the string into the textbox
			this.txtArray.Text = aPieceOfText;

			userTotal = GetAverage(a2DArray[width,height], userTotal);
			
		}
	}
}
