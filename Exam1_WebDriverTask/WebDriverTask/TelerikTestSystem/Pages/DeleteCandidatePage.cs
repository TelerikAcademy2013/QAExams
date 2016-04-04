namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.PageObjects;
    using OpenQA.Selenium.Support.UI;
    using System;
    using TelerikTestSystem.Pages;

    public class DeleteCandidatePage
    {
        private readonly string candidatesAdminPageUrl = @"http://test.telerikacademy.com/Administration_SoftwareAcademy/Candidates";
        private readonly string candidateEmailAddress = "m.mladenov82@gmail.com";

        [FindsBy(How = How.XPath, Using = "//*[@id=\"QaTestingTool\"]/form/fieldset/input[1]")]
        public IWebElement CandidateEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"QaTestingTool\"]/form/fieldset/input[2]")]
        public IWebElement DeleteCandidateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"DeletedCandidates\"]/div/text()")]
        public IWebElement DeleteMessage { get; set; }
        
        public void Navigate(IWebDriver browser)
        {
            browser.Navigate().GoToUrl(candidatesAdminPageUrl);
        }

        public void DeleteCandidate(IWebDriver browser)
        {
            this.CandidateEmail.Clear();
            this.CandidateEmail.SendKeys(candidateEmailAddress);
            this.DeleteCandidateButton.Submit();
        }
    }
}
