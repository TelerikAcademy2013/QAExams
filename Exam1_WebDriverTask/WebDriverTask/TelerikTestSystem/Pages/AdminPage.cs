namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System.Threading;

    public class AdminPage
    {
        private readonly string logoutPageUrl = @"http://test.telerikacademy.com/Administration/Navigation";

        public void Navigate(IWebDriver browser)
        {
            browser.Navigate().GoToUrl(logoutPageUrl);
        }
    }
}
