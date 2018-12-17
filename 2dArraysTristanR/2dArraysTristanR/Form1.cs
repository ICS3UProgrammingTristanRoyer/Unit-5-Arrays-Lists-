/*
 * Created by: Tristan Royer
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - 2D Arrays
 * This program generates a 2d array and finds the average of all the values
*/
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
		int userTotal = -1;
		int average;
	


		public Form1()
		{

			InitializeComponent();
			


		}
		private int GetAverage (int [,] the2DArray  )
		{
			int total = 0;
			int average;
			foreach (int arrayValue in the2DArray)
			{

				total = total +  arrayValue;

			}
			average = total / the2DArray.Length;
			return average;


		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			// declare variables
			int width;
			int height;
			Random randomNumberGenerator = new Random();
			int aRandomNumber;
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
					aRandomNumber = randomNumberGenerator.Next(0, 9+1);
					// insert the random Number into the array and the current width and height
					a2DArray[widthCounter, heightCounter] = aRandomNumber;

					// add the randomumber to the string of array numbers
					aPieceOfText = aPieceOfText + " " + aRandomNumber;

				
			}
				// add a line break to the end of the line to show a new row in the string
				aPieceOfText = aPieceOfText + "\r" + "\n";

			}
			// insert the string into the textbox
			this.txtArray.Text = aPieceOfText;
		    average = GetAverage(a2DArray );



		}

		private void button1_Click(object sender, EventArgs e)
		{
			lblAnswer.Text = "the average is:" + average;

		}

		private void txtArray_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
