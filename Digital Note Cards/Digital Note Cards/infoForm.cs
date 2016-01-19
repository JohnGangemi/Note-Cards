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
    public partial class infoForm : Form
    {
        private string currentFolder;

        public infoForm()
        {
            InitializeComponent();
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //Check if sub folders exists in the folder directory. If not then create a new sub folder and its text files, else choose from existing sub folders
            if (System.IO.Directory.GetDirectories(folderProgram).Length == 0)
            {
                //Forces user to create a new sub folder if none exists
                createCardsDialog();
                folderLbl.Text = currentFolder;
            }
            else if (System.IO.Directory.GetDirectories(folderProgram).Length != 0)
            {
                //Forces user to choose a sub folder to open, delete, or create 
                showOptionsDialog();
            }
        }

        private void createCardsDialog()
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //Use dialog method to show form modally
            dialogCreate dialog = new dialogCreate();
            dialog.ShowDialog(this);
            if (dialog.DialogResult == DialogResult.OK)
            {
                //Get and set the user entered text from the dialog form into variable
                currentFolder = dialog.subName;

                //Create a new sub folder in the folder directory for the program
                DirectoryInfo subDirectory = new DirectoryInfo(folderProgram);
                subDirectory.CreateSubdirectory(currentFolder);
                string subFolderPath = System.IO.Path.Combine(folderProgram, currentFolder);

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
            }
            else if (dialog.DialogResult == DialogResult.Cancel)
            {
                //Creates a recursive process where user must enter text
                this.Close();
            }
            dialog.Dispose();
        }

        /*private void openCardsDialog()
        {
            //Use dialog method to show form modally
            dialogOpen dialog = new dialogOpen();
            dialog.ShowDialog(this);

            if (dialog.DialogResult == DialogResult.OK)
            {
                //Set the current folder selected from dialogOpen list box 
                currentFolder = dialog.selectedIndex;
            }
            else if (dialog.DialogResult == DialogResult.Cancel)
            {
                //If you close dialogOpen form then also close the infoForm
                this.Close();
            }
            dialog.Dispose();
        }*/

        private void showOptionsDialog()
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //Use dialog method to show form modally
            dialogOptions dialog = new dialogOptions();
            dialog.ShowDialog(this);

            if (dialog.DialogResult == DialogResult.OK)
            {
                //Set the current folder selected from dialogOptions list box 
                currentFolder = dialog.selectedFolder;
                folderLbl.Text = currentFolder;
            }
            else if (dialog.DialogResult == DialogResult.Cancel)
            {
                //close the dialog box
                //Check if infoForm is visible such that current folder has a value
                if (currentFolder != null)
                {
                    //Process accordingly if infoForm is visible and either all cards are deleted or the current cards open are deleted
                    if ((currentFolder == dialog.deletedFolder && dialog.deletedFolder != null) || (System.IO.Directory.GetDirectories(folderProgram).Length == 0))
                    {
                        if (currentFolder == dialog.deletedFolder && dialog.deletedFolder != null)
                            MessageBox.Show("Current set of flash cards deleted or missing, closing this form...", "Flash Cards Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (System.IO.Directory.GetDirectories(folderProgram).Length == 0)
                            MessageBox.Show("All flash cards deleted, closing this form...", "Flash Cards Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                //Check if the infoForm is not visible such that there is no current folder selected
                else if (currentFolder == null)
                    this.Close();
            }
            dialog.Dispose();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");
            string subFolderPath = System.IO.Path.Combine(folderProgram, currentFolder);

            //Check for cases where question textbox is empty, question textbox contains characters but answer textbox is empty, or both textboxes contain characters
            if (queTxBx.Text.Trim().Length == 0)
            {
                MessageBox.Show("If you wish to enter a 'Study Tip' leave the answer field blank and input the data into the question field.", "Enter A Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ansTxBx.Text.Trim().Length == 0 && (queTxBx.Text.Trim().Length != 0))
            {
                string noAnswer = "No answer available";

                //Append to text files in current sub folder and properly close them 
                using (StreamWriter queFile = new StreamWriter(System.IO.Path.Combine(subFolderPath, "questions.txt"), true))
                {
                    queFile.WriteLine(queTxBx.Text.Trim());
                    queFile.Close();
                }
                using (StreamWriter ansFile = new StreamWriter(System.IO.Path.Combine(subFolderPath, "answers.txt"), true))
                {
                    ansFile.WriteLine(noAnswer);
                    ansFile.Close();
                }
            }
            else
            {
                //Append to text files in current sub folder and properly close them 
                using (StreamWriter queFile = new StreamWriter(System.IO.Path.Combine(subFolderPath, "questions.txt"), true))
                {
                    queFile.WriteLine(queTxBx.Text.Trim());
                    queFile.Close();
                }
                using (StreamWriter ansFile = new StreamWriter(System.IO.Path.Combine(subFolderPath, "answers.txt"), true))
                {
                    ansFile.WriteLine(ansTxBx.Text.Trim());
                    ansFile.Close();
                }
            }

            queTxBx.Clear();
            ansTxBx.Clear();
            queTxBx.Focus();
        }

        private void queTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                ansTxBx.Focus();
            }
        }

        private void ansTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                addBtn.PerformClick();
            }
        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            showOptionsDialog();
        }
    }
}
