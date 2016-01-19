namespace Digital_Note_Cards
{
    partial class infoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoForm));
            this.queTxBx = new System.Windows.Forms.TextBox();
            this.ansTxBx = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.folderLbl = new System.Windows.Forms.Label();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queTxBx
            // 
            this.queTxBx.Cursor = System.Windows.Forms.Cursors.Default;
            this.queTxBx.Location = new System.Drawing.Point(183, 47);
            this.queTxBx.Multiline = true;
            this.queTxBx.Name = "queTxBx";
            this.queTxBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queTxBx.Size = new System.Drawing.Size(578, 179);
            this.queTxBx.TabIndex = 0;
            this.queTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.queTxBx_KeyPress);
            // 
            // ansTxBx
            // 
            this.ansTxBx.Cursor = System.Windows.Forms.Cursors.Default;
            this.ansTxBx.Location = new System.Drawing.Point(183, 294);
            this.ansTxBx.Multiline = true;
            this.ansTxBx.Name = "ansTxBx";
            this.ansTxBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ansTxBx.Size = new System.Drawing.Size(578, 179);
            this.ansTxBx.TabIndex = 1;
            this.ansTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ansTxtBx_KeyPress);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 40);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Main Menu";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(420, 240);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 40);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(179, 23);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(73, 21);
            this.questionLbl.TabIndex = 5;
            this.questionLbl.Text = "Question";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.BackColor = System.Drawing.Color.Transparent;
            this.answerLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.Location = new System.Drawing.Point(179, 271);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(62, 21);
            this.answerLbl.TabIndex = 6;
            this.answerLbl.Text = "Answer";
            // 
            // folderLbl
            // 
            this.folderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.folderLbl.BackColor = System.Drawing.Color.Transparent;
            this.folderLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLbl.Location = new System.Drawing.Point(506, 12);
            this.folderLbl.Name = "folderLbl";
            this.folderLbl.Size = new System.Drawing.Size(251, 28);
            this.folderLbl.TabIndex = 7;
            this.folderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(12, 74);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(100, 40);
            this.optionsBtn.TabIndex = 4;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.folderLbl);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ansTxBx);
            this.Controls.Add(this.queTxBx);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "infoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Flash Cards 2013";
            this.Load += new System.EventHandler(this.infoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queTxBx;
        private System.Windows.Forms.TextBox ansTxBx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Label folderLbl;
        private System.Windows.Forms.Button optionsBtn;
    }
}