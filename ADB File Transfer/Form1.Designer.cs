namespace ADB_File_Transfer
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
            this.FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.TransferProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // FileSelector
            // 
            this.FileSelector.FileName = "openFileDialog1";
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(13, 13);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(114, 23);
            this.SelectFileBtn.TabIndex = 0;
            this.SelectFileBtn.Text = "Select File";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(12, 73);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(114, 23);
            this.TransferBtn.TabIndex = 1;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(17, 45);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(0, 12);
            this.FileLabel.TabIndex = 2;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(13, 102);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(628, 179);
            this.OutputTextBox.TabIndex = 3;
            // 
            // TransferProgressBar
            // 
            this.TransferProgressBar.Location = new System.Drawing.Point(132, 73);
            this.TransferProgressBar.Name = "TransferProgressBar";
            this.TransferProgressBar.Size = new System.Drawing.Size(509, 23);
            this.TransferProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.TransferProgressBar.TabIndex = 4;
            this.TransferProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 293);
            this.Controls.Add(this.TransferProgressBar);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.SelectFileBtn);
            this.Name = "Form1";
            this.Text = "ADB File Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileSelector;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.ProgressBar TransferProgressBar;
    }
}

