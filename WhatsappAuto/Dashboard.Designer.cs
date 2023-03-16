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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.closeAppButton = new System.Windows.Forms.Button();
            this.contactNameLabel = new System.Windows.Forms.Label();
            this.contactNameBox = new System.Windows.Forms.TextBox();
            this.thisMessageDeletedButton = new System.Windows.Forms.Button();
            this.runAgainButton = new System.Windows.Forms.Button();
            this.headlessCheckBox = new System.Windows.Forms.CheckBox();
            this.noOfDeletedMessagesLabel = new System.Windows.Forms.Label();
            this.whatsappOpenBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.deletionLogicBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.overallDeletedMessagesLabel = new System.Windows.Forms.Label();
            this.specificWordsLabel = new System.Windows.Forms.Label();
            this.specificWordsBox = new System.Windows.Forms.TextBox();
            this.specificDeletion = new System.Windows.Forms.Button();
            this.messageViewerButton = new System.Windows.Forms.Button();
            this.whatsappAutoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killEdgeCheckBox = new System.Windows.Forms.CheckBox();
            this.whatsappAutoMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeAppButton
            // 
            this.closeAppButton.Location = new System.Drawing.Point(475, 289);
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
            this.contactNameLabel.Location = new System.Drawing.Point(12, 35);
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
            this.thisMessageDeletedButton.Location = new System.Drawing.Point(12, 289);
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
            this.runAgainButton.Location = new System.Drawing.Point(243, 289);
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
            // whatsappOpenBackgroundWorker
            // 
            this.whatsappOpenBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.whatsappOpenBackgroundWorker_DoWork);
            // 
            // deletionLogicBackgroundWorker
            // 
            this.deletionLogicBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deletionLogicBackgroundWorker_DoWork);
            // 
            // overallDeletedMessagesLabel
            // 
            this.overallDeletedMessagesLabel.AutoSize = true;
            this.overallDeletedMessagesLabel.Location = new System.Drawing.Point(242, 35);
            this.overallDeletedMessagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.overallDeletedMessagesLabel.Name = "overallDeletedMessagesLabel";
            this.overallDeletedMessagesLabel.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.overallDeletedMessagesLabel.Size = new System.Drawing.Size(238, 13);
            this.overallDeletedMessagesLabel.TabIndex = 17;
            this.overallDeletedMessagesLabel.Text = "Overall deleted Messages : ";
            // 
            // specificWordsLabel
            // 
            this.specificWordsLabel.AutoSize = true;
            this.specificWordsLabel.Location = new System.Drawing.Point(12, 150);
            this.specificWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specificWordsLabel.Name = "specificWordsLabel";
            this.specificWordsLabel.Size = new System.Drawing.Size(121, 13);
            this.specificWordsLabel.TabIndex = 19;
            this.specificWordsLabel.Text = "Specific Words Deletion";
            this.specificWordsLabel.DoubleClick += new System.EventHandler(this.specificWordsLabel_DoubleClick);
            // 
            // specificWordsBox
            // 
            this.specificWordsBox.Location = new System.Drawing.Point(12, 180);
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
            this.specificDeletion.Location = new System.Drawing.Point(475, 180);
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
            this.messageViewerButton.Location = new System.Drawing.Point(475, 69);
            this.messageViewerButton.Margin = new System.Windows.Forms.Padding(2);
            this.messageViewerButton.Name = "messageViewerButton";
            this.messageViewerButton.Size = new System.Drawing.Size(205, 94);
            this.messageViewerButton.TabIndex = 21;
            this.messageViewerButton.Text = "Message Viewer";
            this.messageViewerButton.UseVisualStyleBackColor = true;
            this.messageViewerButton.Click += new System.EventHandler(this.messageViewerButton_Click);
            // 
            // whatsappAutoMenuStrip
            // 
            this.whatsappAutoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.dataFolderToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.whatsappAutoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.whatsappAutoMenuStrip.Name = "whatsappAutoMenuStrip";
            this.whatsappAutoMenuStrip.Size = new System.Drawing.Size(703, 24);
            this.whatsappAutoMenuStrip.TabIndex = 22;
            this.whatsappAutoMenuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // dataFolderToolStripMenuItem
            // 
            this.dataFolderToolStripMenuItem.Name = "dataFolderToolStripMenuItem";
            this.dataFolderToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.dataFolderToolStripMenuItem.Text = "Data Folder";
            this.dataFolderToolStripMenuItem.Click += new System.EventHandler(this.dataFolderToolStripMenuItem_Click);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 396);
            this.Controls.Add(this.killEdgeCheckBox);
            this.Controls.Add(this.whatsappAutoMenuStrip);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Whatsapp Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.whatsappAutoMenuStrip.ResumeLayout(false);
            this.whatsappAutoMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Label contactNameLabel;
        private System.Windows.Forms.TextBox contactNameBox;
        private System.Windows.Forms.Button thisMessageDeletedButton;
        private System.Windows.Forms.Button runAgainButton;
        private System.Windows.Forms.CheckBox headlessCheckBox;
        private System.Windows.Forms.Label noOfDeletedMessagesLabel;
        private System.ComponentModel.BackgroundWorker whatsappOpenBackgroundWorker;
        private System.ComponentModel.BackgroundWorker deletionLogicBackgroundWorker;
        private System.Windows.Forms.Label overallDeletedMessagesLabel;
        private System.Windows.Forms.Label specificWordsLabel;
        private System.Windows.Forms.TextBox specificWordsBox;
        private System.Windows.Forms.Button specificDeletion;
        private System.Windows.Forms.Button messageViewerButton;
        private System.Windows.Forms.MenuStrip whatsappAutoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.CheckBox killEdgeCheckBox;
        private System.Windows.Forms.ToolStripMenuItem dataFolderToolStripMenuItem;
    }
}

