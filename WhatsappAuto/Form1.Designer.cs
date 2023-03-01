using System;

namespace WhatsappAuto
{
    partial class Form1
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
            this.closeEdgeButton = new System.Windows.Forms.Button();
            this.openEdgeButton = new System.Windows.Forms.Button();
            this.chatStartPointBox = new System.Windows.Forms.TextBox();
            this.chatStartingPointLabel = new System.Windows.Forms.Label();
            this.chatEndingPointLabel = new System.Windows.Forms.Label();
            this.chatEndPointBox = new System.Windows.Forms.TextBox();
            this.totalDeletedMssgesLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.AllMessagesLabel = new System.Windows.Forms.Label();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.contactNameLabel = new System.Windows.Forms.Label();
            this.contactNameBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.thisMessageDeletedButton = new System.Windows.Forms.Button();
            this.runAgainButton = new System.Windows.Forms.Button();
            this.headlessCheckBox = new System.Windows.Forms.CheckBox();
            this.noOfDeletedMessagesLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeEdgeButton
            // 
            this.closeEdgeButton.Location = new System.Drawing.Point(229, 35);
            this.closeEdgeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeEdgeButton.Name = "closeEdgeButton";
            this.closeEdgeButton.Size = new System.Drawing.Size(205, 94);
            this.closeEdgeButton.TabIndex = 0;
            this.closeEdgeButton.Text = "Close Edge";
            this.closeEdgeButton.UseVisualStyleBackColor = true;
            this.closeEdgeButton.Click += new System.EventHandler(this.closeEdgeButton_Click);
            // 
            // openEdgeButton
            // 
            this.openEdgeButton.Location = new System.Drawing.Point(9, 35);
            this.openEdgeButton.Margin = new System.Windows.Forms.Padding(2);
            this.openEdgeButton.Name = "openEdgeButton";
            this.openEdgeButton.Size = new System.Drawing.Size(205, 94);
            this.openEdgeButton.TabIndex = 1;
            this.openEdgeButton.Text = "Open Edge";
            this.openEdgeButton.UseVisualStyleBackColor = true;
            this.openEdgeButton.Click += new System.EventHandler(this.openEdgeButton_Click);
            // 
            // chatStartPointBox
            // 
            this.chatStartPointBox.Location = new System.Drawing.Point(11, 263);
            this.chatStartPointBox.Margin = new System.Windows.Forms.Padding(2);
            this.chatStartPointBox.Name = "chatStartPointBox";
            this.chatStartPointBox.Size = new System.Drawing.Size(205, 20);
            this.chatStartPointBox.TabIndex = 2;
            this.chatStartPointBox.TextChanged += new System.EventHandler(this.chatStartPointBox_TextChanged);
            // 
            // chatStartingPointLabel
            // 
            this.chatStartingPointLabel.AutoSize = true;
            this.chatStartingPointLabel.Location = new System.Drawing.Point(11, 233);
            this.chatStartingPointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chatStartingPointLabel.Name = "chatStartingPointLabel";
            this.chatStartingPointLabel.Size = new System.Drawing.Size(81, 13);
            this.chatStartingPointLabel.TabIndex = 3;
            this.chatStartingPointLabel.Text = "Chat Start Point";
            // 
            // chatEndingPointLabel
            // 
            this.chatEndingPointLabel.AutoSize = true;
            this.chatEndingPointLabel.Location = new System.Drawing.Point(245, 233);
            this.chatEndingPointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chatEndingPointLabel.Name = "chatEndingPointLabel";
            this.chatEndingPointLabel.Size = new System.Drawing.Size(78, 13);
            this.chatEndingPointLabel.TabIndex = 5;
            this.chatEndingPointLabel.Text = "Chat End Point";
            // 
            // chatEndPointBox
            // 
            this.chatEndPointBox.Location = new System.Drawing.Point(245, 263);
            this.chatEndPointBox.Margin = new System.Windows.Forms.Padding(2);
            this.chatEndPointBox.Name = "chatEndPointBox";
            this.chatEndPointBox.Size = new System.Drawing.Size(205, 20);
            this.chatEndPointBox.TabIndex = 4;
            this.chatEndPointBox.TextChanged += new System.EventHandler(this.chatEndPointBox_TextChanged);
            // 
            // totalDeletedMssgesLabel
            // 
            this.totalDeletedMssgesLabel.AutoSize = true;
            this.totalDeletedMssgesLabel.Location = new System.Drawing.Point(11, 331);
            this.totalDeletedMssgesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalDeletedMssgesLabel.Name = "totalDeletedMssgesLabel";
            this.totalDeletedMssgesLabel.Size = new System.Drawing.Size(147, 13);
            this.totalDeletedMssgesLabel.TabIndex = 6;
            this.totalDeletedMssgesLabel.Text = "Total You Delete Messages : ";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(314, 331);
            this.testLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 7;
            this.testLabel.Text = "label4";
            // 
            // AllMessagesLabel
            // 
            this.AllMessagesLabel.AutoSize = true;
            this.AllMessagesLabel.Location = new System.Drawing.Point(11, 372);
            this.AllMessagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllMessagesLabel.Name = "AllMessagesLabel";
            this.AllMessagesLabel.Size = new System.Drawing.Size(98, 13);
            this.AllMessagesLabel.TabIndex = 8;
            this.AllMessagesLabel.Text = "All Our Messages : ";
            // 
            // closeAppButton
            // 
            this.closeAppButton.Location = new System.Drawing.Point(450, 35);
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
            this.contactNameLabel.Location = new System.Drawing.Point(11, 150);
            this.contactNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNameLabel.Name = "contactNameLabel";
            this.contactNameLabel.Size = new System.Drawing.Size(81, 13);
            this.contactNameLabel.TabIndex = 10;
            this.contactNameLabel.Text = "Contact Name :";
            // 
            // contactNameBox
            // 
            this.contactNameBox.Location = new System.Drawing.Point(14, 184);
            this.contactNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactNameBox.Name = "contactNameBox";
            this.contactNameBox.Size = new System.Drawing.Size(205, 20);
            this.contactNameBox.TabIndex = 11;
            this.contactNameBox.TextChanged += new System.EventHandler(this.contactNameBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.Size = new System.Drawing.Size(61, 20);
            this.settingsMenuButton.Text = "Settings";
            this.settingsMenuButton.Click += new System.EventHandler(this.settingsMenuButton_Click);
            // 
            // thisMessageDeletedButton
            // 
            this.thisMessageDeletedButton.Location = new System.Drawing.Point(11, 421);
            this.thisMessageDeletedButton.Margin = new System.Windows.Forms.Padding(2);
            this.thisMessageDeletedButton.Name = "thisMessageDeletedButton";
            this.thisMessageDeletedButton.Size = new System.Drawing.Size(205, 94);
            this.thisMessageDeletedButton.TabIndex = 13;
            this.thisMessageDeletedButton.Text = "This Messsage Was Deleted";
            this.thisMessageDeletedButton.UseVisualStyleBackColor = true;
            this.thisMessageDeletedButton.Click += new System.EventHandler(this.thisMessageDeletedButton_Click);
            // 
            // runAgainButton
            // 
            this.runAgainButton.Location = new System.Drawing.Point(245, 421);
            this.runAgainButton.Margin = new System.Windows.Forms.Padding(2);
            this.runAgainButton.Name = "runAgainButton";
            this.runAgainButton.Size = new System.Drawing.Size(205, 94);
            this.runAgainButton.TabIndex = 14;
            this.runAgainButton.Text = "Reload";
            this.runAgainButton.UseVisualStyleBackColor = true;
            this.runAgainButton.Click += new System.EventHandler(this.runAgainButton_Click_1);
            // 
            // headlessCheckBox
            // 
            this.headlessCheckBox.AutoSize = true;
            this.headlessCheckBox.Location = new System.Drawing.Point(245, 184);
            this.headlessCheckBox.Name = "headlessCheckBox";
            this.headlessCheckBox.Size = new System.Drawing.Size(70, 17);
            this.headlessCheckBox.TabIndex = 15;
            this.headlessCheckBox.Text = "Headless";
            this.headlessCheckBox.UseVisualStyleBackColor = true;
            // 
            // noOfDeletedMessagesLabel
            // 
            this.noOfDeletedMessagesLabel.AutoSize = true;
            this.noOfDeletedMessagesLabel.Location = new System.Drawing.Point(11, 301);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 526);
            this.Controls.Add(this.noOfDeletedMessagesLabel);
            this.Controls.Add(this.headlessCheckBox);
            this.Controls.Add(this.runAgainButton);
            this.Controls.Add(this.thisMessageDeletedButton);
            this.Controls.Add(this.contactNameBox);
            this.Controls.Add(this.contactNameLabel);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.AllMessagesLabel);
            this.Controls.Add(this.openEdgeButton);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.totalDeletedMssgesLabel);
            this.Controls.Add(this.chatEndingPointLabel);
            this.Controls.Add(this.chatEndPointBox);
            this.Controls.Add(this.chatStartingPointLabel);
            this.Controls.Add(this.chatStartPointBox);
            this.Controls.Add(this.closeEdgeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Whatsapp Auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeEdgeButton;
        private System.Windows.Forms.Button openEdgeButton;
        private System.Windows.Forms.TextBox chatStartPointBox;
        private System.Windows.Forms.Label chatStartingPointLabel;
        private System.Windows.Forms.Label chatEndingPointLabel;
        private System.Windows.Forms.TextBox chatEndPointBox;
        private System.Windows.Forms.Label totalDeletedMssgesLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label AllMessagesLabel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Label contactNameLabel;
        private System.Windows.Forms.TextBox contactNameBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuButton;
        private System.Windows.Forms.Button thisMessageDeletedButton;
        private System.Windows.Forms.Button runAgainButton;
        private System.Windows.Forms.CheckBox headlessCheckBox;
        private System.Windows.Forms.Label noOfDeletedMessagesLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private EventHandler runAgainButton_Click;
        private EventHandler headlessCheckBox_CheckedChanged;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

