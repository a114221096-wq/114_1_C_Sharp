using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.


        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName; // To hold the file name
            GetFileName(out fileName);
            getCountries(fileName);
        }
        private void GetFileName(out string fileName)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name.
                fileName = openFileDialog.FileName;
            }
            else
            {
                // If no file was selected, set fileName to an empty string.
                fileName = string.Empty;
            } }
        private void getCountries(string fileName)
        {
            // Clear the ListBox.
            string country;
            countriesListBox.Items.Clear();
            if (openFile.FileName != string.Empty)
            {
                // Open the file.
                StreamReader inputFile = File.OpenText(fileName);
                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }

            }
        } 
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
