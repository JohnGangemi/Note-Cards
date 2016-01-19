namespace Digital_Note_Cards
{
    partial class dialogOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogOpen));
            this.lstBxDialog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opnBtn = new System.Windows.Forms.Button();
            this.cnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxDialog
            // 
            this.lstBxDialog.FormattingEnabled = true;
            this.lstBxDialog.HorizontalScrollbar = true;
            this.lstBxDialog.ItemHeight = 17;
            this.lstBxDialog.Location = new System.Drawing.Point(57, 47);
            this.lstBxDialog.Name = "lstBxDialog";
            this.lstBxDialog.ScrollAlwaysVisible = true;
            this.lstBxDialog.Size = new System.Drawing.Size(184, 123);
            this.lstBxDialog.Sorted = true;
            this.lstBxDialog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flash cards:";
            // 
            // opnBtn
            // 
            this.opnBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.opnBtn.Location = new System.Drawing.Point(297, 53);
            this.opnBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opnBtn.Name = "opnBtn";
            this.opnBtn.Size = new System.Drawing.Size(100, 40);
            this.opnBtn.TabIndex = 1;
            this.opnBtn.Text = "Open";
            this.opnBtn.UseVisualStyleBackColor = true;
            this.opnBtn.Click += new System.EventHandler(this.opnBtn_Click);
            // 
            // cnlBtn
            // 
            this.cnlBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnlBtn.Location = new System.Drawing.Point(298, 123);
            this.cnlBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnlBtn.Name = "cnlBtn";
            this.cnlBtn.Size = new System.Drawing.Size(100, 40);
            this.cnlBtn.TabIndex = 2;
            this.cnlBtn.Text = "Cancel";
            this.cnlBtn.UseVisualStyleBackColor = true;
            this.cnlBtn.Click += new System.EventHandler(this.cnlBtn_Click);
            // 
            // dialogOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 213);
            this.ControlBox = false;
            this.Controls.Add(this.cnlBtn);
            this.Controls.Add(this.opnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxDialog);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dialogOpen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Flash Cards";
            this.Load += new System.EventHandler(this.dialogOpen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opnBtn;
        private System.Windows.Forms.Button cnlBtn;
    }
}