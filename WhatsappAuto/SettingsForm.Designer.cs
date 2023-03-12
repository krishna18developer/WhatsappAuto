namespace WhatsappAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.profilePathLabel = new System.Windows.Forms.Label();
            this.profilePathBox = new System.Windows.Forms.TextBox();
            this.profileDirectoryBox = new System.Windows.Forms.TextBox();
            this.profileDirectoryLabel = new System.Windows.Forms.Label();
            this.edgeDriverBox = new System.Windows.Forms.TextBox();
            this.edgeDriverLabel = new System.Windows.Forms.Label();
            this.reloadDataBox = new System.Windows.Forms.Button();
            this.saveDataBox = new System.Windows.Forms.Button();
            this.overallDeletionBox = new System.Windows.Forms.TextBox();
            this.overallDeletionLabel = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.whatsappURLBox = new System.Windows.Forms.TextBox();
            this.whatsappURLLabel = new System.Windows.Forms.Label();
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
            this.reloadDataBox.Location = new System.Drawing.Point(15, 269);
            this.reloadDataBox.Name = "reloadDataBox";
            this.reloadDataBox.Size = new System.Drawing.Size(441, 23);
            this.reloadDataBox.TabIndex = 6;
            this.reloadDataBox.Text = "Reload Data";
            this.reloadDataBox.UseVisualStyleBackColor = true;
            this.reloadDataBox.Click += new System.EventHandler(this.reloadDataBox_Click);
            // 
            // saveDataBox
            // 
            this.saveDataBox.Location = new System.Drawing.Point(474, 269);
            this.saveDataBox.Name = "saveDataBox";
            this.saveDataBox.Size = new System.Drawing.Size(414, 23);
            this.saveDataBox.TabIndex = 7;
            this.saveDataBox.Text = "Save Data";
            this.saveDataBox.UseVisualStyleBackColor = true;
            this.saveDataBox.Click += new System.EventHandler(this.saveDataBox_Click);
            // 
            // overallDeletionBox
            // 
            this.overallDeletionBox.Location = new System.Drawing.Point(105, 163);
            this.overallDeletionBox.Name = "overallDeletionBox";
            this.overallDeletionBox.Size = new System.Drawing.Size(783, 20);
            this.overallDeletionBox.TabIndex = 9;
            // 
            // overallDeletionLabel
            // 
            this.overallDeletionLabel.AutoSize = true;
            this.overallDeletionLabel.Location = new System.Drawing.Point(12, 166);
            this.overallDeletionLabel.Name = "overallDeletionLabel";
            this.overallDeletionLabel.Size = new System.Drawing.Size(88, 13);
            this.overallDeletionLabel.TabIndex = 8;
            this.overallDeletionLabel.Text = "Overall Deletion :";
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(105, 198);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(783, 20);
            this.userIDBox.TabIndex = 11;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(12, 201);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(49, 13);
            this.userIdLabel.TabIndex = 10;
            this.userIdLabel.Text = "User ID :";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(105, 230);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(783, 20);
            this.passwordBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password :";
            // 
            // whatsappURLBox
            // 
            this.whatsappURLBox.Location = new System.Drawing.Point(105, 127);
            this.whatsappURLBox.Name = "whatsappURLBox";
            this.whatsappURLBox.Size = new System.Drawing.Size(783, 20);
            this.whatsappURLBox.TabIndex = 15;
            // 
            // whatsappURLLabel
            // 
            this.whatsappURLLabel.AutoSize = true;
            this.whatsappURLLabel.Location = new System.Drawing.Point(12, 130);
            this.whatsappURLLabel.Name = "whatsappURLLabel";
            this.whatsappURLLabel.Size = new System.Drawing.Size(87, 13);
            this.whatsappURLLabel.TabIndex = 14;
            this.whatsappURLLabel.Text = "Whatsapp URL :";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 304);
            this.Controls.Add(this.whatsappURLBox);
            this.Controls.Add(this.whatsappURLLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.overallDeletionBox);
            this.Controls.Add(this.overallDeletionLabel);
            this.Controls.Add(this.saveDataBox);
            this.Controls.Add(this.reloadDataBox);
            this.Controls.Add(this.edgeDriverBox);
            this.Controls.Add(this.edgeDriverLabel);
            this.Controls.Add(this.profileDirectoryBox);
            this.Controls.Add(this.profileDirectoryLabel);
            this.Controls.Add(this.profilePathBox);
            this.Controls.Add(this.profilePathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox overallDeletionBox;
        private System.Windows.Forms.Label overallDeletionLabel;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox whatsappURLBox;
        private System.Windows.Forms.Label whatsappURLLabel;
    }
}