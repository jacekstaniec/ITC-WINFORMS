using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Recruitment.Models;

namespace Recruitment.Views
{
    public partial class ShowHeaderForm : Form
    {
        private int _headerId = 0;

        private List<ArticleModel> availableArticles = new List<ArticleModel>();
        private ArticleModel selectedArticle;

        public ShowHeaderForm(HeaderModel header)
        {
            InitializeComponent();
            InitializeForm(header);
            WireUpArticlesListBox();
        }

        void InitializeForm(HeaderModel header)
        {
            _headerId = header.Id;
            availableArticles = GlobalConfig.Connection.GetAllArticles(header.Id);
            DatePickerValue.Value = header.Date;
            CustomerIdValue.Text = header.CustomerId.ToString();
            HeaderNameValue.Text = header.HeaderName;
        }

        void WireUpArticlesListBox()
        {
            NetValue.Text = GlobalConfig.NewNet.ToString();
            ArticlesListBox.DataSource = null;
            ArticlesListBox.DataSource = availableArticles;
            ArticlesListBox.DisplayMember = "ArticleName";
        }

        private void AddNewArticleButton_Click(object sender, EventArgs e)
        {
            var frm = new CreateArticleForm(_headerId);
                frm.ShowDialog(this);
                availableArticles.Add(GlobalConfig.NewArticle);
                WireUpArticlesListBox();
        }

        private void ArticlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedArticle = (ArticleModel)ArticlesListBox.SelectedItem;
            if (selectedArticle != null)
            {
                ArticleQuantityValue.Text = selectedArticle.Quantity.ToString();
                ArticleNetValue.Text = selectedArticle.Net.ToString();
                ArticleGrossValue.Text = selectedArticle.Gross.ToString();
            }
        }

        private void DeleteArticleButton_Click(object sender, EventArgs e)
        {
            if (selectedArticle != null)
            {
                GlobalConfig.Connection.DeteleArticle(selectedArticle.Id, _headerId);
                availableArticles.Remove(selectedArticle);
                WireUpArticlesListBox();
            }
            else
            {
                MessageBox.Show("Select Article");
            }
        }

        private void UpdateArticleButton_Click(object sender, EventArgs e)
        {
            if (selectedArticle != null)
            {
                var frm = new CreateArticleForm(selectedArticle);
                frm.ShowDialog(this);
                availableArticles.Remove(selectedArticle);
                availableArticles.Add(GlobalConfig.NewArticle);
                WireUpArticlesListBox();
            }
            else
            {
                MessageBox.Show("Select Header");
            }
        }

    }
}
