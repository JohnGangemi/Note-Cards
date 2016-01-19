namespace Digital_Note_Cards
{
    partial class quizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizForm));
            this.answerLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.ansTxBx = new System.Windows.Forms.TextBox();
            this.queTxBx = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.preBtn = new System.Windows.Forms.Button();
            this.ansBtn = new System.Windows.Forms.Button();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.numLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.BackColor = System.Drawing.Color.Transparent;
            this.answerLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.Location = new System.Drawing.Point(179, 271);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(62, 21);
            this.answerLbl.TabIndex = 10;
            this.answerLbl.Text = "Answer";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(179, 23);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(73, 21);
            this.questionLbl.TabIndex = 9;
            this.questionLbl.Text = "Question";
            // 
            // ansTxBx
            // 
            this.ansTxBx.Cursor = System.Windows.Forms.Cursors.Default;
            this.ansTxBx.Location = new System.Drawing.Point(183, 294);
            this.ansTxBx.Multiline = true;
            this.ansTxBx.Name = "ansTxBx";
            this.ansTxBx.ReadOnly = true;
            this.ansTxBx.Size = new System.Drawing.Size(578, 179);
            this.ansTxBx.TabIndex = 1;
            this.ansTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ansTxBx_KeyPress);
            // 
            // queTxBx
            // 
            this.queTxBx.Cursor = System.Windows.Forms.Cursors.Default;
            this.queTxBx.Location = new System.Drawing.Point(183, 47);
            this.queTxBx.Multiline = true;
            this.queTxBx.Name = "queTxBx";
            this.queTxBx.ReadOnly = true;
            this.queTxBx.Size = new System.Drawing.Size(578, 179);
            this.queTxBx.TabIndex = 0;
            this.queTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.queTxBx_KeyPress);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 40);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Main Menu";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // preBtn
            // 
            this.preBtn.Location = new System.Drawing.Point(292, 240);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(100, 40);
            this.preBtn.TabIndex = 4;
            this.preBtn.Text = "Previous";
            this.preBtn.UseVisualStyleBackColor = true;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // ansBtn
            // 
            this.ansBtn.Location = new System.Drawing.Point(420, 240);
            this.ansBtn.Name = "ansBtn";
            this.ansBtn.Size = new System.Drawing.Size(100, 40);
            this.ansBtn.TabIndex = 2;
            this.ansBtn.Text = "Show Answer";
            this.ansBtn.UseVisualStyleBackColor = true;
            this.ansBtn.Click += new System.EventHandler(this.ansBtn_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(548, 240);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(100, 40);
            this.nxtBtn.TabIndex = 3;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(828, 445);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 40);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // numLbl
            // 
            this.numLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numLbl.BackColor = System.Drawing.Color.Transparent;
            this.numLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLbl.Location = new System.Drawing.Point(506, 12);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(251, 28);
            this.numLbl.TabIndex = 11;
            this.numLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(314, 240);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 40);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(526, 240);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 40);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // quizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.numLbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.ansBtn);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.ansTxBx);
            this.Controls.Add(this.queTxBx);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "quizForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Flash Cards 2013";
            this.Load += new System.EventHandler(this.quizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox ansTxBx;
        private System.Windows.Forms.TextBox queTxBx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.Button ansBtn;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}