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
    public partial class dialogCreate : Form
    {
        public string subName;

        public dialogCreate()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (nameTxBx.Text.Trim().Length < 1)
            {
                this.DialogResult = DialogResult.None;
                
                nameTxBx.Clear();
                nameTxBx.Focus();
            }
            else if (nameTxBx.Text.Length > 0 && Alpha() == false)
            {
                this.DialogResult = DialogResult.None;

                nameTxBx.Clear();
                nameTxBx.Focus();
            }
            else if (nameTxBx.Text.Length > 0 && Alpha() == true)
            {
                subName = nameTxBx.Text.Trim();

                if (subName.Length > 50)
                {
                    subName = subName.Substring(0,50);
                }
            }
        }

        private void nameTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                createBtn.Focus();
            }
        }

        private bool Alpha()
        {
            int count = 0;
            StringBuilder sb = new StringBuilder();

            foreach (char ch in nameTxBx.Text.Trim())
            {
                if (char.IsWhiteSpace(ch) == false)
                {
                    sb.Append(ch);
                }
            }

            foreach (char ch in sb.ToString())
            {
                if (char.IsLetterOrDigit(ch) == false)
                    count++;
            }

            if (count > 0)
                return false;
            else
                 return true;
          }

        private void dialogCreate_Load(object sender, EventArgs e)
        {
        }

        private void nameTxBx_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
