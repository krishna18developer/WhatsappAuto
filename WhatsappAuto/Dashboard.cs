using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WhatsappAuto.Properties;
using Application = System.Windows.Forms.Application;


namespace WhatsappAuto
{
    public partial class Dashboard : Form
    {
        //string Mode = "Debug";
#if DEBUG
        bool isDebug = true; 
#else
        bool isDebug = false;
#endif

        EdgeOptions options;
        string ContactName = Settings.Default.ContactName; //BookMyShow
        string StartingMessage = "s";
        string EndingMessage = "fdsf";
        bool headless = Settings.Default.Headless;
        int numberOfDeletedMessages = 0;
        string testLabelText = "Test label";
        EdgeDriver publicDriver;
        TestMessageViewer TMV = new TestMessageViewer();
        List<string> searchStrings = searchStringLoader();
        List<string> basicSearchStrings = new List<string> { "You deleted this message", "This message was deleted" };
        public Dashboard()
        {
            InitializeComponent();
        }
        private static List<string> searchStringLoader()
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory + "Data";
            List<string> loadedStrings = new List<string>();
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Data Folder created successfully.");
            }
            string filePath = folderPath + @"\" + "defaultstrings.bin";
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                loadedStrings = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Console.WriteLine("Loaded File Successfully");
            }
            else
            {
                File.WriteAllText(filePath, " ");
            }

            foreach (string s in loadedStrings)
            {
                Console.WriteLine("searchStringLoader().loadedStrings-> " + s);
            }

            return loadedStrings;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (isDebug)
            {
                this.Text += " - Debug";
            }
            else
            {
                this.Text += " - Release";
            }
            UpdateLabels();
            //killEdgePrograms();
            //Thread t = new Thread(new ThreadStart(UpdateLabels));
            //t.Start();
            contactNameBox.Text = ContactName;
            specificWordsBox.Text = Settings.Default.SpecificWords;
        }
        private void UpdateLabels()
        {
            noOfDeletedMessagesLabel.Text = "No of deleted Messages : " + numberOfDeletedMessages;
            //testLabel.Text = testLabelText;
            TMV.setMessages(testLabelText);
            overallDeletedMessagesLabel.Text = "Overall deleted Messages : " + Settings.Default.OverallCount;
        }
        private void closeEdgeButton_Click(object sender, EventArgs e)
        {
            killEdgePrograms();
        }

            /* Working Delete LOGIC
             * 
             * IWebElement ChatStartPoint = browser.FindElement(By.XPath("//span[.='"+ StartingMessage +"']"));

                IList<IWebElement> al = browser.FindElements(By.Name(""));
                IWebElement AllMessages = browser.FindElement(By.XPath("//div[@data-testid='msg-container']"));
                var ChatArrow = AllMessages.FindElement(By.XPath("//span[@data-testid='msg-dblcheck']"));
                ChatStartPoint.Click();
                Thread.Sleep(500);
                ChatArrow = AllMessages.FindElement(By.XPath("//span[@data-testid='down-context']"));
                
                ChatArrow.Click();
                Thread.Sleep(500);
                var DeleteButton = AllMessages.FindElement(By.XPath("//div[@aria-label='Delete message']"));
                DeleteButton.Click();

                var DeleteForEveryone = browser.FindElement(By.XPath("//div[@data-testid='content']"));
                
                DeleteForEveryone.Click();
                IWebElement ChatEndPoint = browser.FindElement(By.XPath("//span[.='asdfdffdfd']"));
             */

        void killEdgePrograms()
        {
            foreach (var process in Process.GetProcessesByName("msedge"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("msedgedriver"))
            {
                process.Kill();
            }
        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsMenuButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void contactNameBox_TextChanged(object sender, EventArgs e)
        {
            ContactName = contactNameBox.Text;
            Settings.Default.ContactName = ContactName;
            Settings.Default.Save();
        }

        private void thisMessageDeletedButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
           // deletionLogic();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            deletionLogic();
        }
        public void deletionLogic()
        {
            killEdgePrograms();
            Thread.Sleep(500);
            options = new EdgeOptions();
            string profilePath = Settings.Default.ProfilePath;
            options.AddArgument("--user-data-dir=" + profilePath);
            options.AddArgument("--profile-directory=" + Settings.Default.ProfileDirectory);
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-logging");
            if (headless)
            {
                options.AddArgument("--headless");
            }
            //options.AddArgument("--headless");

            EdgeDriverService service = EdgeDriverService.CreateDefaultService(Settings.Default.EdgeDriverLocation);
            // specify the path to the Edge browser executable
            //  options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
            // create a new EdgeDriver instance with the options
            try
            {
                //EdgeDriver browser = new EdgeDriver(@"F:\Krishna Teja\Softwares\edgedriver_win64\msedgedriver.exe",options);
                EdgeDriver browser = new EdgeDriver(service, options);

                browser.Navigate().GoToUrl("https://web.whatsapp.com/");    
                Thread.Sleep(10000);
                IWebElement contactName;
            contactTryer:
                try
                {

                    contactName = browser.FindElement(By.XPath("//span[.='" + ContactName + "']"));
                    contactName.Click();

                }
                catch (Exception cN)
                {
                    Console.Write(cN + "");
                    Thread.Sleep(3000);
                    goto contactTryer;
                }
                //Thread.Sleep(2000);

                publicDriver = browser;
                //reloadDeletion();
            }
            catch (Exception ed)
            {
                Console.WriteLine(ed);
            }
        }
        public void reloadDeletion()
        {
            try
            {
                IList<IWebElement> ChatStartPoint = publicDriver.FindElements(By.XPath("//div[@data-testid='msg-container']"));
                //testLabel.Text = "";
                foreach (IWebElement element in ChatStartPoint)
                {
                    testLabelText += element.GetAttribute("outerText");
                }

                foreach (IWebElement webElement in ChatStartPoint)
                {
                    try
                    {
                        //if (webElement.GetAttribute("outerText").Contains("You deleted this message") || webElement.GetAttribute("outerText").Contains("This message was deleted"))
                        if(CheckContains(webElement.GetAttribute("outerText")))
                        {
                            try
                            {
                                webElement.Click();
                                //var ChatArrow = webElement.FindElement(By.XPath("//span[@data-testid='msg-dblcheck']"));
                                //Thread.Sleep(500);
                                var ChatArrow = webElement.FindElement(By.XPath("//span[@data-testid='down-context']"));

                                ChatArrow.Click();
                                // Thread.Sleep(500);
                                var DeleteButton = webElement.FindElement(By.XPath("//div[@aria-label='Delete message']"));
                                DeleteButton.Click();

                                var DeleteForEveryone = publicDriver.FindElements(By.XPath("//div[@data-testid='content']"));

                                foreach (IWebElement deleteButton in DeleteForEveryone)
                                {
                                    if (deleteButton.GetAttribute("innerHTML").Contains("Delete for me"))
                                    {
                                        deleteButton.Click();
                                        numberOfDeletedMessages++;
                                        Settings.Default.OverallCount++;
                                        Settings.Default.Save();
                                    }
                                }
                            }
                            catch (Exception ekk)
                            {
                                Console.WriteLine(ekk.Message);
                            }

                        }
                    }
                    catch(OpenQA.Selenium.StaleElementReferenceException sere)
                    {
                        Console.WriteLine(sere.Message);
                    }
                   

                }
            }
            catch(NullReferenceException ma)
            {
                Console.WriteLine(ma.Message);
            }
        }

        private bool CheckContains(string message)
        {
            bool result = false;
            char[] seperators = { ',' };
            List<string> searchBoxSample = specificWordsBox.Text.Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToList();
            searchBoxSample.Add("You deleted this message");
            searchBoxSample.Add("This message was deleted");
            //result = searchStrings.Any(message.Contains);

            searchBoxSample = searchBoxSample.Distinct().ToList();

            result = searchBoxSample.Any(message.Contains);

            return result;
        }
        private void HeadlessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (headlessCheckBox.Checked)
            {
                headless = true;
            }
            else
            {
                headless = false;
            }
            Settings.Default.Headless = headless;
            Settings.Default.Save();
        }

        private void runAgainButton_Click(object sender, EventArgs e)
        {
            if(!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }   
            else
            {
                MessageBox.Show("Process Busy / Deletion Already Running")
;            }
            //reloadDeletion();
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            reloadDeletion();
        }

        private void specificDeletion_Click(object sender, EventArgs e)
        {
            specificWordsBox.Text = string.Join(",", searchStrings);
        }

        private void messageViewerButton_Click(object sender, EventArgs e)
        {           
            TMV.Show();
        }

        private void specificWordsBox_TextChanged(object sender, EventArgs e)
        {
           Settings.Default.SpecificWords = specificWordsBox.Text;
           Settings.Default.Save();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            UpdateLabels();
        }

        private void specificWordsLabel_DoubleClick(object sender, EventArgs e)
        {
            specificWordsBox.Text = "You deleted this message,This message was deleted";
        }
    }


}

