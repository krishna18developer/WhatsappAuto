using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WhatsappAuto.Properties;

namespace WhatsappAuto
{
    public partial class Form1 : Form
    {
        EdgeOptions options;
        string ContactName = Settings.Default.ContactName; //BookMyShow
        string StartingMessage = "s";
        string EndingMessage = "fdsf";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            chatStartPointBox.Text = Settings.Default.StartingMessage;
            chatEndPointBox.Text = Settings.Default.EndingMessage;
            killEdgePrograms();

            contactNameBox.Text = ContactName;
        }

        private void closeEdgeButton_Click(object sender, EventArgs e)
        {
            killEdgePrograms();
        }

        private void openEdgeButton_Click(object sender, EventArgs e)
        {
            killEdgePrograms();
            Thread.Sleep(500);
            options = new EdgeOptions();
            string profilePath = Settings.Default.ProfilePath;
            options.AddArgument("--user-data-dir=" + profilePath);
            options.AddArgument("--profile-directory=" + Settings.Default.ProfileDirectory);
            options.AddArgument("--start-maximized");
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

                Thread.Sleep(2000);

                IList<IWebElement> AllMessages = browser.FindElements(By.XPath("//div[@data-testid='msg-container']"));
                IList<IWebElement> AllMessageForYou = new List<IWebElement>();
                // MessageBox.Show(AllMessages.Count+"");
                int i = 0;
                bool once = false;
                foreach (IWebElement element1 in AllMessages)
                {
                    //Console.Write(element1.ToString());
                    if (element1.GetAttribute("textContent").Contains("You deleted this message") || element1.GetAttribute("textContent").Contains("This message was deleted"))
                    {
                        i++;
                    }
                    else
                    {
                        bool present = false;
                        //var om = element1.FindElement(By.XPath("//span[@data-testid='tail-in']"));
                        if (once == false && element1.GetAttribute("textContent").Contains(StartingMessage))
                        {
                            // AllMessageForYou.Add(element1);
                            present = true;
                            once = true;
                        }
                        if (present == true && !(element1.GetAttribute("textContent").Contains(EndingMessage)))
                        {

                            IWebElement ie = element1.FindElement(By.ClassName("copyable-text"));
                            if (ie.GetAttribute("innerHTML").Contains(ContactName))
                            {
                                AllMessageForYou.Add(element1);
                                MessageBox.Show(ie.GetAttribute("innerHTML"));
                            }
                        }
                    }
                }
                totalDeletedMssgesLabel.Text = "Total You Delete Messages : " + i;
                testLabel.Text = "";
                foreach (IWebElement IW in AllMessages)
                {
                    testLabel.Text += "\n" + IW.GetAttribute("textContent");
                }
                AllMessagesLabel.Text = "All Our Messages : " + AllMessageForYou.Count;
                //  MessageBox.Show(AllMessages.ToString());

                /*
                foreach(IWebElement element in AllMessages)
                {
                    if (element.GetAttribute("textContent") == EndingMessage)
                        break;
                    else
                    {
                        IWebElement ChatStartPoint = browser.FindElement(By.XPath("//span[.='"+ StartingMessage +"']"));
                        var ChatArrow = element.FindElement(By.XPath("//span[@data-testid='msg-dblcheck']"));
                        ChatStartPoint.Click();
                        Thread.Sleep(500);
                        ChatArrow = element.FindElement(By.XPath("//span[@data-testid='down-context']"));

                        ChatArrow.Click();
                        Thread.Sleep(500);
                        var DeleteButton = element.FindElement(By.XPath("//div[@aria-label='Delete message']"));
                        DeleteButton.Click();

                        var DeleteForEveryone = browser.FindElement(By.XPath("//div[@data-testid='content']"));

                        DeleteForEveryone.Click();
                        IWebElement ChatEndPoint = browser.FindElement(By.XPath("//span[.='asdfdffdfd']"));
                    }
                }
                */

            }
            catch (OpenQA.Selenium.WebDriverException e1)
            {
                Console.WriteLine(e1 + "");
                MessageBox.Show(e1 + "");
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

        }

        private void chatStartPointBox_TextChanged(object sender, EventArgs e)
        {
            StartingMessage = chatStartPointBox.Text;
            Settings.Default.StartingMessage = StartingMessage;
            Settings.Default.Save();
        }

        private void chatEndPointBox_TextChanged(object sender, EventArgs e)
        {
            EndingMessage = chatEndPointBox.Text;
            Settings.Default.EndingMessage = EndingMessage;
            Settings.Default.Save();
        }
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
            killEdgePrograms();
            Thread.Sleep(500);
            options = new EdgeOptions();
            string profilePath = Settings.Default.ProfilePath;
            options.AddArgument("--user-data-dir=" + profilePath);
            options.AddArgument("--profile-directory=" + Settings.Default.ProfileDirectory);
            options.AddArgument("--start-maximized");
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
                Thread.Sleep(2000);

            deletionProcedure:
                // IWebElement ChatStartPoint = browser.FindElement(By.XPath("//span[.='" + "You deleted this message" + "']"));
                IList< IWebElement> ChatStartPoint = browser.FindElements(By.XPath("//div[@data-testid='msg-container']"));
                foreach(IWebElement element in ChatStartPoint)
                {
                    testLabel.Text += element.GetAttribute("outerText");
                }

                foreach(IWebElement webElement in ChatStartPoint)
                {
                    if (webElement.GetAttribute("outerText").Contains("You deleted this message") || webElement.GetAttribute("outerText").Contains("This message was deleted"))
                    {
                        webElement.Click();
                        //var ChatArrow = webElement.FindElement(By.XPath("//span[@data-testid='msg-dblcheck']"));
                        Thread.Sleep(500);
                        var ChatArrow = webElement.FindElement(By.XPath("//span[@data-testid='down-context']"));

                        ChatArrow.Click();
                        Thread.Sleep(500);
                        var DeleteButton = webElement.FindElement(By.XPath("//div[@aria-label='Delete message']"));
                        DeleteButton.Click();

                        var DeleteForEveryone = browser.FindElements(By.XPath("//div[@data-testid='content']"));

                        foreach(IWebElement deleteButton in DeleteForEveryone)
                        {
                            if(deleteButton.GetAttribute("innerHTML").Contains("Delete for me"))
                            {
                                deleteButton.Click();
                            }

                        }
                    }

                }
                goto deletionProcedure;


            }
            catch (Exception ek)
            {

            }

        }

        public void ByVisibleElement()
        {

          //  var driver = new ChromeDriver();
            

            //Launch the application		
          //  driver.get("http://demo.guru99.com/test/guru99home/");

            //Find element by link text and store in variable "Element"        		
            //WebElement Element = driver.findElement(By.linkText("Linux"));

            //This will scroll the page till the element is found		
           // js.executeScript("arguments[0].scrollIntoView();", Element);
        }

    
        private void runAgainButton_Click(object sender, EventArgs e)
        {
           // goto deletionProcedure;
        }
    }
}

