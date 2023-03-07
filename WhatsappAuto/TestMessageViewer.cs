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


namespace WhatsappAuto
{
    public partial class TestMessageViewer : Form
    {
        public string messages;
        public TestMessageViewer()
        {
            InitializeComponent();
        }

        private void TestMessageViewer_Load(object sender, EventArgs e)
        {
        }
        public void setMessages(string msg)
        {
            messages = msg;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(; ; )
            {
                MessageBox.Text = messages;
            }
        }
    }
}
