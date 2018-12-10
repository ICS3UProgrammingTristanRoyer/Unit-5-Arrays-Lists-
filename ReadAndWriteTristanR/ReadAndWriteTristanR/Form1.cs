using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadAndWriteTristanR
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
			lblOutput.Hide();

		}

		private bool StringsAreEqual(string words1 , string words2 , ref bool isEqual)
		{
			string lowerString1;
			string lowerString2;

			lowerString1 = words1.ToLower();
			lowerString2 = words2.ToLower();


			if (lowerString1 == lowerString2)
			{
				isEqual = true;
			}

			else
			{
				isEqual = false;

			}

			return isEqual;

		}
		private void btnCheck_Click(object sender, EventArgs e)
		{
			// declare bool
			bool equality = false;
			// Read each of the file into a string array. Each element
			// of the array is one line of the file.
			string[] lines = System.IO.File.ReadAllLines(@"input.txt");

			// array of characters that I want to take out when I split the line into words ( spaces , tabs)
			char[] charSeparators = new char[] { ' ', '\t' };

			// the output string where I will put my results 
			string output = "";

			// go through and compare each string on each line of the file
			foreach (string line in lines)
			{
				// split each line into words and put them into an array. I am assuming there are only
				// two words on the line.
				string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

				equality = StringsAreEqual(words[0], words[1] , ref equality);

				if (equality == true)
				{
					// concatenate the output to the string.There must be \r\n so that it goes to a new line in the text file.
					output = output + "True\r\n";


				}
				else
				{
					// concatenate the output to the string.There must be \r\n so that it goes onto a new line in the text file.
					output = output + "False\r\n";


				}

			}
			//WriteAllText creates a file , writes the specified string to the file,
			//and then closes the file. You do NOT need to call Flush() or Close().
			// If the file already exists , it overwrites the file.
			System.IO.File.WriteAllText(@"output.txt", output);

			// show the label notifying the user that the process is done
			this.lblOutput.Show();
		}
	}
}
