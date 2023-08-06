namespace SearchablePDF
{
    partial class Form1
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SelectPdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.PageConfidenceListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(662, 33);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(126, 29);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert To OCR";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // SelectPdfFileDialog
            // 
            this.SelectPdfFileDialog.FileName = "file";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(3, 3);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(149, 23);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "Select PDF file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.SelectFileButton);
            this.flowLayoutPanel1.Controls.Add(this.FilePathLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.ForeColor = System.Drawing.Color.Red;
            this.FilePathLabel.Location = new System.Drawing.Point(158, 0);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 29);
            this.FilePathLabel.TabIndex = 2;
            this.FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageConfidenceListBox
            // 
            this.PageConfidenceListBox.FormattingEnabled = true;
            this.PageConfidenceListBox.Location = new System.Drawing.Point(97, 79);
            this.PageConfidenceListBox.Name = "PageConfidenceListBox";
            this.PageConfidenceListBox.Size = new System.Drawing.Size(640, 303);
            this.PageConfidenceListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageConfidenceListBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.OpenFileDialog SelectPdfFileDialog;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.ListBox PageConfidenceListBox;
    }
}

