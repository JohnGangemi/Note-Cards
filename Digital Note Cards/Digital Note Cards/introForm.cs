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
    public partial class introForm : Form
    {
        public introForm()
        {
            InitializeComponent();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            //create an object for the infoForm
            infoForm info = new infoForm();
            //create a form closed event to dispose of the infoForm form correctly
            info.FormClosed += new FormClosedEventHandler(info_FormClosed);
            this.Hide();
            info.Show();
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            //check if the program's directory contains sub-folders (flash card subjects)
            if (System.IO.Directory.GetDirectories(folderProgram).Length == 0)
            {
                MessageBox.Show("Enter information first by clicking the 'Enter Info' button.", "Flash Cards Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (System.IO.Directory.GetDirectories(folderProgram).Length != 0)
            {
                //create an object for the quizForm
                quizForm quiz = new quizForm();
                //create a form closed event to dispose of the quizForm form correctly
                quiz.FormClosed += new FormClosedEventHandler(quiz_FormClosed);
                this.Hide();
                quiz.Show();
            }
        }

        private void quiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            quizForm quiz = new quizForm();
            quiz.Dispose();
            this.Show();
        }

        private void info_FormClosed(object sender, FormClosedEventArgs e)
        {
            infoForm info = new infoForm();
            info.Dispose();
            this.Show();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
            abt.Dispose();
        }
    }
}
