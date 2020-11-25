
namespace Recruitment.Views
{
    partial class CreateHeaderForm
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
            this.AddHeaderButton = new System.Windows.Forms.Button();
            this.DatePickerValue = new System.Windows.Forms.DateTimePicker();
            this.AddUpdateHeaderLabel = new System.Windows.Forms.Label();
            this.UpdateHeaderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(92, 63);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(59, 107);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerIdLabel.TabIndex = 3;
            this.CustomerIdLabel.Text = "Customer Id";
            // 
            // CustomerIdValue
            // 
            this.CustomerIdValue.Location = new System.Drawing.Point(137, 104);
            this.CustomerIdValue.Name = "CustomerIdValue";
            this.CustomerIdValue.Size = new System.Drawing.Size(200, 20);
            this.CustomerIdValue.TabIndex = 2;
            // 
            // HeaderNameLabel
            // 
            this.HeaderNameLabel.AutoSize = true;
            this.HeaderNameLabel.Location = new System.Drawing.Point(59, 154);
            this.HeaderNameLabel.Name = "HeaderNameLabel";
            this.HeaderNameLabel.Size = new System.Drawing.Size(73, 13);
            this.HeaderNameLabel.TabIndex = 5;
            this.HeaderNameLabel.Text = "Header Name";
            // 
            // HeaderNameValue
            // 
            this.HeaderNameValue.Location = new System.Drawing.Point(137, 151);
            this.HeaderNameValue.Name = "HeaderNameValue";
            this.HeaderNameValue.Size = new System.Drawing.Size(200, 20);
            this.HeaderNameValue.TabIndex = 4;
            // 
            // AddHeaderButton
            // 
            this.AddHeaderButton.Location = new System.Drawing.Point(221, 200);
            this.AddHeaderButton.Name = "AddHeaderButton";
            this.AddHeaderButton.Size = new System.Drawing.Size(116, 23);
            this.AddHeaderButton.TabIndex = 0;
            this.AddHeaderButton.Text = "Add";
            this.AddHeaderButton.UseVisualStyleBackColor = true;
            this.AddHeaderButton.Click += new System.EventHandler(this.AddHeaderButton_Click);
            // 
            // DatePickerValue
            // 
            this.DatePickerValue.Location = new System.Drawing.Point(137, 63);
            this.DatePickerValue.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DatePickerValue.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DatePickerValue.Name = "DatePickerValue";
            this.DatePickerValue.Size = new System.Drawing.Size(200, 20);
            this.DatePickerValue.TabIndex = 7;
            // 
            // AddUpdateHeaderLabel
            // 
            this.AddUpdateHeaderLabel.AutoSize = true;
            this.AddUpdateHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddUpdateHeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddUpdateHeaderLabel.Location = new System.Drawing.Point(32, 22);
            this.AddUpdateHeaderLabel.Name = "AddUpdateHeaderLabel";
            this.AddUpdateHeaderLabel.Size = new System.Drawing.Size(125, 17);
            this.AddUpdateHeaderLabel.TabIndex = 9;
            this.AddUpdateHeaderLabel.Text = "Add new header";
            // 
            // UpdateHeaderButton
            // 
            this.UpdateHeaderButton.Location = new System.Drawing.Point(99, 200);
            this.UpdateHeaderButton.Name = "UpdateHeaderButton";
            this.UpdateHeaderButton.Size = new System.Drawing.Size(116, 23);
            this.UpdateHeaderButton.TabIndex = 0;
            this.UpdateHeaderButton.Text = "Update";
            this.UpdateHeaderButton.UseVisualStyleBackColor = true;
            this.UpdateHeaderButton.Visible = false;
            this.UpdateHeaderButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateHeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.UpdateHeaderButton);
            this.Controls.Add(this.AddUpdateHeaderLabel);
            this.Controls.Add(this.DatePickerValue);
            this.Controls.Add(this.AddHeaderButton);
            this.Controls.Add(this.HeaderNameLabel);
            this.Controls.Add(this.HeaderNameValue);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.CustomerIdValue);
            this.Controls.Add(this.DateLabel);
            this.Name = "CreateHeaderForm";
            this.Text = "Create Header";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.TextBox CustomerIdValue;
        private System.Windows.Forms.Label HeaderNameLabel;
        private System.Windows.Forms.TextBox HeaderNameValue;
        private System.Windows.Forms.Button AddHeaderButton;
        private System.Windows.Forms.DateTimePicker DatePickerValue;
        private System.Windows.Forms.Label AddUpdateHeaderLabel;
        private System.Windows.Forms.Button UpdateHeaderButton;
    }
}