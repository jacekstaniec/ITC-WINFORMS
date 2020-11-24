
namespace Recruitment.Views
{
    partial class DashboardForm
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
            this.AddNewHeaderButton = new System.Windows.Forms.Button();
            this.ShowHeaderButton = new System.Windows.Forms.Button();
            this.HeadersListBox = new System.Windows.Forms.ListBox();
            this.AvailableHeadersLabel = new System.Windows.Forms.Label();
            this.DeleteHeaderButton = new System.Windows.Forms.Button();
            this.UpdateHeaderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewHeaderButton
            // 
            this.AddNewHeaderButton.Location = new System.Drawing.Point(389, 323);
            this.AddNewHeaderButton.Name = "AddNewHeaderButton";
            this.AddNewHeaderButton.Size = new System.Drawing.Size(196, 23);
            this.AddNewHeaderButton.TabIndex = 0;
            this.AddNewHeaderButton.Text = "Add new Header";
            this.AddNewHeaderButton.UseVisualStyleBackColor = true;
            this.AddNewHeaderButton.Click += new System.EventHandler(this.AddNewHeaderButton_Click);
            // 
            // ShowHeaderButton
            // 
            this.ShowHeaderButton.Location = new System.Drawing.Point(389, 56);
            this.ShowHeaderButton.Name = "ShowHeaderButton";
            this.ShowHeaderButton.Size = new System.Drawing.Size(196, 23);
            this.ShowHeaderButton.TabIndex = 1;
            this.ShowHeaderButton.Text = "Show Header Articles";
            this.ShowHeaderButton.UseVisualStyleBackColor = true;
            this.ShowHeaderButton.Click += new System.EventHandler(this.ShowHeaderButton_Click);
            // 
            // HeadersListBox
            // 
            this.HeadersListBox.FormattingEnabled = true;
            this.HeadersListBox.Location = new System.Drawing.Point(12, 56);
            this.HeadersListBox.MultiColumn = true;
            this.HeadersListBox.Name = "HeadersListBox";
            this.HeadersListBox.Size = new System.Drawing.Size(354, 290);
            this.HeadersListBox.TabIndex = 3;
            this.HeadersListBox.SelectedIndexChanged += new System.EventHandler(this.HeadersListBox_SelectedIndexChanged);
            // 
            // AvailableHeadersLabel
            // 
            this.AvailableHeadersLabel.AutoSize = true;
            this.AvailableHeadersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvailableHeadersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AvailableHeadersLabel.Location = new System.Drawing.Point(12, 9);
            this.AvailableHeadersLabel.Name = "AvailableHeadersLabel";
            this.AvailableHeadersLabel.Size = new System.Drawing.Size(138, 17);
            this.AvailableHeadersLabel.TabIndex = 10;
            this.AvailableHeadersLabel.Text = "Available headers";
            // 
            // DeleteHeaderButton
            // 
            this.DeleteHeaderButton.Location = new System.Drawing.Point(389, 85);
            this.DeleteHeaderButton.Name = "DeleteHeaderButton";
            this.DeleteHeaderButton.Size = new System.Drawing.Size(196, 23);
            this.DeleteHeaderButton.TabIndex = 11;
            this.DeleteHeaderButton.Text = "Delete Header";
            this.DeleteHeaderButton.UseVisualStyleBackColor = true;
            this.DeleteHeaderButton.Click += new System.EventHandler(this.DeleteHeaderButton_Click);
            // 
            // UpdateHeaderButton
            // 
            this.UpdateHeaderButton.Location = new System.Drawing.Point(389, 114);
            this.UpdateHeaderButton.Name = "UpdateHeaderButton";
            this.UpdateHeaderButton.Size = new System.Drawing.Size(196, 23);
            this.UpdateHeaderButton.TabIndex = 12;
            this.UpdateHeaderButton.Text = "Update Header";
            this.UpdateHeaderButton.UseVisualStyleBackColor = true;
            this.UpdateHeaderButton.Click += new System.EventHandler(this.UpdateHeaderButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.UpdateHeaderButton);
            this.Controls.Add(this.DeleteHeaderButton);
            this.Controls.Add(this.AvailableHeadersLabel);
            this.Controls.Add(this.HeadersListBox);
            this.Controls.Add(this.ShowHeaderButton);
            this.Controls.Add(this.AddNewHeaderButton);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewHeaderButton;
        private System.Windows.Forms.Button ShowHeaderButton;
        private System.Windows.Forms.ListBox HeadersListBox;
        private System.Windows.Forms.Label AvailableHeadersLabel;
        private System.Windows.Forms.Button DeleteHeaderButton;
        private System.Windows.Forms.Button UpdateHeaderButton;
    }
}