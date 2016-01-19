using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Digital_Note_Cards
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.createDirectory();
            Application.Run(new introForm());
        }

        static void createDirectory()
        {
            string folderLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderProgram = System.IO.Path.Combine(folderLocal, "Digital Flash Cards");

            if (!System.IO.Directory.Exists(folderProgram))
            {
                System.IO.Directory.CreateDirectory(folderProgram);
                MessageBox.Show("Installed application to My Documents folder.", "Installing", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
