using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity_15_CST_150
{
    public partial class Form1 : Form
    {
        // Declare some variables. 
        int maxDay;
        static int luckyNumber;
        public Form1()
        {
            InitializeComponent();
        }
        public int getLuckyNumber()
        {
            return luckyNumber;
        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {
            /* Control box indexes are zero-based index. If we were to enter "cboYear.SelectedIndex != 0"
            we would essentially be telling the program "do not run these lines of code wrapped in this if statement if
            the user selected the first index in the combobox."*/
            if (cboYear.SelectedIndex != -1 && cboMonth.SelectedIndex != -1 && cboDay.SelectedIndex != -1 && cboColor.SelectedIndex != -1 && cboFavNumber.SelectedIndex != -1)
            {
                //Calculate lucky number by multiplying the cboFavNumber and cboColor index and then adding all of the indexes together.
                luckyNumber = (cboYear.SelectedIndex + cboMonth.SelectedIndex + cboDay.SelectedIndex + cboColor.SelectedIndex * cboFavNumber.SelectedIndex);
                Form2 resultForm = new Form2();
                // Display the second form. 
                resultForm.Show();
            }
            else
            {
                MessageBox.Show("You did not fill the form! Please enter a valid birthday, a favorite number, and a favorite color!");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Invoke the maximumDay() method to calculate how many days are in a month. 
            maximumDay();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Invoke the maximumDay() method to calculate how many days are in a month. 
            maximumDay();
        }

        // This is a method to determine how many days are in a particular month. 
        public void maximumDay()
        {
            maxDay = 0;
            if (cboMonth.SelectedIndex == 0 || cboMonth.SelectedIndex == 2 || cboMonth.SelectedIndex == 4 || cboMonth.SelectedIndex == 6 || cboMonth.SelectedIndex == 7 || cboMonth.SelectedIndex == 9 || cboMonth.SelectedIndex == 11)
            {
                maxDay = 31;
            }


            /* Determine whether or not it is a leap year.
             * The modulo operator returns the remainder of a division.
             We can use this to determine whether or not one number is a multiple of another.*/
            else if (cboMonth.SelectedIndex == 1)
            {
                int year = Int32.Parse(cboYear.Text);
                // If a year is multiple of 400, then it is a leap year. 
                if (year % 400 == 0)
                    maxDay = 29;
                // If a year is muliple of 100, then it is not a leap year
                if (year % 100 == 0)
                    maxDay = 28;
                // If a year is muliple of 4, then it is a leap year
                if (year % 4 == 0)
                    maxDay = 29;
            }
            else
                maxDay = 30;

            /* Display the days by adding them to the combobox. */
            if (cboMonth.SelectedIndex != -1)
            {
                cboDay.Items.Clear();
                for (int i = 0; i < maxDay; i++)
                {
                    cboDay.Items.Add(i + 1);
                }
                cboDay.Text = maxDay.ToString();
            }
        }

    }
}