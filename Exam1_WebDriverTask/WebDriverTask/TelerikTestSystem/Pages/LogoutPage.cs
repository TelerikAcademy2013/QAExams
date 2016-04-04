namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System.Threading;

    public class LogoutPage
    {
        private readonly string logoutPageUrl = @"http://test.telerikacademy.com/";
        
        public void Logout(IWebDriver browser)
        {
            browser.Navigate().GoToUrl(logoutPageUrl);
            MainNavigationPage navigation = new MainNavigationPage();
            PageFactory.InitElements(browser, navigation);
            navigation.AccountExitLink.Click();
        }

    }
}
