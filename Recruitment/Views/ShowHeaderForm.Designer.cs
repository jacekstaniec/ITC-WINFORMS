
namespace Recruitment.Views
{
    partial class ShowHeaderForm
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdValue = new System.Windows.Forms.TextBox();
            this.HeaderNameLabel = new System.Windows.Forms.Label();
            this.HeaderNameValue = new System.Windows.Forms.TextBox();
            this.AddNewArticleButton = new System.Windows.Forms.Button();
            this.DatePickerValue = new System.Windows.Forms.DateTimePicker();
            this.ArticlesListBox = new System.Windows.Forms.ListBox();
            this.DeleteArticleButton = new System.Windows.Forms.Button();
            this.UpdateArticleButton = new System.Windows.Forms.Button();
            this.NetValue = new System.Windows.Forms.TextBox();
            this.NetLabel = new System.Windows.Forms.Label();
            this.ArticleNetValue = new System.Windows.Forms.TextBox();
            this.ArticleNetLabel = new System.Windows.Forms.Label();
            this.ArticleGrossLabel = new System.Windows.Forms.Label();
            this.ArticleGrossValue = new System.Windows.Forms.TextBox();
            this.ArticleQuantityLabel = new System.Windows.Forms.Label();
            this.ArticleQuantityValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(459, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(239, 9);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerIdLabel.TabIndex = 3;
            this.CustomerIdLabel.Text = "Customer Id";
            // 
            // CustomerIdValue
            // 
            this.CustomerIdValue.Enabled = false;
            this.CustomerIdValue.Location = new System.Drawing.Point(242, 27);
            this.CustomerIdValue.Name = "CustomerIdValue";
            this.CustomerIdValue.ReadOnly = true;
            this.CustomerIdValue.Size = new System.Drawing.Size(200, 20);
            this.CustomerIdValue.TabIndex = 2;
            // 
            // HeaderNameLabel
            // 
            this.HeaderNameLabel.AutoSize = true;
            this.HeaderNameLabel.Location = new System.Drawing.Point(24, 9);
            this.HeaderNameLabel.Name = "HeaderNameLabel";
            this.HeaderNameLabel.Size = new System.Drawing.Size(73, 13);
            this.HeaderNameLabel.TabIndex = 5;
            this.HeaderNameLabel.Text = "Header Name";
            // 
            // HeaderNameValue
            // 
            this.HeaderNameValue.Enabled = false;
            this.HeaderNameValue.Location = new System.Drawing.Point(27, 27);
            this.HeaderNameValue.Name = "HeaderNameValue";
            this.HeaderNameValue.ReadOnly = true;
            this.HeaderNameValue.Size = new System.Drawing.Size(200, 20);
            this.HeaderNameValue.TabIndex = 4;
            // 
            // AddNewArticleButton
            // 
            this.AddNewArticleButton.Location = new System.Drawing.Point(624, 292);
            this.AddNewArticleButton.Name = "AddNewArticleButton";
            this.AddNewArticleButton.Size = new System.Drawing.Size(116, 23);
            this.AddNewArticleButton.TabIndex = 6;
            this.AddNewArticleButton.Text = "Add new Article";
            this.AddNewArticleButton.UseVisualStyleBackColor = true;
            this.AddNewArticleButton.Click += new System.EventHandler(this.AddNewArticleButton_Click);
            // 
            // DatePickerValue
            // 
            this.DatePickerValue.Enabled = false;
            this.DatePickerValue.Location = new System.Drawing.Point(462, 24);
            this.DatePickerValue.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DatePickerValue.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DatePickerValue.Name = "DatePickerValue";
            this.DatePickerValue.Size = new System.Drawing.Size(165, 20);
            this.DatePickerValue.TabIndex = 7;
            // 
            // ArticlesListBox
            // 
            this.ArticlesListBox.FormattingEnabled = true;
            this.ArticlesListBox.Location = new System.Drawing.Point(27, 64);
            this.ArticlesListBox.Name = "ArticlesListBox";
            this.ArticlesListBox.Size = new System.Drawing.Size(591, 251);
            this.ArticlesListBox.TabIndex = 8;
            this.ArticlesListBox.SelectedIndexChanged += new System.EventHandler(this.ArticlesListBox_SelectedIndexChanged);
            // 
            // DeleteArticleButton
            // 
            this.DeleteArticleButton.Location = new System.Drawing.Point(624, 66);
            this.DeleteArticleButton.Name = "DeleteArticleButton";
            this.DeleteArticleButton.Size = new System.Drawing.Size(116, 23);
            this.DeleteArticleButton.TabIndex = 9;
            this.DeleteArticleButton.Text = "Delete Article";
            this.DeleteArticleButton.UseVisualStyleBackColor = true;
            this.DeleteArticleButton.Click += new System.EventHandler(this.DeleteArticleButton_Click);
            // 
            // UpdateArticleButton
            // 
            this.UpdateArticleButton.Location = new System.Drawing.Point(624, 95);
            this.UpdateArticleButton.Name = "UpdateArticleButton";
            this.UpdateArticleButton.Size = new System.Drawing.Size(116, 23);
            this.UpdateArticleButton.TabIndex = 10;
            this.UpdateArticleButton.Text = "Update Article";
            this.UpdateArticleButton.UseVisualStyleBackColor = true;
            this.UpdateArticleButton.Click += new System.EventHandler(this.UpdateArticleButton_Click);
            // 
            // NetValue
            // 
            this.NetValue.Enabled = false;
            this.NetValue.Location = new System.Drawing.Point(650, 24);
            this.NetValue.Name = "NetValue";
            this.NetValue.ReadOnly = true;
            this.NetValue.Size = new System.Drawing.Size(74, 20);
            this.NetValue.TabIndex = 12;
            // 
            // NetLabel
            // 
            this.NetLabel.AutoSize = true;
            this.NetLabel.Location = new System.Drawing.Point(647, 8);
            this.NetLabel.Name = "NetLabel";
            this.NetLabel.Size = new System.Drawing.Size(24, 13);
            this.NetLabel.TabIndex = 13;
            this.NetLabel.Text = "Net";
            // 
            // ArticleNetValue
            // 
            this.ArticleNetValue.Enabled = false;
            this.ArticleNetValue.Location = new System.Drawing.Point(666, 175);
            this.ArticleNetValue.Name = "ArticleNetValue";
            this.ArticleNetValue.ReadOnly = true;
            this.ArticleNetValue.Size = new System.Drawing.Size(74, 20);
            this.ArticleNetValue.TabIndex = 14;
            // 
            // ArticleNetLabel
            // 
            this.ArticleNetLabel.AutoSize = true;
            this.ArticleNetLabel.Location = new System.Drawing.Point(622, 175);
            this.ArticleNetLabel.Name = "ArticleNetLabel";
            this.ArticleNetLabel.Size = new System.Drawing.Size(24, 13);
            this.ArticleNetLabel.TabIndex = 15;
            this.ArticleNetLabel.Text = "Net";
            // 
            // ArticleGrossLabel
            // 
            this.ArticleGrossLabel.AutoSize = true;
            this.ArticleGrossLabel.Location = new System.Drawing.Point(622, 201);
            this.ArticleGrossLabel.Name = "ArticleGrossLabel";
            this.ArticleGrossLabel.Size = new System.Drawing.Size(34, 13);
            this.ArticleGrossLabel.TabIndex = 17;
            this.ArticleGrossLabel.Text = "Gross";
            // 
            // ArticleGrossValue
            // 
            this.ArticleGrossValue.Enabled = false;
            this.ArticleGrossValue.Location = new System.Drawing.Point(666, 201);
            this.ArticleGrossValue.Name = "ArticleGrossValue";
            this.ArticleGrossValue.ReadOnly = true;
            this.ArticleGrossValue.Size = new System.Drawing.Size(74, 20);
            this.ArticleGrossValue.TabIndex = 16;
            // 
            // ArticleQuantityLabel
            // 
            this.ArticleQuantityLabel.AutoSize = true;
            this.ArticleQuantityLabel.Location = new System.Drawing.Point(622, 149);
            this.ArticleQuantityLabel.Name = "ArticleQuantityLabel";
            this.ArticleQuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.ArticleQuantityLabel.TabIndex = 21;
            this.ArticleQuantityLabel.Text = "Quantity";
            // 
            // ArticleQuantityValue
            // 
            this.ArticleQuantityValue.Enabled = false;
            this.ArticleQuantityValue.Location = new System.Drawing.Point(666, 149);
            this.ArticleQuantityValue.Name = "ArticleQuantityValue";
            this.ArticleQuantityValue.ReadOnly = true;
            this.ArticleQuantityValue.Size = new System.Drawing.Size(74, 20);
            this.ArticleQuantityValue.TabIndex = 20;
            // 
            // ShowHeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 350);
            this.Controls.Add(this.ArticleQuantityLabel);
            this.Controls.Add(this.ArticleQuantityValue);
            this.Controls.Add(this.ArticleGrossLabel);
            this.Controls.Add(this.ArticleGrossValue);
            this.Controls.Add(this.ArticleNetLabel);
            this.Controls.Add(this.ArticleNetValue);
            this.Controls.Add(this.NetLabel);
            this.Controls.Add(this.NetValue);
            this.Controls.Add(this.UpdateArticleButton);
            this.Controls.Add(this.DeleteArticleButton);
            this.Controls.Add(this.ArticlesListBox);
            this.Controls.Add(this.DatePickerValue);
            this.Controls.Add(this.AddNewArticleButton);
            this.Controls.Add(this.HeaderNameLabel);
            this.Controls.Add(this.HeaderNameValue);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.CustomerIdValue);
            this.Controls.Add(this.DateLabel);
            this.Name = "ShowHeaderForm";
            this.Text = "Show Header";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.TextBox CustomerIdValue;
        private System.Windows.Forms.Label HeaderNameLabel;
        private System.Windows.Forms.TextBox HeaderNameValue;
        private System.Windows.Forms.Button AddNewArticleButton;
        private System.Windows.Forms.DateTimePicker DatePickerValue;
        private System.Windows.Forms.ListBox ArticlesListBox;
        private System.Windows.Forms.Button DeleteArticleButton;
        private System.Windows.Forms.Button UpdateArticleButton;
        private System.Windows.Forms.TextBox NetValue;
        private System.Windows.Forms.Label NetLabel;
        private System.Windows.Forms.TextBox ArticleNetValue;
        private System.Windows.Forms.Label ArticleNetLabel;
        private System.Windows.Forms.Label ArticleGrossLabel;
        private System.Windows.Forms.TextBox ArticleGrossValue;
        private System.Windows.Forms.Label ArticleQuantityLabel;
        private System.Windows.Forms.TextBox ArticleQuantityValue;
    }
}