namespace Demos.Telerik.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Demos.Telerik.Core.Pages.MainPage;
    using Demos.Telerik.Core.Pages.ComboBoxGrid;
    using QA.UI.TestingFramework.Core;
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    [TestClass]
    public class PointATests : BaseTest
    {
        public MainPage MainPage { get; set; }
        public ComboBoxGridPage ComboBoxGridPage { get; set; }

        public override void TestInit()
        {
            this.MainPage = new MainPage();
            this.ComboBoxGridPage = new ComboBoxGridPage();
            
            this.MainPage.Navigate();
            Thread.Sleep(1000);
            this.MainPage.SearchForGridFilteredByCombo();
            Thread.Sleep(1000);
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.MainPage.SelectGridFilteredByCombo();
            Thread.Sleep(1000);

            base.TestInit();
        }

        public override void TestCleanUp()
        {
        }

        [TestMethod]
        public void Test_001_VerifyCorrectDemoIsLoaded()
        {
            this.MainPage.Validator.AssertAtGridFilteredByCombo();
        }

        [TestMethod]
        public void Test_002_Test_Filtering()
        {
            this.ComboBoxGridPage.ClickFilterDropdown();
            this.ComboBoxGridPage.SelectListNameReginaMurphy();
            this.ComboBoxGridPage.Validator.AssertNumberOfRowsInGridIs3();
        }
    }
}
