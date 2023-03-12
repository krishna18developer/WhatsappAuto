using System;

namespace WhatsappAuto
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.totalDeletedMssgesLabel = new System.Windows.Forms.Label();
            this.AllMessagesLabel = new System.Windows.Forms.Label();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.contactNameLabel = new System.Windows.Forms.Label();
            this.contactNameBox = new System.Windows.Forms.TextBox();
            this.thisMessageDeletedButton = new System.Windows.Forms.Button();
            this.runAgainButton = new System.Windows.Forms.Button();
            this.headlessCheckBox = new System.Windows.Forms.CheckBox();
            this.noOfDeletedMessagesLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.overallDeletedMessagesLabel = new System.Windows.Forms.Label();
            this.specificWordsLabel = new System.Windows.Forms.Label();
            this.specificWordsBox = new System.Windows.Forms.TextBox();
            this.specificDeletion = new System.Windows.Forms.Button();
            this.messageViewerButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killEdgeCheckBox = new System.Windows.Forms.CheckBox();
            this.dataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDeletedMssgesLabel
            // 
            this.totalDeletedMssgesLabel.AutoSize = true;
            this.totalDeletedMssgesLabel.Location = new System.Drawing.Point(11, 151);
            this.totalDeletedMssgesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalDeletedMssgesLabel.Name = "totalDeletedMssgesLabel";
            this.totalDeletedMssgesLabel.Size = new System.Drawing.Size(147, 13);
            this.totalDeletedMssgesLabel.TabIndex = 6;
            this.totalDeletedMssgesLabel.Text = "Total You Delete Messages : ";
            // 
            // AllMessagesLabel
            // 
            this.AllMessagesLabel.AutoSize = true;
            this.AllMessagesLabel.Location = new System.Drawing.Point(14, 189);
            this.AllMessagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllMessagesLabel.Name = "AllMessagesLabel";
            this.AllMessagesLabel.Size = new System.Drawing.Size(98, 13);
            this.AllMessagesLabel.TabIndex = 8;
            this.AllMessagesLabel.Text = "All Our Messages : ";
            // 
            // closeAppButton
            // 
            this.closeAppButton.Location = new System.Drawing.Point(477, 359);
            this.closeAppButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(205, 94);
            this.closeAppButton.TabIndex = 9;
            this.closeAppButton.Text = "Close App";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // contactNameLabel
            // 
            this.contactNameLabel.AutoSize = true;
            this.contactNameLabel.Location = new System.Drawing.Point(11, 35);
            this.contactNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNameLabel.Name = "contactNameLabel";
            this.contactNameLabel.Size = new System.Drawing.Size(81, 13);
            this.contactNameLabel.TabIndex = 10;
            this.contactNameLabel.Text = "Contact Name :";
            // 
            // contactNameBox
            // 
            this.contactNameBox.Location = new System.Drawing.Point(14, 69);
            this.contactNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactNameBox.Name = "contactNameBox";
            this.contactNameBox.Size = new System.Drawing.Size(205, 20);
            this.contactNameBox.TabIndex = 11;
            this.contactNameBox.TextChanged += new System.EventHandler(this.contactNameBox_TextChanged);
            // 
            // thisMessageDeletedButton
            // 
            this.thisMessageDeletedButton.Location = new System.Drawing.Point(14, 359);
            this.thisMessageDeletedButton.Margin = new System.Windows.Forms.Padding(2);
            this.thisMessageDeletedButton.Name = "thisMessageDeletedButton";
            this.thisMessageDeletedButton.Size = new System.Drawing.Size(205, 94);
            this.thisMessageDeletedButton.TabIndex = 13;
            this.thisMessageDeletedButton.Text = "Open Whatsapp";
            this.thisMessageDeletedButton.UseVisualStyleBackColor = true;
            this.thisMessageDeletedButton.Click += new System.EventHandler(this.thisMessageDeletedButton_Click);
            // 
            // runAgainButton
            // 
            this.runAgainButton.Location = new System.Drawing.Point(245, 359);
            this.runAgainButton.Margin = new System.Windows.Forms.Padding(2);
            this.runAgainButton.Name = "runAgainButton";
            this.runAgainButton.Size = new System.Drawing.Size(205, 94);
            this.runAgainButton.TabIndex = 14;
            this.runAgainButton.Text = "Delete";
            this.runAgainButton.UseVisualStyleBackColor = true;
            this.runAgainButton.Click += new System.EventHandler(this.runAgainButton_Click);
            // 
            // headlessCheckBox
            // 
            this.headlessCheckBox.AutoSize = true;
            this.headlessCheckBox.Location = new System.Drawing.Point(245, 69);
            this.headlessCheckBox.Name = "headlessCheckBox";
            this.headlessCheckBox.Size = new System.Drawing.Size(70, 17);
            this.headlessCheckBox.TabIndex = 15;
            this.headlessCheckBox.Text = "Headless";
            this.headlessCheckBox.UseVisualStyleBackColor = true;
            // 
            // noOfDeletedMessagesLabel
            // 
            this.noOfDeletedMessagesLabel.AutoSize = true;
            this.noOfDeletedMessagesLabel.Location = new System.Drawing.Point(11, 113);
            this.noOfDeletedMessagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noOfDeletedMessagesLabel.Name = "noOfDeletedMessagesLabel";
            this.noOfDeletedMessagesLabel.Size = new System.Drawing.Size(131, 13);
            this.noOfDeletedMessagesLabel.TabIndex = 16;
            this.noOfDeletedMessagesLabel.Text = "No of deleted Messages : ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // overallDeletedMessagesLabel
            // 
            this.overallDeletedMessagesLabel.AutoSize = true;
            this.overallDeletedMessagesLabel.Location = new System.Drawing.Point(242, 35);
            this.overallDeletedMessagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.overallDeletedMessagesLabel.Name = "overallDeletedMessagesLabel";
            this.overallDeletedMessagesLabel.Size = new System.Drawing.Size(138, 13);
            this.overallDeletedMessagesLabel.TabIndex = 17;
            this.overallDeletedMessagesLabel.Text = "Overall deleted Messages : ";
            // 
            // specificWordsLabel
            // 
            this.specificWordsLabel.AutoSize = true;
            this.specificWordsLabel.Location = new System.Drawing.Point(14, 220);
            this.specificWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specificWordsLabel.Name = "specificWordsLabel";
            this.specificWordsLabel.Size = new System.Drawing.Size(121, 13);
            this.specificWordsLabel.TabIndex = 19;
            this.specificWordsLabel.Text = "Specific Words Deletion";
            this.specificWordsLabel.DoubleClick += new System.EventHandler(this.specificWordsLabel_DoubleClick);
            // 
            // specificWordsBox
            // 
            this.specificWordsBox.Location = new System.Drawing.Point(14, 250);
            this.specificWordsBox.Margin = new System.Windows.Forms.Padding(2);
            this.specificWordsBox.Multiline = true;
            this.specificWordsBox.Name = "specificWordsBox";
            this.specificWordsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.specificWordsBox.Size = new System.Drawing.Size(436, 94);
            this.specificWordsBox.TabIndex = 18;
            this.specificWordsBox.TextChanged += new System.EventHandler(this.specificWordsBox_TextChanged);
            // 
            // specificDeletion
            // 
            this.specificDeletion.Location = new System.Drawing.Point(477, 250);
            this.specificDeletion.Margin = new System.Windows.Forms.Padding(2);
            this.specificDeletion.Name = "specificDeletion";
            this.specificDeletion.Size = new System.Drawing.Size(205, 94);
            this.specificDeletion.TabIndex = 20;
            this.specificDeletion.Text = "Reload Specific Deletion";
            this.specificDeletion.UseVisualStyleBackColor = true;
            this.specificDeletion.Click += new System.EventHandler(this.specificDeletion_Click);
            // 
            // messageViewerButton
            // 
            this.messageViewerButton.Location = new System.Drawing.Point(477, 139);
            this.messageViewerButton.Margin = new System.Windows.Forms.Padding(2);
            this.messageViewerButton.Name = "messageViewerButton";
            this.messageViewerButton.Size = new System.Drawing.Size(205, 94);
            this.messageViewerButton.TabIndex = 21;
            this.messageViewerButton.Text = "Message Viewer";
            this.messageViewerButton.UseVisualStyleBackColor = true;
            this.messageViewerButton.Click += new System.EventHandler(this.messageViewerButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.dataFolderToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // killEdgeCheckBox
            // 
            this.killEdgeCheckBox.AutoSize = true;
            this.killEdgeCheckBox.Location = new System.Drawing.Point(321, 69);
            this.killEdgeCheckBox.Name = "killEdgeCheckBox";
            this.killEdgeCheckBox.Size = new System.Drawing.Size(67, 17);
            this.killEdgeCheckBox.TabIndex = 23;
            this.killEdgeCheckBox.Text = "Kill Edge";
            this.killEdgeCheckBox.UseVisualStyleBackColor = true;
            this.killEdgeCheckBox.CheckedChanged += new System.EventHandler(this.killEdgeCheckBox_CheckedChanged);
            // 
            // dataFolderToolStripMenuItem
            // 
            this.dataFolderToolStripMenuItem.Name = "dataFolderToolStripMenuItem";
            this.dataFolderToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.dataFolderToolStripMenuItem.Text = "Data Folder";
            this.dataFolderToolStripMenuItem.Click += new System.EventHandler(this.dataFolderToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 467);
            this.Controls.Add(this.killEdgeCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.messageViewerButton);
            this.Controls.Add(this.specificDeletion);
            this.Controls.Add(this.specificWordsLabel);
            this.Controls.Add(this.specificWordsBox);
            this.Controls.Add(this.overallDeletedMessagesLabel);
            this.Controls.Add(this.noOfDeletedMessagesLabel);
            this.Controls.Add(this.headlessCheckBox);
            this.Controls.Add(this.runAgainButton);
            this.Controls.Add(this.thisMessageDeletedButton);
            this.Controls.Add(this.contactNameBox);
            this.Controls.Add(this.contactNameLabel);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.AllMessagesLabel);
            this.Controls.Add(this.totalDeletedMssgesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Whatsapp Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalDeletedMssgesLabel;
        private System.Windows.Forms.Label AllMessagesLabel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Label contactNameLabel;
        private System.Windows.Forms.TextBox contactNameBox;
        private System.Windows.Forms.Button thisMessageDeletedButton;
        private System.Windows.Forms.Button runAgainButton;
        private System.Windows.Forms.CheckBox headlessCheckBox;
        private System.Windows.Forms.Label noOfDeletedMessagesLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label overallDeletedMessagesLabel;
        private System.Windows.Forms.Label specificWordsLabel;
        private System.Windows.Forms.TextBox specificWordsBox;
        private System.Windows.Forms.Button specificDeletion;
        private System.Windows.Forms.Button messageViewerButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.CheckBox killEdgeCheckBox;
        private System.Windows.Forms.ToolStripMenuItem dataFolderToolStripMenuItem;
    }
}

