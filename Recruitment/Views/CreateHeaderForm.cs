using System;
using System.Windows.Forms;
using Recruitment.Models;

namespace Recruitment.Views
{
    public partial class CreateHeaderForm : Form
    {
        private int _headerId = 0;

        public CreateHeaderForm()
        {
            InitializeComponent();
        }

        public CreateHeaderForm(HeaderModel header)
        {
            InitializeComponent();
            InitializeForm(header);
        }

        private void InitializeForm(HeaderModel header)
        {
            _headerId = header.Id;
            DatePickerValue.Value = header.Date;
            CustomerIdValue.Text = header.CustomerId.ToString();
            HeaderNameValue.Text = header.HeaderName;
            AddHeaderButton.Visible = false;
            UpdateHeaderButton.Visible = true;
            AddUpdateHeaderLabel.Text = "Update header";
        }

        private void AddHeaderButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                HeaderModel model = new HeaderModel(
                    (DateTime) DatePickerValue.Value,
                    int.Parse(CustomerIdValue.Text),
                    HeaderNameValue.Text);

                GlobalConfig.Connection.CreateHeader(model);
                GlobalConfig.NewHeader = model;
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                HeaderModel model = new HeaderModel(
                    (DateTime)DatePickerValue.Value,
                    int.Parse(CustomerIdValue.Text),
                    HeaderNameValue.Text);
                model.Id = _headerId;
                GlobalConfig.Connection.UpdateHeader(model);
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            bool datePickerValid = DateTime.TryParse(DatePickerValue.Value.ToString(), out _);
            if (!datePickerValid) { output = false; }

            bool customerIdValid = int.TryParse(CustomerIdValue.Text, out int customerId);
            if (!customerIdValid) { output = false; }
            if (customerId < 1) { output = false; }

            if (HeaderNameValue.Text == "") { output = false; }

            return output;
        }

    }
}
