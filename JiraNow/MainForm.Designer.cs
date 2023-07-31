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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxApiHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCookies = new System.Windows.Forms.TextBox();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.textBoxFromPreview = new System.Windows.Forms.TextBox();
            this.buttonFromFetch = new System.Windows.Forms.Button();
            this.textBoxFromId = new System.Windows.Forms.TextBox();
            this.groupBoxTo = new System.Windows.Forms.GroupBox();
            this.textBoxToPreview = new System.Windows.Forms.TextBox();
            this.buttonToFetch = new System.Windows.Forms.Button();
            this.textBoxToId = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAPI = new System.Windows.Forms.GroupBox();
            this.buttonLoadApi = new System.Windows.Forms.Button();
            this.buttonSaveApi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.groupBoxTo.SuspendLayout();
            this.groupBoxAPI.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // textBoxApiHost
            // 
            this.textBoxApiHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApiHost.Location = new System.Drawing.Point(3, 5);
            this.textBoxApiHost.Name = "textBoxApiHost";
            this.textBoxApiHost.Size = new System.Drawing.Size(555, 20);
            this.textBoxApiHost.TabIndex = 2;
            this.textBoxApiHost.Text = "https://<your account name>.atlassian.net";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "API Host";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cookies";
            // 
            // textBoxCookies
            // 
            this.textBoxCookies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCookies.Location = new System.Drawing.Point(58, 34);
            this.textBoxCookies.Multiline = true;
            this.textBoxCookies.Name = "textBoxCookies";
            this.textBoxCookies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCookies.Size = new System.Drawing.Size(614, 41);
            this.textBoxCookies.TabIndex = 5;
            this.textBoxCookies.Text = "paste here";
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFrom.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(337, 311);
            this.groupBoxFrom.TabIndex = 6;
            this.groupBoxFrom.TabStop = false;
            this.groupBoxFrom.Text = "From";
            // 
            // textBoxFromPreview
            // 
            this.textBoxFromPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFromPreview.Location = new System.Drawing.Point(3, 49);
            this.textBoxFromPreview.Multiline = true;
            this.textBoxFromPreview.Name = "textBoxFromPreview";
            this.textBoxFromPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFromPreview.Size = new System.Drawing.Size(325, 240);
            this.textBoxFromPreview.TabIndex = 8;
            // 
            // buttonFromFetch
            // 
            this.buttonFromFetch.Location = new System.Drawing.Point(247, 3);
            this.buttonFromFetch.Name = "buttonFromFetch";
            this.buttonFromFetch.Size = new System.Drawing.Size(75, 25);
            this.buttonFromFetch.TabIndex = 7;
            this.buttonFromFetch.Text = "Fetch";
            this.buttonFromFetch.UseVisualStyleBackColor = true;
            this.buttonFromFetch.Click += new System.EventHandler(this.buttonFromFetch_Click);
            // 
            // textBoxFromId
            // 
            this.textBoxFromId.Location = new System.Drawing.Point(3, 3);
            this.textBoxFromId.Name = "textBoxFromId";
            this.textBoxFromId.Size = new System.Drawing.Size(124, 20);
            this.textBoxFromId.TabIndex = 6;
            this.textBoxFromId.Text = "SAM-1";
            // 
            // groupBoxTo
            // 
            this.groupBoxTo.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTo.Location = new System.Drawing.Point(422, 3);
            this.groupBoxTo.Name = "groupBoxTo";
            this.groupBoxTo.Size = new System.Drawing.Size(337, 311);
            this.groupBoxTo.TabIndex = 7;
            this.groupBoxTo.TabStop = false;
            this.groupBoxTo.Text = "To";
            // 
            // textBoxToPreview
            // 
            this.textBoxToPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxToPreview.Location = new System.Drawing.Point(3, 49);
            this.textBoxToPreview.Multiline = true;
            this.textBoxToPreview.Name = "textBoxToPreview";
            this.textBoxToPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxToPreview.Size = new System.Drawing.Size(325, 240);
            this.textBoxToPreview.TabIndex = 9;
            // 
            // buttonToFetch
            // 
            this.buttonToFetch.Location = new System.Drawing.Point(247, 3);
            this.buttonToFetch.Name = "buttonToFetch";
            this.buttonToFetch.Size = new System.Drawing.Size(75, 25);
            this.buttonToFetch.TabIndex = 8;
            this.buttonToFetch.Text = "Fetch";
            this.buttonToFetch.UseVisualStyleBackColor = true;
            this.buttonToFetch.Click += new System.EventHandler(this.buttonToFetch_Click);
            // 
            // textBoxToId
            // 
            this.textBoxToId.Location = new System.Drawing.Point(3, 3);
            this.textBoxToId.Name = "textBoxToId";
            this.textBoxToId.Size = new System.Drawing.Size(124, 20);
            this.textBoxToId.TabIndex = 7;
            this.textBoxToId.Text = "SAM-2";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopy.Location = new System.Drawing.Point(346, 146);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(70, 25);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy >>";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
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
            this.groupBoxAPI.Size = new System.Drawing.Size(762, 97);
            this.groupBoxAPI.TabIndex = 11;
            this.groupBoxAPI.TabStop = false;
            this.groupBoxAPI.Text = "API";
            // 
            // buttonLoadApi
            // 
            this.buttonLoadApi.Location = new System.Drawing.Point(678, 34);
            this.buttonLoadApi.Name = "buttonLoadApi";
            this.buttonLoadApi.Size = new System.Drawing.Size(75, 25);
            this.buttonLoadApi.TabIndex = 12;
            this.buttonLoadApi.Text = "Load";
            this.buttonLoadApi.UseVisualStyleBackColor = true;
            this.buttonLoadApi.Click += new System.EventHandler(this.buttonLoadApi_Click);
            // 
            // buttonSaveApi
            // 
            this.buttonSaveApi.Location = new System.Drawing.Point(678, 3);
            this.buttonSaveApi.Name = "buttonSaveApi";
            this.buttonSaveApi.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveApi.TabIndex = 11;
            this.buttonSaveApi.Text = "Save";
            this.buttonSaveApi.UseVisualStyleBackColor = true;
            this.buttonSaveApi.Click += new System.EventHandler(this.buttonSaveApi_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.textBoxCookies, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 78);
            this.tableLayoutPanel1.TabIndex = 13;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(55, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(620, 31);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxFromPreview, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 292);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxToPreview, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(331, 292);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.textBoxFromId, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonFromFetch, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(325, 40);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.textBoxToId, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonToFetch, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(325, 40);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.groupBoxAPI, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(768, 426);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.groupBoxFrom, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBoxTo, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonCopy, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(762, 317);
            this.tableLayoutPanel8.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 472);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "JiraNow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxTo.ResumeLayout(false);
            this.groupBoxAPI.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.GroupBox groupBoxTo;
        private System.Windows.Forms.Button buttonFromFetch;
        private System.Windows.Forms.TextBox textBoxFromId;
        private System.Windows.Forms.Button buttonToFetch;
        private System.Windows.Forms.TextBox textBoxToId;
        private System.Windows.Forms.TextBox textBoxFromPreview;
        private System.Windows.Forms.TextBox textBoxToPreview;
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
    }
}

