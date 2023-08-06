namespace JiraNow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxApiHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCookies = new System.Windows.Forms.TextBox();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPreviewSourceIssue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSourceIssueKey = new System.Windows.Forms.TextBox();
            this.buttonFetchSourceIssue = new System.Windows.Forms.Button();
            this.groupBoxDest = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPreviewDestIssue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDestIssueKey = new System.Windows.Forms.TextBox();
            this.buttonFetchDestIssue = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAPI = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLoadApi = new System.Windows.Forms.Button();
            this.buttonSaveApi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxShowCookies = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxDest.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxAPI.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(236, 17);
            this.toolStripStatusLabel1.Text = "https://github.com/celeron533/JiraNow";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // textBoxApiHost
            // 
            this.textBoxApiHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApiHost.Location = new System.Drawing.Point(3, 4);
            this.textBoxApiHost.Name = "textBoxApiHost";
            this.textBoxApiHost.Size = new System.Drawing.Size(539, 21);
            this.textBoxApiHost.TabIndex = 2;
            this.textBoxApiHost.Text = "https://<your account name>.atlassian.net";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "API Host";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cookies";
            // 
            // textBoxCookies
            // 
            this.textBoxCookies.Location = new System.Drawing.Point(3, 3);
            this.textBoxCookies.Multiline = true;
            this.textBoxCookies.Name = "textBoxCookies";
            this.textBoxCookies.PasswordChar = '*';
            this.textBoxCookies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCookies.Size = new System.Drawing.Size(551, 31);
            this.textBoxCookies.TabIndex = 5;
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSource.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(337, 281);
            this.groupBoxSource.TabIndex = 6;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Source Issue";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxPreviewSourceIssue, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 261);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // textBoxPreviewSourceIssue
            // 
            this.textBoxPreviewSourceIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPreviewSourceIssue.Location = new System.Drawing.Point(3, 46);
            this.textBoxPreviewSourceIssue.Multiline = true;
            this.textBoxPreviewSourceIssue.Name = "textBoxPreviewSourceIssue";
            this.textBoxPreviewSourceIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreviewSourceIssue.Size = new System.Drawing.Size(325, 212);
            this.textBoxPreviewSourceIssue.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.textBoxSourceIssueKey, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonFetchSourceIssue, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(325, 37);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // textBoxSourceIssueKey
            // 
            this.textBoxSourceIssueKey.Location = new System.Drawing.Point(3, 3);
            this.textBoxSourceIssueKey.Name = "textBoxSourceIssueKey";
            this.textBoxSourceIssueKey.Size = new System.Drawing.Size(124, 21);
            this.textBoxSourceIssueKey.TabIndex = 6;
            // 
            // buttonFetchSourceIssue
            // 
            this.buttonFetchSourceIssue.Location = new System.Drawing.Point(247, 3);
            this.buttonFetchSourceIssue.Name = "buttonFetchSourceIssue";
            this.buttonFetchSourceIssue.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchSourceIssue.TabIndex = 7;
            this.buttonFetchSourceIssue.Text = "Fetch";
            this.buttonFetchSourceIssue.UseVisualStyleBackColor = true;
            this.buttonFetchSourceIssue.Click += new System.EventHandler(this.buttonFetchSourceIssue_Click);
            // 
            // groupBoxDest
            // 
            this.groupBoxDest.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDest.Location = new System.Drawing.Point(422, 3);
            this.groupBoxDest.Name = "groupBoxDest";
            this.groupBoxDest.Size = new System.Drawing.Size(337, 281);
            this.groupBoxDest.TabIndex = 7;
            this.groupBoxDest.TabStop = false;
            this.groupBoxDest.Text = "Destination Issue";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxPreviewDestIssue, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(331, 261);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // textBoxPreviewDestIssue
            // 
            this.textBoxPreviewDestIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPreviewDestIssue.Location = new System.Drawing.Point(3, 46);
            this.textBoxPreviewDestIssue.Multiline = true;
            this.textBoxPreviewDestIssue.Name = "textBoxPreviewDestIssue";
            this.textBoxPreviewDestIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreviewDestIssue.Size = new System.Drawing.Size(325, 212);
            this.textBoxPreviewDestIssue.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.textBoxDestIssueKey, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonFetchDestIssue, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(325, 37);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // textBoxDestIssueKey
            // 
            this.textBoxDestIssueKey.Location = new System.Drawing.Point(3, 3);
            this.textBoxDestIssueKey.Name = "textBoxDestIssueKey";
            this.textBoxDestIssueKey.Size = new System.Drawing.Size(124, 21);
            this.textBoxDestIssueKey.TabIndex = 7;
            // 
            // buttonFetchDestIssue
            // 
            this.buttonFetchDestIssue.Location = new System.Drawing.Point(247, 3);
            this.buttonFetchDestIssue.Name = "buttonFetchDestIssue";
            this.buttonFetchDestIssue.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchDestIssue.TabIndex = 8;
            this.buttonFetchDestIssue.Text = "Fetch";
            this.buttonFetchDestIssue.UseVisualStyleBackColor = true;
            this.buttonFetchDestIssue.Click += new System.EventHandler(this.buttonFetchDestIssue_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopy.Location = new System.Drawing.Point(346, 132);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(70, 23);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy >>";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "/rest/api/3";
            // 
            // groupBoxAPI
            // 
            this.groupBoxAPI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxAPI.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxAPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAPI.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAPI.Name = "groupBoxAPI";
            this.groupBoxAPI.Size = new System.Drawing.Size(762, 90);
            this.groupBoxAPI.TabIndex = 11;
            this.groupBoxAPI.TabStop = false;
            this.groupBoxAPI.Text = "API";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoadApi, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSaveApi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 70);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // buttonLoadApi
            // 
            this.buttonLoadApi.Location = new System.Drawing.Point(678, 32);
            this.buttonLoadApi.Name = "buttonLoadApi";
            this.buttonLoadApi.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadApi.TabIndex = 12;
            this.buttonLoadApi.Text = "Load";
            this.buttonLoadApi.UseVisualStyleBackColor = true;
            this.buttonLoadApi.Click += new System.EventHandler(this.buttonLoadApi_Click);
            // 
            // buttonSaveApi
            // 
            this.buttonSaveApi.Location = new System.Drawing.Point(678, 3);
            this.buttonSaveApi.Name = "buttonSaveApi";
            this.buttonSaveApi.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveApi.TabIndex = 11;
            this.buttonSaveApi.Text = "Save";
            this.buttonSaveApi.UseVisualStyleBackColor = true;
            this.buttonSaveApi.Click += new System.EventHandler(this.buttonSaveApi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.textBoxApiHost, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(59, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 29);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.checkBoxShowCookies, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBoxCookies, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(59, 29);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(616, 37);
            this.tableLayoutPanel9.TabIndex = 14;
            // 
            // checkBoxShowCookies
            // 
            this.checkBoxShowCookies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxShowCookies.AutoSize = true;
            this.checkBoxShowCookies.Location = new System.Drawing.Point(565, 10);
            this.checkBoxShowCookies.Name = "checkBoxShowCookies";
            this.checkBoxShowCookies.Size = new System.Drawing.Size(48, 16);
            this.checkBoxShowCookies.TabIndex = 0;
            this.checkBoxShowCookies.Text = "show";
            this.checkBoxShowCookies.UseVisualStyleBackColor = true;
            this.checkBoxShowCookies.CheckedChanged += new System.EventHandler(this.checkBoxShowCookies_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.groupBoxAPI, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(768, 389);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.groupBoxSource, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBoxDest, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonCopy, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(762, 287);
            this.tableLayoutPanel8.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 436);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "JiraNow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSource.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBoxDest.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBoxAPI.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxApiHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCookies;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.GroupBox groupBoxDest;
        private System.Windows.Forms.Button buttonFetchSourceIssue;
        private System.Windows.Forms.TextBox textBoxSourceIssueKey;
        private System.Windows.Forms.Button buttonFetchDestIssue;
        private System.Windows.Forms.TextBox textBoxDestIssueKey;
        private System.Windows.Forms.TextBox textBoxPreviewSourceIssue;
        private System.Windows.Forms.TextBox textBoxPreviewDestIssue;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxAPI;
        private System.Windows.Forms.Button buttonLoadApi;
        private System.Windows.Forms.Button buttonSaveApi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.CheckBox checkBoxShowCookies;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

