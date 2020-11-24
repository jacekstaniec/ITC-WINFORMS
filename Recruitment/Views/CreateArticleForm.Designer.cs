
namespace Recruitment.Views
{
    partial class CreateArticleForm
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
            this.NetLabel = new System.Windows.Forms.Label();
            this.NetValue = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HeaderIdValue = new System.Windows.Forms.TextBox();
            this.AddArticleButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityValue = new System.Windows.Forms.TextBox();
            this.ArticleNameLabel = new System.Windows.Forms.Label();
            this.ArticleNameValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NetLabel
            // 
            this.NetLabel.AutoSize = true;
            this.NetLabel.Location = new System.Drawing.Point(60, 192);
            this.NetLabel.Name = "NetLabel";
            this.NetLabel.Size = new System.Drawing.Size(24, 13);
            this.NetLabel.TabIndex = 26;
            this.NetLabel.Text = "Net";
            // 
            // NetValue
            // 
            this.NetValue.Location = new System.Drawing.Point(138, 189);
            this.NetValue.Name = "NetValue";
            this.NetValue.Size = new System.Drawing.Size(200, 20);
            this.NetValue.TabIndex = 25;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(60, 40);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(54, 13);
            this.HeaderLabel.TabIndex = 24;
            this.HeaderLabel.Text = "Header Id";
            // 
            // HeaderIdValue
            // 
            this.HeaderIdValue.Location = new System.Drawing.Point(138, 37);
            this.HeaderIdValue.Name = "HeaderIdValue";
            this.HeaderIdValue.Size = new System.Drawing.Size(200, 20);
            this.HeaderIdValue.TabIndex = 23;
            // 
            // AddArticleButton
            // 
            this.AddArticleButton.Location = new System.Drawing.Point(222, 259);
            this.AddArticleButton.Name = "AddArticleButton";
            this.AddArticleButton.Size = new System.Drawing.Size(116, 23);
            this.AddArticleButton.TabIndex = 22;
            this.AddArticleButton.Text = "Add Article";
            this.AddArticleButton.UseVisualStyleBackColor = true;
            this.AddArticleButton.Click += new System.EventHandler(this.AddArticleButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(60, 142);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 21;
            this.QuantityLabel.Text = "Quantity";
            // 
            // QuantityValue
            // 
            this.QuantityValue.Location = new System.Drawing.Point(138, 139);
            this.QuantityValue.Name = "QuantityValue";
            this.QuantityValue.Size = new System.Drawing.Size(200, 20);
            this.QuantityValue.TabIndex = 20;
            // 
            // ArticleNameLabel
            // 
            this.ArticleNameLabel.AutoSize = true;
            this.ArticleNameLabel.Location = new System.Drawing.Point(60, 95);
            this.ArticleNameLabel.Name = "ArticleNameLabel";
            this.ArticleNameLabel.Size = new System.Drawing.Size(67, 13);
            this.ArticleNameLabel.TabIndex = 19;
            this.ArticleNameLabel.Text = "Article Name";
            // 
            // ArticleNameValue
            // 
            this.ArticleNameValue.Location = new System.Drawing.Point(138, 92);
            this.ArticleNameValue.Name = "ArticleNameValue";
            this.ArticleNameValue.Size = new System.Drawing.Size(200, 20);
            this.ArticleNameValue.TabIndex = 18;
            // 
            // CreateArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NetLabel);
            this.Controls.Add(this.NetValue);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.HeaderIdValue);
            this.Controls.Add(this.AddArticleButton);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityValue);
            this.Controls.Add(this.ArticleNameLabel);
            this.Controls.Add(this.ArticleNameValue);
            this.Name = "CreateArticleForm";
            this.Text = "Create Article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NetLabel;
        private System.Windows.Forms.TextBox NetValue;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox HeaderIdValue;
        private System.Windows.Forms.Button AddArticleButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityValue;
        private System.Windows.Forms.Label ArticleNameLabel;
        private System.Windows.Forms.TextBox ArticleNameValue;
    }
}