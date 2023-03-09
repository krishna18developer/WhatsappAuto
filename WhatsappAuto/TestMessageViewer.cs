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

        public TestMessageViewer()
        {
            InitializeComponent();

            timer.Interval = 1000; // Replace with the interval (in milliseconds) you want to use
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void TestMessageViewer_Load(object sender, EventArgs e)
        {
            
        }

        public void setContactName(string contactName)
        {
            filePath = folderPath + @"\" + contactName + "-messages.bin";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Read the contents of the file
            if(File.Exists(filePath))
            {
                string fileText = File.ReadAllText(filePath);

                // Update the text in the TextBox
                MessageBox.Text = fileText;
            }
        }
    }
}
