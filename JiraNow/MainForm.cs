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
            Init();
        }

        JiraService jiraService;
        Settings settings;

        void Init()
        {
            LoadSettings();
        }

        private void RenewService()
        {
            jiraService = new JiraService(settings);
        }

        private async void buttonFromFetch_Click(object sender, EventArgs e)
        {
            RenewService();
            string sourceID = textBoxFromId.Text;
            JiraIssue1 issue = await jiraService.GetIssue(sourceID, true);
            textBoxFromPreview.Text = GetIssueDisplayString(issue, true);
        }

        private async void buttonToFetch_Click(object sender, EventArgs e)
        {
            RenewService();
            string destID = textBoxToId.Text;
            JiraIssue1 issue = await jiraService.GetIssue(destID, true);
            textBoxToPreview.Text = GetIssueDisplayString(issue, true);
        }

        private string GetIssueDisplayString(JiraIssue1 issue, bool includeChild = false)
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
            JiraIssue1 sourceIssue = await jiraService.GetIssue(sourceID, true);
            textBoxFromPreview.Text = GetIssueDisplayString(sourceIssue, true);

            string destID = textBoxToId.Text;
            JiraIssue1 destIssue = await jiraService.GetIssue(destID, true);
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

        private void buttonSaveApi_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void buttonLoadApi_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        void SaveSettings()
        {
            settings.HostString = textBoxApiHost.Text;
            settings.CookiesString = textBoxCookies.Text;
            SettingsManager.SaveSettings(settings);
        }

        void LoadSettings()
        {
            settings = SettingsManager.LoadSettings();
            textBoxApiHost.Text = settings.HostString;
            textBoxCookies.Text = settings.CookiesString;
        }
    }
}
