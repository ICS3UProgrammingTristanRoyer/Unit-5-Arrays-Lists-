using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAverageTristanR
{
	public partial class Form1 : Form
	{
		int average;
		List<int> myListOfIntegers = new List<int>();

		public Form1()
		{

			InitializeComponent();

		}


		private double CalculateAverage ( ref int[] theListOfIntegers)
		{
			// declare variables
			double theAverage;
			double theTotalOfNumbers = 0;
			

			for (int counter = 0; counter < theListOfIntegers.Length ; counter++)
			{
				theTotalOfNumbers = theTotalOfNumbers + theListOfIntegers[counter];
				
			}

			theAverage = theTotalOfNumbers / theListOfIntegers.Length;

			return theAverage;
		}
		private void btnEnter_Click(object sender, EventArgs e)
		{
			// declare local variables
			int userMark = -1;


			// convert the value in the textbox to an integer
			try
			{
				userMark = int.Parse(txtMark.Text);

			}
			// if the user did not enter a valid number , write the error to the command line
			catch (Exception parseError)
			{
				Console.WriteLine("An error occured: '{0}'", parseError);
			}
			// check if the user entered a number between 0 and 100
			if ((userMark >=0 ) && (userMark <=100) )
			{
				// add the mark to the listbox
				this.Numbers.Items.Add(userMark);

				// add the mark to the list
				myListOfIntegers.Add(userMark);

				
			}
			//otherwise, display an error
			else
			{
				MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Numbers");
			}

			average = CalculateAverage( ref myListOfIntegers);

		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			lblAnswer.Text = "" + average;

		}
	}
}
