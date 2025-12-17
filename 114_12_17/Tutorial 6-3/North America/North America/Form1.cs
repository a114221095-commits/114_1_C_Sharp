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
        
        private bool GetFileName(out string filename)
        {
            filename = string.Empty;
            // Configure OpenFileDialog
            openFile.Title = "Select countries file";
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filename = openFile.FileName;
                return true;
            }

            return false;
        }

        private void GetCountries(string filename)
        {
            // Clear existing items and load file lines into the listbox
            countriesListBox.Items.Clear();

            try
            {
                using (var reader = new StreamReader(filename, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            countriesListBox.Items.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到檔案。", "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("讀取檔案時發生錯誤：\r\n" + ex.Message, "I/O 錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：\r\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string filename;
            if (GetFileName(out filename))
            {
                GetCountries(filename);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
