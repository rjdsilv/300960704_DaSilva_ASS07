﻿namespace _300960704_DaSilva_ASS07
{
    partial class DownloadForm
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
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DownloadPagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(12, 36);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusTextBox.Size = new System.Drawing.Size(716, 273);
            this.StatusTextBox.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(137, 15);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Pages download status:";
            // 
            // DownloadPagesButton
            // 
            this.DownloadPagesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DownloadPagesButton.AutoSize = true;
            this.DownloadPagesButton.Location = new System.Drawing.Point(313, 319);
            this.DownloadPagesButton.Name = "DownloadPagesButton";
            this.DownloadPagesButton.Size = new System.Drawing.Size(111, 25);
            this.DownloadPagesButton.TabIndex = 4;
            this.DownloadPagesButton.Text = "Download Pages";
            this.DownloadPagesButton.UseVisualStyleBackColor = true;
            this.DownloadPagesButton.Click += new System.EventHandler(this.DownloadPagesButton_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 352);
            this.Controls.Add(this.DownloadPagesButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusTextBox);
            this.Name = "DownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Pages Application.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button DownloadPagesButton;
    }
}

