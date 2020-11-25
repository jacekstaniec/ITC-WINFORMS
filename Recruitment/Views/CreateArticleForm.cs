using Recruitment.Models;
using System;
using System.Windows.Forms;

namespace Recruitment.Views
{
    public partial class CreateArticleForm : Form
    {
        private int _headerId = 0;
        private int _articleId = 0;

        public CreateArticleForm(int headerId)
        {
            InitializeComponent();
            InitializeForm(headerId);
        }

        public CreateArticleForm(ArticleModel model)
        {
            InitializeComponent();
            InitializeForm(model);
        }

        private void InitializeForm(int headerId)
        {
           _headerId = headerId;
            HeaderIdValue.Text = _headerId.ToString();
        }

        private void InitializeForm(ArticleModel article)
        {
            _headerId = article.HeaderId;
            _articleId = article.Id;
            HeaderIdValue.Text = article.HeaderId.ToString();
            ArticleNameValue.Text = article.ArticleName;
            QuantityValue.Text = article.Quantity.ToString();
            NetValue.Text = article.Net.ToString();

            AddArticleButton.Visible = false;
            UpdateArticleButton.Visible = true;
            AddUpdateArticleLabel.Text = "Update Article";
        }

        private void AddNewArticleButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ArticleModel model = new ArticleModel(
                    int.Parse(HeaderIdValue.Text),
                    ArticleNameValue.Text,
                    int.Parse(QuantityValue.Text),
                    float.Parse(NetValue.Text));

                GlobalConfig.Connection.CreateArticle(model);
                GlobalConfig.NewArticle = model;
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

        private void UpdateArticleButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ArticleModel model = new ArticleModel(
                    int.Parse(HeaderIdValue.Text),
                    ArticleNameValue.Text,
                    int.Parse(QuantityValue.Text),
                    float.Parse(NetValue.Text));
                model.Id = _articleId;
                GlobalConfig.Connection.UpdateArticle(model);
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }


        }
    }
}
