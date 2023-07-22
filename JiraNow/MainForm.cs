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

        private async void buttonFromFetch_Click(object sender, EventArgs e)
        {
            string baseUri = textBoxApi.Text;
            string cookies = textBoxCookies.Text;
            string fromId = textBoxFromId.Text;
            JiraApi api = new JiraApi(baseUri, cookies);
            JiraMessage message = await api.GetIssueByIdAsync(fromId);
            textBoxFromPreview.Text = message.jsonMessage;
            JiraIssue.Parse(message.jsonMessage);

            JiraMessage message2 = await api.SearchIssue("parent=SAM-1");
            var aa = JiraSearchResult.Parse(message2.jsonMessage);
        }
    }
}
