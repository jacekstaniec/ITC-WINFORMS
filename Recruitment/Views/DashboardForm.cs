using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Recruitment.Views
{
    public partial class DashboardForm : Form
    {
        private readonly List<HeaderModel> availableHeaders = GlobalConfig.Connection.GetAllHeaders();
        private HeaderModel selectedHeader;

        public DashboardForm()
        {
            InitializeComponent();
            WireUpHeadersListBox();
        }

        private void WireUpHeadersListBox()
        {
            HeadersListBox.DataSource = null;
            HeadersListBox.DataSource = availableHeaders;
            HeadersListBox.DisplayMember = "HeaderName";
        }

        void HeadersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHeader = (HeaderModel)HeadersListBox.SelectedItem;
        }

        void AddNewHeaderButton_Click(object sender, EventArgs e)
        {
            var frm = new CreateHeaderForm();
            frm.ShowDialog(this);
            availableHeaders.Add(GlobalConfig.NewHeader);
            WireUpHeadersListBox();
        }

        void ShowHeaderButton_Click(object sender, EventArgs e)
        {
            if (selectedHeader != null)
            {
                var frm = new ShowHeaderForm(selectedHeader);
                frm.ShowDialog(this);
                WireUpHeadersListBox();
            }
            else
            {
                MessageBox.Show("Select Header");
            }
        }

        void DeleteHeaderButton_Click(object sender, EventArgs e)
        {
            if (selectedHeader != null)
            {
                GlobalConfig.Connection.DeteleHeader(selectedHeader.Id);
                availableHeaders.Remove(selectedHeader);
                WireUpHeadersListBox();
            }
            else
            {
                MessageBox.Show("Select Header");
            }
        }

        private void UpdateHeaderButton_Click(object sender, EventArgs e)
        {
            if (selectedHeader != null)
            {
                var frm = new CreateHeaderForm(selectedHeader);
                frm.ShowDialog(this);
                availableHeaders.Remove(selectedHeader);
                availableHeaders.Add(GlobalConfig.NewHeader);
                WireUpHeadersListBox();
            }
            else
            {
                MessageBox.Show("Select Header");
            }
        }
    }
}
