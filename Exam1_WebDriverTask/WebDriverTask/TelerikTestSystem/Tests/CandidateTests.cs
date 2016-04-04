namespace WebDriverTask.TelerikTestSystem.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using System;
    using TelerikTestSystem.Pages;
    using WebDriverTask.TelerikTestSystem.Verifications;

    [TestClass]
    public class CandidateTests : BaseWebDriverTest
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestInitialize]
        public void SetupTest()
        {
            this.Browser = new FirefoxDriver();
            this.BaseUrl = @"http://test.telerikacademy.com/";
            this.Wait = new WebDriverWait(this.Browser, TimeSpan.FromSeconds(10));
            this.TimeOut = 10;
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                this.Browser.Quit();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        [TestMethod]
        public void Login_Test_Telerik_Academy_And_Candidate()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Navigate(this.Browser);
            loginPage.LoginUser(this.Browser);
            CandidatePage candidatePage = new CandidatePage();
            candidatePage.Navigate(this.Browser);
            candidatePage.Candidate(this.Browser);
        }

        [TestMethod]
        public void Verify_Successful_Candidate()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Navigate(this.Browser);
            loginPage.LoginUser(this.Browser);
            VerifyCandidate candidate = new VerifyCandidate();
            candidate.Navigate(this.Browser);
            Assert.AreEqual<string>("mladenvm", candidate.CandidateUserName.Text);
        }

        [TestMethod]
        public void Delete_Candidate_From_Administration()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Navigate(this.Browser);
            loginPage.LoginUser(this.Browser);
            DeleteCandidatePage deleteCandidate = new DeleteCandidatePage();
            deleteCandidate.Navigate(this.Browser);
            deleteCandidate.DeleteCandidate(this.Browser);
            StringAssert.Contains(deleteCandidate.DeleteMessage.Text, "m.mladenov82@gmail.com");
        }

        [TestMethod]
        public void Verify_Candidate_List_Is_Empty()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Navigate(this.Browser);
            loginPage.LoginUser(this.Browser);
            VerifyCandidate candidate = new VerifyCandidate();
            candidate.Navigate(this.Browser);
            Assert.AreEqual<string>("", candidate.CandidateUserName.Text);
        }
    }
}
