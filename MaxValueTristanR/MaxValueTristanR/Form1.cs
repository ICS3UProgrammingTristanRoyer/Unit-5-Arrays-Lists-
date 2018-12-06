using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxValueTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double GetMaxValue(int[] tmpArrayOfNumbers)
		{
			// declare variables
			int counter;
			double tmpMaxValue = -1;
			// create a for loop which repeats the if statement
			for (counter = 0; tmpArrayOfNumbers.Length > counter; counter++)
			{
				// if the current index of the array is more than the current minValue it will replace it.
				if (tmpArrayOfNumbers[counter] > tmpMaxValue)
				{
					tmpMaxValue = tmpArrayOfNumbers[counter];
				}
			}
			// return the minValue.
			return tmpMaxValue;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			//declare local variables and constants
			const int MAX_ARRAY_SIZE = 10;
			const int MAX_RANDOM_NUMBER = 500;
			int counter;
			double maxValue;
			Random randomNumberGenerator = new Random();
			int randomNumber;

			int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];
			// while the counter is less than the max array size do the execute the functions.
			for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
			{
				// generate a new random number between 1 and the MAX_ARRAY_SIZE
				randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

				// assign the random number to the cell at position "counter" in the array.
				arrayOfNumbers[counter] = randomNumber;

				// add the random number to the list
				this.Values.Items.Add(randomNumber);

				// refresh the form to display the new item in the list box
				this.Refresh();
			}
			//call the function , passing it the arrayOfNumbers argument

			maxValue = GetMaxValue(arrayOfNumbers);
			// edit the text to display the minValue.
			this.lblMaxValue.Text = ("The Lowest value is:" + maxValue);

		}

	}
}

