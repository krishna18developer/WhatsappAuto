using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace WhatsappAuto
{
    public partial class TestMessageViewer : Form
    {
        private readonly Timer timer = new Timer();
        static string folderPath = AppDomain.CurrentDomain.BaseDirectory + "Data";
        string filePath;
        DataEncryptor dataEncryptor = new DataEncryptor();
        string decryptedText = "";
        public TestMessageViewer()
        {
            InitializeComponent();

            timer.Interval = 1000; // Replace with the interval (in milliseconds) you want to use
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Text = decryptedText;
        }
        private void TestMessageViewer_Load(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public void setContactName(string contactName)
        {
            filePath = folderPath + @"\" + contactName + "-messages.bin";
        }
        private void UpdateMessages()
        {
            // Read the contents of the file
            if(File.Exists(filePath))
            {
                string fileText = File.ReadAllText(filePath);
                

                string[] lines = File.ReadAllLines(filePath);

                // Process each line of the file
                foreach (string line in lines)
                {
                    decryptedText += dataEncryptor.Decryptor(line);
                    decryptedText += Environment.NewLine;
                }
                // Update the text in the TextBox
                // MessageBox.Text = fileText;
            }
        }

        private void MessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateMessages();
        }
    }
}
