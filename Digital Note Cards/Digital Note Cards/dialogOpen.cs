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

namespace Digital_Note_Cards
{
    public partial class dialogOpen : Form
    {
        public string selectedIndex;

        public dialogOpen()
        {
            InitializeComponent();
        }

        private void dialogOpen_Load(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //Create an object of the folder directory
            DirectoryInfo directory = new DirectoryInfo(folderProgram);
            //Store all subfolders in an object array
            DirectoryInfo[] subFolders = directory.GetDirectories();
            //For each object in the subfolder object array add the name to the list box
            foreach (DirectoryInfo folder in subFolders)
                lstBxDialog.Items.Add(folder.Name);
        }

        private void opnBtn_Click(object sender, EventArgs e)
        {
            //Default dialog.OK
            //Set the item selected in the list box to a variable to be passed to infoForm
            if (lstBxDialog.SelectedIndex == -1 && lstBxDialog.Items.Count > 0)
            {
                MessageBox.Show("Select a set of flash cards.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change dialog result to none if item not selected in list box
                this.DialogResult = DialogResult.None;
            }
            else
            {
                selectedIndex = lstBxDialog.SelectedItem.ToString();
            }
        }

        private void cnlBtn_Click(object sender, EventArgs e)
        {
            //Default dialog.Cancel
        }
    }
}
