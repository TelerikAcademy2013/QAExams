namespace WebDriverTask.TelerikTestSystem.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class CandidateNavigationPage
    {
        [FindsBy(How = How.LinkText, Using = "Кандидатстване за академията")]
        public IWebElement CandidateLink { get; set; }
    }
}