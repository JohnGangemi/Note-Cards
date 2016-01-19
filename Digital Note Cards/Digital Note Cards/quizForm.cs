using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Note_Cards
{
    public partial class quizForm : Form
    {
        private string currentFolder;
        private int i = 0;
        private bool end = false;

        public quizForm()
        {
            InitializeComponent();
        }

        private void preBtn_Click(object sender, EventArgs e)
        {
            string[] questions = questionsArray();

            queTxBx.Clear();
            ansTxBx.Clear();

            //Check if the quiz has ended, if not continue decrementing i, if so then reset boolean end to false
            if (end == false)
            {
                i--;
                //Stop the counter from displaying negative values on the first question after repeated clicks
                if (i < 0)
                {
                    numLbl.Text = 1 + "/" + questions.Length;
                    i = 0;
                }
            }
            else
                end = false;

            numLbl.Text = (i + 1) + "/" + questions.Length;
            queTxBx.Text = questions[i];
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            string[] questions = questionsArray();

            queTxBx.Clear();
            ansTxBx.Clear();

            //Check if the quiz has ended, if not continue incrementing i, if so then reset boolean end to false
            if (end == false)
                i++;
            else
                end = false;

            //while i is less than the # of elements in questions array display the corresponding question else if i is out of bounds then the quiz has ended
            if (i < questions.Length)
            {
                numLbl.Text = (i + 1) + "/" + questions.Length;
                queTxBx.Text = questions[i];
            }
            else
            {
                numLbl.Text = "";

                //Display a message box at the end of the quiz
                DialogResult result;
                result = MessageBox.Show("Would you like to restart the quiz?", "Quiz Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            //Reset the index i and set boolean end to true
                            i = 0;
                            end = true;
                            nxtBtn.PerformClick();
                            break;
                        }
                    case DialogResult.No:
                        {
                            i = 0;
                            end = true;
                            backBtn.PerformClick();
                            break;
                        }
                }
            }
        }

        private void ansBtn_Click(object sender, EventArgs e)
        {
            string[] answers = answersArray();

            //Check if the quiz has ended, ie no more answers available
            if (end == true)
                ansTxBx.Text = "No answer is available...";
            else
                if (answers[i] == "" || answers[i] == null)
                    ansTxBx.Text = "No answer is available...";
                else
                    ansTxBx.Text = answers[i];
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string[] questions = questionsArray();
            string[] answers = answersArray();

            //Refresh form with new control
            queTxBx.Clear();
            ansTxBx.Clear();
            nxtBtn.Hide();
            preBtn.Hide();
            ansBtn.Hide();
            editBtn.Hide();
            cancelBtn.Show();
            saveBtn.Show();

            queTxBx.Text = questions[i];
            ansTxBx.Text = answers[i];
            queTxBx.Focus();
            queTxBx.ReadOnly = false;
            ansTxBx.ReadOnly = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quizForm_Load(object sender, EventArgs e)
        {
            //Hide edit controls
            saveBtn.Hide();
            cancelBtn.Hide();

            //Use dialog method to show form modally
            dialogOpen dialog = new dialogOpen();
            dialog.ShowDialog(this);

            if (dialog.DialogResult == DialogResult.OK)
            {
                //Set the current folder selected from dialogOpen list box 
                currentFolder = dialog.selectedIndex;

                //Check if the set of flash cards is empty
                if (questionsArray().Length == 0 || answersArray().Length == 0)
                {
                    string missing = "Questions and/or answers missing for " + currentFolder.ToUpper() + ".\nEnter information first by clicking the 'Enter Info' button.";
                    MessageBox.Show(missing, "Flash Cards Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //Start the form with the first question visible
                    string[] questions = questionsArray();
                    queTxBx.Text = questions[i];
                    queTxBx.DeselectAll();
                    numLbl.Text = (i + 1) + "/" + questions.Length;
                }
            }
            else if (dialog.DialogResult == DialogResult.Cancel)
            {
                //If you close dialogOpen form then also close the quizForm
                this.Close();
            }
            dialog.Dispose();
        }

        private string[] questionsArray()
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");
            string subPath = System.IO.Path.Combine(folderProgram, currentFolder);
            string file = System.IO.Path.Combine(subPath, "questions.txt");
            string[] questions_array = System.IO.File.ReadAllLines(file);

            return questions_array;
        }

        private string[] answersArray()
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");
            string subPath = System.IO.Path.Combine(folderProgram, currentFolder);
            string file = System.IO.Path.Combine(subPath, "answers.txt");
            string[] answers_array = System.IO.File.ReadAllLines(file);

            return answers_array;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");
            string subPath = System.IO.Path.Combine(folderProgram, currentFolder);
            string qFile = System.IO.Path.Combine(subPath, "questions.txt");
            string aFile = System.IO.Path.Combine(subPath, "answers.txt");

            string[] questions = questionsArray();
            string[] answers = answersArray();

            if (queTxBx.Text.Trim() == "")
            {
                MessageBox.Show("If you wish to enter a 'Study Tip' leave the answer field blank and input the data into the question field.", "Enter A Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                queTxBx.Focus();
            }
            else if (ansTxBx.Text.Trim() == "" && (queTxBx.Text.Trim() != "" || queTxBx.Text.Trim() != null))
            {
                string defaultAnswer = "No answer available...";
                answers[i] = defaultAnswer;
                questions[i] = queTxBx.Text.Trim();
                System.IO.File.WriteAllLines(qFile, questions);
                System.IO.File.WriteAllLines(aFile, answers);
            }
            else
            {
                answers[i] = ansTxBx.Text.Trim();
                questions[i] = queTxBx.Text.Trim();
                System.IO.File.WriteAllLines(qFile, questions);
                System.IO.File.WriteAllLines(aFile, answers);
            }

            //refesh form with new control
            queTxBx.Clear();
            ansTxBx.Clear();
            nxtBtn.Show();
            preBtn.Show();
            ansBtn.Show();
            editBtn.Show();
            cancelBtn.Hide();
            saveBtn.Hide();

            queTxBx.Text = questions[i];
            nxtBtn.Focus();
            queTxBx.ReadOnly = true;
            ansTxBx.ReadOnly = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string[] questions = questionsArray();

            //refesh form with new control
            queTxBx.Clear();
            ansTxBx.Clear();
            nxtBtn.Show();
            preBtn.Show();
            ansBtn.Show();
            editBtn.Show();
            cancelBtn.Hide();
            saveBtn.Hide();

            queTxBx.Text = questions[i];
            nxtBtn.Focus();
            queTxBx.ReadOnly = true;
            ansTxBx.ReadOnly = true;
        }

        private void queTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void ansTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

    }
}
