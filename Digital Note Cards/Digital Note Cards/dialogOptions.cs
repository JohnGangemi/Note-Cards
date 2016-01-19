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
    public partial class dialogOptions : Form
    {
        public string selectedFolder;
        public string deletedFolder;

        public dialogOptions()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //Default dialog.Cancel
        }

        private void lstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dialogOptions_Load(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //Create an object of the folder directory
            DirectoryInfo directory = new DirectoryInfo(folderProgram);
            //Store all subfolders in an object array
            DirectoryInfo[] subFolders = directory.GetDirectories();
            //For each object in the subfolder object array add the name to the list box
            foreach (DirectoryInfo folder in subFolders)
                lstBx.Items.Add(folder.Name);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //Use dialog method to show form modally
            dialogCreate dialog = new dialogCreate();
            dialog.ShowDialog(this);
            if (dialog.DialogResult == DialogResult.OK)
            {
                //Get and set the user entered text from the dialog form into variable
                selectedFolder = dialog.subName;
                //Create a new sub folder in the folder directory for the program
                DirectoryInfo subDirectory = new DirectoryInfo(folderProgram);
                subDirectory.CreateSubdirectory(selectedFolder);
                string subFolderPath = System.IO.Path.Combine(folderProgram, selectedFolder);

                //Create text files in new sub folder and properly closes them after creation
                FileInfo queFile = new FileInfo(System.IO.Path.Combine(subFolderPath, "questions.txt"));
                using (FileStream fs = queFile.Create())
                {
                    fs.Close();
                }
                FileInfo ansFile = new FileInfo(System.IO.Path.Combine(subFolderPath, "answers.txt"));
                using (FileStream fs = ansFile.Create())
                {
                    fs.Close();
                }

                //Close dialog box with dialog.OK
                this.DialogResult = DialogResult.OK;
            }
            dialog.Dispose();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            if (lstBx.SelectedIndex == -1 && lstBx.Items.Count > 0)
            {
                MessageBox.Show("Select a set of flash cards.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lstBx.Items.Count < 1 && lstBx.SelectedIndex == -1)
            {
                MessageBox.Show("All flash cards deleted, create new flash cards.", "No Flash Cards", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Add the selected item from the list box to a variable to be passed to infoForm 
                deletedFolder = lstBx.SelectedItem.ToString();

                string info =deletedFolder.ToUpper() + " will be deleted. Are you sure?";
                DialogResult result;
                result = MessageBox.Show(info, "Delete Flash Cards", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            //Store the subfolder path using the selected object from the list box
                            string deletePath = System.IO.Path.Combine(folderProgram, deletedFolder);

                            //Create an object reference to the target files and delete them thus emptying the corresponding subfolder
                            FileInfo queFile = new FileInfo(System.IO.Path.Combine(deletePath, "questions.txt"));
                            queFile.Delete();
                            FileInfo ansFile = new FileInfo(System.IO.Path.Combine(deletePath, "answers.txt"));
                            ansFile.Delete();

                            //Create an object reference to the target directory
                            DirectoryInfo subDirectory = new DirectoryInfo(deletePath);
                            subDirectory.Delete();

                            //Remove the selected item from the list box
                            lstBx.Items.Remove(lstBx.SelectedItem);

                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            //Default dialog.OK

            //Set the item selected in the list box to a variable to be passed to infoForm
            if (lstBx.SelectedIndex == -1 && lstBx.Items.Count > 0)
            {
                MessageBox.Show("Select a set of flash cards.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change dialog result to none if item not selected in list box
                this.DialogResult = DialogResult.None;
            }
            else if (lstBx.Items.Count < 1 && lstBx.SelectedIndex == -1)
            {
                MessageBox.Show("All flash cards deleted, create new flash cards.", "No Flash Cards", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change dialog result to none if item not selected in list box
                this.DialogResult = DialogResult.None;
            }
            else
            {
                selectedFolder = lstBx.SelectedItem.ToString();
            }
        }
    }
}
