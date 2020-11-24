using Recruitment.Models;
using System;
using System.Windows.Forms;

namespace Recruitment.Views
{
    public partial class CreateArticleForm : Form
    {
        public CreateArticleForm()
        {
            InitializeComponent();
        }

        private void AddArticleButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ArticleModel model = new ArticleModel(
                    int.Parse(HeaderIdValue.Text),
                    ArticleNameValue.Text,
                    int.Parse(QuantityValue.Text),
                    float.Parse(NetValue.Text));

                GlobalConfig.Connection.CreateArticle(model);

                HeaderIdValue.Text = "";
                ArticleNameValue.Text = "";
                QuantityValue.Text = "";
                NetValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            bool headerIdValid = int.TryParse(HeaderIdValue.Text, out int headerId);
            if (!headerIdValid) { output = false; }
            if (headerId < 1) { output = false; }

            bool quantityValid = int.TryParse(QuantityValue.Text, out int quantity);
            if (!quantityValid) { output = false; }
            if (quantity < 1) { output = false; }

            bool netValid = float.TryParse(NetValue.Text, out float net);
            if (!netValid) { output = false; }
            if (net <= 0) { output = false; }

            if (ArticleNameValue.Text == "") { output = false; }

            return output;
        }
    }
}
