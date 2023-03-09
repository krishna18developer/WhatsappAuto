namespace WhatsappAuto
{
    partial class TestMessageViewer
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
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(12, 12);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBox.Size = new System.Drawing.Size(660, 522);
            this.MessageBox.TabIndex = 0;
            // 
            // TestMessageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 546);
            this.Controls.Add(this.MessageBox);
            this.Name = "TestMessageViewer";
            this.Text = "TestMessageViewer";
            this.Load += new System.EventHandler(this.TestMessageViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBox;
    }
}