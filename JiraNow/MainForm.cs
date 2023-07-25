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
            string sourceID = textBoxFromId.Text;
            JiraIssue issue = await jiraService.GetIssue(sourceID, true);
            textBoxFromPreview.Text = GetIssueDisplayString(issue, true);
        }

        private async void buttonToFetch_Click(object sender, EventArgs e)
        {
            RenewService();
            string destID = textBoxToId.Text;
            JiraIssue issue = await jiraService.GetIssue(destID, true);
            textBoxToPreview.Text = GetIssueDisplayString(issue, true);
        }

        private string GetIssueDisplayString(JiraIssue issue, bool includeChild = false)
        {
            if (issue == null) return null;

            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(issue.ErrorMessage))
            {
                return issue.ErrorMessage;
            }
            sb.AppendLine($"KEY:{issue.Key}, ID: {issue.ID}")
                .AppendLine($"PROJECT: {issue.ProjectID}, {issue.ProjectName}")
                .AppendLine($"TYPE: {issue.IssueTypeID}, {issue.IssueTypeName}")
                .AppendLine($"Summary: {issue.Summary}");
            
            //.AppendLine($"Description: {issue.Description}");
            if (includeChild)
            {
                sb.AppendLine($"====== Sub issues ({issue.ChildIssues.Count}) ======");
                foreach (var child in issue.ChildIssues)
                {
                    if (!string.IsNullOrEmpty(child.ErrorMessage))
                    {
                        sb.AppendLine(child.ErrorMessage);
                    }
                    else
                    {
                        sb.AppendLine($"> KEY:{child.Key}, ID: {child.ID}")
                        .AppendLine($"  PROJECT: {child.ProjectID}, {child.ProjectName}")
                        .AppendLine($"  TYPE: {child.IssueTypeID}, {child.IssueTypeName}")
                        .AppendLine($"  Summary: {child.Summary}");
                        //.AppendLine($"  Description: {child.Description}");
                    }
                }
            }
            return sb.ToString();
        }

        private async void buttonCopy_Click(object sender, EventArgs e)
        {
            RenewService();
            string sourceID = textBoxFromId.Text;
            JiraIssue sourceIssue = await jiraService.GetIssue(sourceID, true);
            textBoxFromPreview.Text = GetIssueDisplayString(sourceIssue, true);

            string destID = textBoxToId.Text;
            JiraIssue destIssue = await jiraService.GetIssue(destID, true);
            textBoxToPreview.Text = GetIssueDisplayString(destIssue, true);

            //validation
            if (!string.IsNullOrEmpty( sourceIssue.ErrorMessage) || !string.IsNullOrEmpty(destIssue.ErrorMessage) ) 
            {
                MessageBox.Show("error when fetch the issue");
                return;
            }

            if (sourceIssue.IssueTypeID != destIssue.IssueTypeID)
            {
                MessageBox.Show("source and destination issue type are different");
                return;
            }

            await jiraService.CopyChildIssues(sourceIssue, destIssue);
        }
    }
}
