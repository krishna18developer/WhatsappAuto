﻿namespace WhatsappAuto
{
    partial class SettingsForm
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
            this.profilePathLabel = new System.Windows.Forms.Label();
            this.profilePathBox = new System.Windows.Forms.TextBox();
            this.profileDirectoryBox = new System.Windows.Forms.TextBox();
            this.profileDirectoryLabel = new System.Windows.Forms.Label();
            this.edgeDriverBox = new System.Windows.Forms.TextBox();
            this.edgeDriverLabel = new System.Windows.Forms.Label();
            this.reloadDataBox = new System.Windows.Forms.Button();
            this.saveDataBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profilePathLabel
            // 
            this.profilePathLabel.AutoSize = true;
            this.profilePathLabel.Location = new System.Drawing.Point(12, 24);
            this.profilePathLabel.Name = "profilePathLabel";
            this.profilePathLabel.Size = new System.Drawing.Size(67, 13);
            this.profilePathLabel.TabIndex = 0;
            this.profilePathLabel.Text = "Profile Path :";
            // 
            // profilePathBox
            // 
            this.profilePathBox.Location = new System.Drawing.Point(105, 21);
            this.profilePathBox.Name = "profilePathBox";
            this.profilePathBox.Size = new System.Drawing.Size(783, 20);
            this.profilePathBox.TabIndex = 1;
            // 
            // profileDirectoryBox
            // 
            this.profileDirectoryBox.Location = new System.Drawing.Point(105, 56);
            this.profileDirectoryBox.Name = "profileDirectoryBox";
            this.profileDirectoryBox.Size = new System.Drawing.Size(783, 20);
            this.profileDirectoryBox.TabIndex = 3;
            // 
            // profileDirectoryLabel
            // 
            this.profileDirectoryLabel.AutoSize = true;
            this.profileDirectoryLabel.Location = new System.Drawing.Point(12, 59);
            this.profileDirectoryLabel.Name = "profileDirectoryLabel";
            this.profileDirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.profileDirectoryLabel.TabIndex = 2;
            this.profileDirectoryLabel.Text = "Profile Directory :";
            // 
            // edgeDriverBox
            // 
            this.edgeDriverBox.Location = new System.Drawing.Point(105, 91);
            this.edgeDriverBox.Name = "edgeDriverBox";
            this.edgeDriverBox.Size = new System.Drawing.Size(783, 20);
            this.edgeDriverBox.TabIndex = 5;
            // 
            // edgeDriverLabel
            // 
            this.edgeDriverLabel.AutoSize = true;
            this.edgeDriverLabel.Location = new System.Drawing.Point(12, 94);
            this.edgeDriverLabel.Name = "edgeDriverLabel";
            this.edgeDriverLabel.Size = new System.Drawing.Size(69, 13);
            this.edgeDriverLabel.TabIndex = 4;
            this.edgeDriverLabel.Text = "Edge Driver :";
            // 
            // reloadDataBox
            // 
            this.reloadDataBox.Location = new System.Drawing.Point(15, 122);
            this.reloadDataBox.Name = "reloadDataBox";
            this.reloadDataBox.Size = new System.Drawing.Size(441, 23);
            this.reloadDataBox.TabIndex = 6;
            this.reloadDataBox.Text = "Reload Data";
            this.reloadDataBox.UseVisualStyleBackColor = true;
            this.reloadDataBox.Click += new System.EventHandler(this.reloadDataBox_Click);
            // 
            // saveDataBox
            // 
            this.saveDataBox.Location = new System.Drawing.Point(474, 122);
            this.saveDataBox.Name = "saveDataBox";
            this.saveDataBox.Size = new System.Drawing.Size(414, 23);
            this.saveDataBox.TabIndex = 7;
            this.saveDataBox.Text = "Save Data";
            this.saveDataBox.UseVisualStyleBackColor = true;
            this.saveDataBox.Click += new System.EventHandler(this.saveDataBox_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 157);
            this.Controls.Add(this.saveDataBox);
            this.Controls.Add(this.reloadDataBox);
            this.Controls.Add(this.edgeDriverBox);
            this.Controls.Add(this.edgeDriverLabel);
            this.Controls.Add(this.profileDirectoryBox);
            this.Controls.Add(this.profileDirectoryLabel);
            this.Controls.Add(this.profilePathBox);
            this.Controls.Add(this.profilePathLabel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profilePathLabel;
        private System.Windows.Forms.TextBox profilePathBox;
        private System.Windows.Forms.TextBox profileDirectoryBox;
        private System.Windows.Forms.Label profileDirectoryLabel;
        private System.Windows.Forms.TextBox edgeDriverBox;
        private System.Windows.Forms.Label edgeDriverLabel;
        private System.Windows.Forms.Button reloadDataBox;
        private System.Windows.Forms.Button saveDataBox;
    }
}