namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System.Threading;

    public class LoginPage
    {
        private readonly string loginPageUrl = @"http://test.telerikacademy.com/";

        [FindsBy(How = How.Id, Using = "UsernameOrEmail")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"MainContent\"]/form/fieldset/input")]
        public IWebElement LoginButton { get; set; }

        public void Navigate(IWebDriver browser)
        {
            browser.Navigate().GoToUrl(loginPageUrl);
            MainNavigationPage navigation = new MainNavigationPage();
            PageFactory.InitElements(browser, navigation);
            navigation.YourAccountLink.Click();
        }

        public void LoginUser(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
            this.UserName.Clear();
            this.UserName.SendKeys("mladenvm");
            this.Password.Clear();
            this.Password.SendKeys("123654789");
            this.LoginButton.Submit();
        }
    }
}
