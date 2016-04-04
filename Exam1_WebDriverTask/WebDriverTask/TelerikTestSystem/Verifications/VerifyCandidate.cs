namespace WebDriverTask.TelerikTestSystem.Verifications
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.PageObjects;
    using OpenQA.Selenium.Support.UI;
    using System;
    using TelerikTestSystem.Pages;

    public class VerifyCandidate
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"DataGrid\"]/table/tbody/tr[1]/td[3]/a")]
        public IWebElement CandidateUserName { get; set; }

        public void Navigate(IWebDriver browser)
        {
            AdminPage adminNavigation = new AdminPage();
            adminNavigation.Navigate(browser);
            MainNavigationPage candidatesNavigation = new MainNavigationPage();
            PageFactory.InitElements(browser, candidatesNavigation);
            candidatesNavigation.AdminCandidates.Click();
        }
    }
}
