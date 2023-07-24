using JiraNow.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraNow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        JiraService jiraService;

        private void RenewService()
        {
            string baseUri = textBoxApi.Text;
            string cookies = textBoxCookies.Text;
            jiraService = new JiraService(baseUri, cookies);
        }

        private async void buttonFromFetch_Click(object sender, EventArgs e)
        {
            RenewService();
            string fromId = textBoxFromId.Text;
            JiraIssue issue = await jiraService.GetIssue(fromId, true);
            textBoxFromPreview.Text = GetIssueDisplayString(issue, true);
        }

        private async void buttonToFetch_Click(object sender, EventArgs e)
        {
            RenewService();
            string toId = textBoxToId.Text;
            JiraIssue issue = await jiraService.GetIssue(toId, true);
            textBoxToPreview.Text = GetIssueDisplayString(issue, true);
        }

        private string GetIssueDisplayString(JiraIssue issue, bool includeChild = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"KEY:{issue.Key}, ID: {issue.ID}")
                .AppendLine($"PROJECT: {issue.ProjectID}, {issue.ProjectName}")
                .AppendLine($"TYPE: {issue.IssueTypeID}, {issue.IssueTypeName}")
                .AppendLine($"Summary: {issue.Summary}")
                .AppendLine($"Description: {issue.Description}");
            if (includeChild)
            {
                sb.AppendLine($"====== Sub issues ({issue.ChildIssues.Count}) ======");
                foreach (var child in issue.ChildIssues)
                {
                    sb.AppendLine($"> KEY:{child.Key}, ID: {child.ID}")
                    .AppendLine($"  PROJECT: {child.ProjectID}, {child.ProjectName}")
                    .AppendLine($"  TYPE: {child.IssueTypeID}, {child.IssueTypeName}")
                    .AppendLine($"  Summary: {child.Summary}")
                    .AppendLine($"  Description: {child.Description}");
                }
            }
            return sb.ToString();
        }
    }
}
