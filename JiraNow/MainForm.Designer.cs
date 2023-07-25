﻿namespace JiraNow
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
            this.textBoxApi = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.groupBoxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // textBoxApi
            // 
            this.textBoxApi.Location = new System.Drawing.Point(85, 42);
            this.textBoxApi.Name = "textBoxApi";
            this.textBoxApi.Size = new System.Drawing.Size(535, 21);
            this.textBoxApi.TabIndex = 2;
            this.textBoxApi.Text = "https://celeron533.atlassian.net/rest/api/2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cookies";
            // 
            // textBoxCookies
            // 
            this.textBoxCookies.Location = new System.Drawing.Point(85, 81);
            this.textBoxCookies.Name = "textBoxCookies";
            this.textBoxCookies.Size = new System.Drawing.Size(535, 21);
            this.textBoxCookies.TabIndex = 5;
            this.textBoxCookies.Text = "paste here";
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.textBoxFromPreview);
            this.groupBoxFrom.Controls.Add(this.buttonFromFetch);
            this.groupBoxFrom.Controls.Add(this.textBoxFromId);
            this.groupBoxFrom.Location = new System.Drawing.Point(29, 141);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(379, 375);
            this.groupBoxFrom.TabIndex = 6;
            this.groupBoxFrom.TabStop = false;
            this.groupBoxFrom.Text = "From";
            // 
            // textBoxFromPreview
            // 
            this.textBoxFromPreview.Location = new System.Drawing.Point(30, 88);
            this.textBoxFromPreview.Multiline = true;
            this.textBoxFromPreview.Name = "textBoxFromPreview";
            this.textBoxFromPreview.Size = new System.Drawing.Size(310, 262);
            this.textBoxFromPreview.TabIndex = 8;
            // 
            // buttonFromFetch
            // 
            this.buttonFromFetch.Location = new System.Drawing.Point(265, 37);
            this.buttonFromFetch.Name = "buttonFromFetch";
            this.buttonFromFetch.Size = new System.Drawing.Size(75, 23);
            this.buttonFromFetch.TabIndex = 7;
            this.buttonFromFetch.Text = "Fetch";
            this.buttonFromFetch.UseVisualStyleBackColor = true;
            this.buttonFromFetch.Click += new System.EventHandler(this.buttonFromFetch_Click);
            // 
            // textBoxFromId
            // 
            this.textBoxFromId.Location = new System.Drawing.Point(30, 37);
            this.textBoxFromId.Name = "textBoxFromId";
            this.textBoxFromId.Size = new System.Drawing.Size(193, 21);
            this.textBoxFromId.TabIndex = 6;
            this.textBoxFromId.Text = "SAM-1";
            // 
            // groupBoxTo
            // 
            this.groupBoxTo.Controls.Add(this.textBoxToPreview);
            this.groupBoxTo.Controls.Add(this.buttonToFetch);
            this.groupBoxTo.Controls.Add(this.textBoxToId);
            this.groupBoxTo.Location = new System.Drawing.Point(496, 141);
            this.groupBoxTo.Name = "groupBoxTo";
            this.groupBoxTo.Size = new System.Drawing.Size(379, 375);
            this.groupBoxTo.TabIndex = 7;
            this.groupBoxTo.TabStop = false;
            this.groupBoxTo.Text = "To";
            // 
            // textBoxToPreview
            // 
            this.textBoxToPreview.Location = new System.Drawing.Point(27, 88);
            this.textBoxToPreview.Multiline = true;
            this.textBoxToPreview.Name = "textBoxToPreview";
            this.textBoxToPreview.Size = new System.Drawing.Size(328, 262);
            this.textBoxToPreview.TabIndex = 9;
            // 
            // buttonToFetch
            // 
            this.buttonToFetch.Location = new System.Drawing.Point(257, 37);
            this.buttonToFetch.Name = "buttonToFetch";
            this.buttonToFetch.Size = new System.Drawing.Size(75, 23);
            this.buttonToFetch.TabIndex = 8;
            this.buttonToFetch.Text = "Fetch";
            this.buttonToFetch.UseVisualStyleBackColor = true;
            this.buttonToFetch.Click += new System.EventHandler(this.buttonToFetch_Click);
            // 
            // textBoxToId
            // 
            this.textBoxToId.Location = new System.Drawing.Point(27, 37);
            this.textBoxToId.Name = "textBoxToId";
            this.textBoxToId.Size = new System.Drawing.Size(193, 21);
            this.textBoxToId.TabIndex = 7;
            this.textBoxToId.Text = "SAM-2";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(414, 309);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy >>";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 559);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.groupBoxTo);
            this.Controls.Add(this.groupBoxFrom);
            this.Controls.Add(this.textBoxCookies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "JiraNow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBoxTo.ResumeLayout(false);
            this.groupBoxTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxApi;
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
    }
}

