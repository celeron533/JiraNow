using JiraNow.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            Assembly CurrentAssembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(CurrentAssembly.Location);
            this.Text += " v" + fileVersionInfo.FileVersion.ToString();
            LoadSettings();
            LoadHistory();
        }

        private void RenewService()
        {
            jiraService = new JiraService(settings);
        }

        private async void buttonFetchSourceIssue_Click(object sender, EventArgs e)
        {
            await FetchSource();
        }

        async Task<JiraIssue> FetchSource()
        {
            RenewService();
            string sourceID = textBoxSourceIssueKey.Text;
            textBoxPreviewSourceIssue.Text = "Loading";
            groupBoxSource.Enabled = false;
            JiraIssue issue = await jiraService.GetIssue(sourceID, true);
            groupBoxSource.Enabled = true;
            textBoxPreviewSourceIssue.Text = GetIssueDisplayString(issue, true);
            return issue;
        }

        private async void buttonFetchDestIssue_Click(object sender, EventArgs e)
        {
            await FetchDest();
        }

        async Task<JiraIssue> FetchDest()
        {
            RenewService();
            string destID = textBoxDestIssueKey.Text;
            textBoxPreviewDestIssue.Text = "Loading";
            groupBoxDest.Enabled = false;
            JiraIssue issue = await jiraService.GetIssue(destID, true);
            groupBoxDest.Enabled = true;
            textBoxPreviewDestIssue.Text = GetIssueDisplayString(issue, true);
            return issue;
        }

        private string GetIssueDisplayString(JiraIssue issue, bool includeChild = false)
        {
            if (issue == null || issue.Id == null) return null;

            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(issue.ErrorMessage))
            {
                return issue.ErrorMessage;
            }
            sb.AppendLine($"KEY:{issue.Key}, ID: {issue.Id}")
                .AppendLine($"PROJECT: {issue.Fields.Project.Id}, {issue.Fields.Project.Name}")
                .AppendLine($"TYPE: {issue.Fields.Issuetype.Id}, {issue.Fields.Issuetype.Name}")
                .AppendLine($"Summary: {issue.Fields.Summary}");
            
            //.AppendLine($"Description: {issue.Description}");
            if (includeChild)
            {
                sb.AppendLine($"====== Sub issues ({issue.ChildIssues?.Count}) ======");
                if (issue.ChildIssues != null)
                {
                    foreach (var child in issue.ChildIssues)
                    {
                        if (!string.IsNullOrEmpty(child.ErrorMessage))
                        {
                            sb.AppendLine(child.ErrorMessage);
                        }
                        else
                        {
                            sb.AppendLine($"> KEY:{child.Key}, ID: {child.Id}")
                            .AppendLine($"  PROJECT: {child.Fields.Project.Id}, {child.Fields.Project.Name}")
                            .AppendLine($"  TYPE: {child.Fields.Issuetype.Id}, {child.Fields.Issuetype.Name}")
                            .AppendLine($"  Summary: {child.Fields.Summary}");
                            //.AppendLine($"  Description: {child.Description}");
                        }
                    }
                }
            }
            return sb.ToString();
        }

        private async void buttonCopy_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var sourceTask = FetchSource();
            var destTask = FetchDest();
            await Task.WhenAll(sourceTask, destTask);

            try
            {
                toolStripStatusLabel1.Text = "copying...";
                await jiraService.CopyChildIssues(sourceTask.Result, destTask.Result);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            toolStripStatusLabel1.Text = "";
            this.Enabled = true;
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

        void SaveHistory()
        {
            settings.SourceIssueKey = textBoxSourceIssueKey.Text;
            settings.DestIssueKey = textBoxDestIssueKey.Text;
            SettingsManager.SaveSettings(settings);
        }

        void LoadSettings()
        {
            settings = SettingsManager.LoadSettings();
            textBoxApiHost.Text = settings.HostString;
            textBoxCookies.Text = settings.CookiesString;
        }

        void LoadHistory()
        {
            settings = SettingsManager.LoadSettings();
            textBoxSourceIssueKey.Text = settings.SourceIssueKey;
            textBoxDestIssueKey.Text = settings.DestIssueKey;
        }

        private void checkBoxShowCookies_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCookies.PasswordChar = ((CheckBox) sender).Checked ? (char)0 : '*';
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveHistory();
        }
    }
}
