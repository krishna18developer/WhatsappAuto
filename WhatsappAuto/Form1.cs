using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WhatsappAuto.Properties;

namespace WhatsappAuto
{
    public partial class Form1 : Form
    {
        EdgeDriver browser = null;
        EdgeOptions options;
        string ContactName = "BookMyShow";
        string StartingMessage = "s";
        string EndingMessage = "fdsf";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            textBox1.Text = Settings.Default.StartingMessage;
            textBox2.Text = Settings.Default.EndingMessage;
            killEdgePrograms();
            button2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            killEdgePrograms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            killEdgePrograms();
            Thread.Sleep(500);
            options = new EdgeOptions();
            string profilePath = @"C:\Users\Krishna Teja\AppData\Local\Microsoft\Edge\User Data";
            options.AddArgument("--user-data-dir=" + profilePath);
            options.AddArgument("--profile-directory=Profile 1");
            options.AddArgument("--start-maximized");
            //options.AddArgument("--headless");

            EdgeDriverService service = EdgeDriverService.CreateDefaultService(@"F:\Krishna Teja\Softwares\edgedriver_win64\msedgedriver.exe");
            // specify the path to the Edge browser executable
          //  options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
          // create a new EdgeDriver instance with the options
            try
            {
                //EdgeDriver browser = new EdgeDriver(@"F:\Krishna Teja\Softwares\edgedriver_win64\msedgedriver.exe",options);
                EdgeDriver browser = new EdgeDriver(service,options);

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
                foreach(IWebElement element1 in AllMessages)
                {
                    //Console.Write(element1.ToString());
                    if(element1.GetAttribute("textContent").Contains("You deleted this message") || element1.GetAttribute("textContent").Contains("This message was deleted"))
                    {
                        i++;
                    }
                    else 
                    {
                        bool present = false;
                        //var om = element1.FindElement(By.XPath("//span[@data-testid='tail-in']"));
                        if(once == false && element1.GetAttribute("textContent").Contains(StartingMessage))
                        {
                           // AllMessageForYou.Add(element1);
                            present = true;
                            once = true;
                        }
                        if(present==true && !(element1.GetAttribute("textContent").Contains(EndingMessage)))
                        {

                            IWebElement ie = element1.FindElement(By.ClassName("copyable-text"));
                            if(ie.GetAttribute("innerHTML").Contains(ContactName))
                            {
                                AllMessageForYou.Add(element1);
                                MessageBox.Show(ie.GetAttribute("innerHTML"));
                            }
                        }
                    }
                }
                label3.Text = "Total You Delete Messages : " + i;
                label4.Text = "";
                foreach(IWebElement IW in AllMessages)
                {
                    label4.Text += "\n" + IW.GetAttribute("textContent");
                }
                label5.Text = "All Our Messages : " + AllMessageForYou.Count;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StartingMessage = textBox1.Text;
            Settings.Default.StartingMessage = StartingMessage;
            Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            EndingMessage = textBox2.Text;
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
    }
}
