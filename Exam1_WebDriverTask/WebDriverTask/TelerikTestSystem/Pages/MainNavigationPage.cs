namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class MainNavigationPage
    {
        [FindsBy(How = How.Id, Using = "LoginButton")]
        public IWebElement YourAccountLink { get; set; }

        [FindsBy(How = How.Id, Using = "ExitMI")]
        public IWebElement AccountExitLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"MainContent\"]/a[66]")]
        public IWebElement AdminCandidates { get; set; }
    }
}
