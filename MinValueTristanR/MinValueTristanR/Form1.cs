/*
 * Created by: Tristan Royer
 * Created on: 3-12-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program displays the min value within an array of numbers.
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

namespace MinValueTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double GetMinValue(int[] tmpArrayOfNumbers)
		{
			// declare variables
			double tmpMinValue = 501;
			// create a for loop which repeats the if statement
			foreach (int arrayValue in tmpArrayOfNumbers)
			{
				// if the current index of the array is less than the current minValue it will replace it.
				if (arrayValue < tmpMinValue)
				{
					tmpMinValue = arrayValue;
				}
			}
			// return the minValue.
			return tmpMinValue;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			//clear the list
			this.Values.Items.Clear();
			//declare local variables and constants
			const int MAX_ARRAY_SIZE = 10;
			const int MAX_RANDOM_NUMBER = 500;
			int counter;
			double minValue;
			Random randomNumberGenerator = new Random();
			int randomNumber;

			int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];
			// while the counter is less than the max array size do the execute the functions.
			for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
			{
				// generate a new random number between 1 and the MAX_ARRAY_SIZE
				randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER+ 1);

				// assign the random number to the cell at position "counter" in the array.
				arrayOfNumbers[counter] = randomNumber;

				// add the random number to the list
				this.Values.Items.Add(randomNumber);

				// refresh the form to display the new item in the list box
				this.Refresh();
			}
			//call the function , passing it the arrayOfNumbers argument
			
			minValue = GetMinValue(arrayOfNumbers);
			// edit the text to display the minValue.
			this.lblMinValue.Text = ("The Lowest value is:" + minValue);

		}
		
		}
	}

