using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WhatsappAuto
{
    public partial class Encrypto : Form
    {
        DataEncryptor dataEncryptor = new DataEncryptor();
        static string folderPath = AppDomain.CurrentDomain.BaseDirectory + "Data";
        string filePath;
        public Encrypto()
        {
            InitializeComponent();
            setContactName();
        }
        public void setContactName()
        {
            filePath = folderPath + @"\" + "Cherry-messages.bin";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                MessageBox.Show("Hey");
                string fileText = File.ReadAllText(filePath);
                string encryptedText = "";

                string[] lines = File.ReadAllLines(filePath);

                // Process each line of the file
                foreach (string line in lines)
                {
                    encryptedText += dataEncryptor.Encryptor(line);
                }
                // Update the text in the TextBox
                // MessageBox.Text = fileText;
                // MessageBox.Text = decryptedText;
                string newFilePath = folderPath + @"\" + "Cherry" + "-enmessages.bin";
                File.WriteAllText(newFilePath, encryptedText);

                MessageBox.Show("Finished");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Generate a random 256-bit key
            Random random = new Random();

            // Generate a 16-character string
            string randomString = new string(
                Enumerable.Repeat(chars, 16)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            textBox1.Text = randomString;
        }
    }
}
