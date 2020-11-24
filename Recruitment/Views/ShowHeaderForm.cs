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
            ArticlesListBox.DataSource = null;
            ArticlesListBox.DataSource = availableArticles;
            ArticlesListBox.DisplayMember = "IdArticleName";
        }

        private void AddNewArticleButton_Click(object sender, EventArgs e)
        {
                var frm = new CreateArticleForm();
                frm.ShowDialog(this);
                availableArticles.Add(GlobalConfig.NewArticle);
                WireUpArticlesListBox();
        }

        void ArticlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedArticle = (ArticleModel)ArticlesListBox.SelectedItem;
        }

    }
}
