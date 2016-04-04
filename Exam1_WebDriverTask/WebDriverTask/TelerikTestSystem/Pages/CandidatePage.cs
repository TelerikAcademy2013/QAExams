namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using System.Threading;

    public class CandidatePage
    {
        private readonly string loginPageUrl = @"http://test.telerikacademy.com/";
        private readonly string textFill = "some text";
        private readonly string numberFill = "3";
        private readonly string pictureScript = "document.getElementById('Picture').value='" + "..\\\\..\\\\Files\\\\picture.png" + "';";
        private readonly string CVScript = "document.getElementById('CV').value='" + "..\\\\..\\\\Files\\\\document.docx" + "';";
        private readonly string coverLetterScript = "document.getElementById('CoverLetter').value='" + "..\\\\..\\\\Files\\\\document.docx" + "';";

        [FindsBy(How = How.Id, Using = "SecondName")]
        public IWebElement SecondName { get; set; }

        [FindsBy(How = How.Id, Using = "Question_1")]
        public IWebElement Question1 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_2")]
        public IWebElement Question2 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_3")]
        public IWebElement Question3 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_4")]
        public IWebElement Question4 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_5")]
        public IWebElement Question5 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_1")]
        public IWebElement Answer1 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_9")]
        public IWebElement Answer9 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_16")]
        public IWebElement Answer16 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_24")]
        public IWebElement Answer24 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_41")]
        public IWebElement Answer41 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_42")]
        public IWebElement Answer42 { get; set; }



        [FindsBy(How = How.Id, Using = "AcceptTerms")]
        public IWebElement AcceptTerms { get; set; }

        [FindsBy(How = How.Id, Using = "SendButton")]
        public IWebElement SendButton { get; set; }

        public void Navigate(IWebDriver browser)
        {
            browser.Navigate().GoToUrl(loginPageUrl);
            CandidateNavigationPage navigation = new CandidateNavigationPage();
            PageFactory.InitElements(browser, navigation);
            navigation.CandidateLink.Click();
        }

        public void Candidate(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
            this.SecondName.Clear();
            this.SecondName.SendKeys("Веселинов");
            this.Question1.Clear();
            this.Question1.SendKeys(textFill);
            this.Question2.Clear();
            this.Question2.SendKeys(numberFill);
            this.Question3.Clear();
            this.Question3.SendKeys(numberFill);
            this.Question4.Clear();
            this.Question4.SendKeys(numberFill);
            this.Question5.Clear();
            this.Question5.SendKeys(textFill);
            this.Answer1.Click();
            this.Answer1.Click();
            this.Answer16.Click();
            this.Answer24.Click();
            this.Answer9.Click();
            this.Answer41.Click();
            this.Answer42.Click();
            ((IJavaScriptExecutor)browser).ExecuteScript(pictureScript);
            ((IJavaScriptExecutor)browser).ExecuteScript(CVScript);
            ((IJavaScriptExecutor)browser).ExecuteScript(coverLetterScript);
            this.AcceptTerms.Click();
            this.SendButton.Click();
        }
    }
}
